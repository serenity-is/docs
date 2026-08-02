<#
.SYNOPSIS
    Detaches (or drops) CourseTutorial_* and MovieTutorial_* databases from LocalDB.

.DESCRIPTION
    Cleans up the temporary databases created while running the Serene tutorials so
    the temp project folders (which hold the .mdf/.ldf files under App_Data) can be
    deleted safely.

    - If a database's .mdf file still exists on disk -> it is DETACHED (file handles
      released; no files are deleted).
    - If the .mdf file is already gone (an orphaned database whose folder was deleted
      earlier) -> it cannot be detached, so it is DROPPED (catalog-only cleanup; no
      files are lost because they are already gone).

.EXAMPLE
    .\detach-tutorial-dbs.ps1
#>

$ErrorActionPreference = 'Stop'
$server = '(localdb)\MsSqlLocalDB'

# DB name | physical mdf path, for every matching database
$rows = sqlcmd -S $server -h -1 -W -Q "SET NOCOUNT ON; SELECT d.name + '|' + mf.physical_name FROM sys.databases d JOIN sys.master_files mf ON d.database_id = mf.database_id AND mf.type = 0 WHERE (d.name LIKE 'CourseTutorial[_]%' OR d.name LIKE 'MovieTutorial[_]%') ORDER BY d.name;"

$detached = 0
$dropped = 0

foreach ($row in $rows) {
    $line = $row.Trim()
    if (-not $line) { continue }

    $parts = $line -split '\|', 2
    $db = $parts[0].Trim()
    $mdf = if ($parts.Count -ge 2) { $parts[1].Trim() } else { '' }

    if ($mdf -and (Test-Path -LiteralPath $mdf)) {
        Write-Host "Detaching $db ..."
        $out = sqlcmd -S $server -b -Q "ALTER DATABASE [$db] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; EXEC master.dbo.sp_detach_db @dbname = N'$db';" 2>&1
        if ($LASTEXITCODE -ne 0) { Write-Warning "  detach FAILED for $db`n$out"; continue }
        $detached++
    }
    else {
        Write-Host "Orphaned (file missing) - dropping $db ..."
        $out = sqlcmd -S $server -b -Q "DROP DATABASE [$db];" 2>&1
        # DROP on an orphaned DB may emit file-activation warnings yet still remove
        # the catalog entry, so confirm the database is actually gone.
        $stillThere = (sqlcmd -S $server -h -1 -W -Q "SET NOCOUNT ON; SELECT COUNT(*) FROM sys.databases WHERE name = '$db';" | Select-Object -Last 1).Trim()
        if ($LASTEXITCODE -ne 0 -and $stillThere -ne '0') {
            Write-Warning "  drop FAILED for $db`n$out"
            continue
        }
        $dropped++
    }
}

Write-Host ""
Write-Host "Done. Detached: $detached  |  Dropped (orphaned): $dropped."
if ($dropped -gt 0) {
    Write-Host "Note: the dropped databases had no .mdf files left on disk, so DROP only"
    Write-Host "      cleaned the LocalDB catalog entry - nothing on disk was deleted."
}
Write-Host "You can now delete the temp tutorial folders safely."
