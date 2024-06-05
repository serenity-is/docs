# Upload Antivirus Scanner

## Virus Scanning Configuration

Your application can scan uploaded files for viruses using ClamAV. The settings for this can be found in `appsettings.json` and `appsettings.Development.json`.


### Configuration

This is disabled by default in Development environment (`appsettings.Development.json`) and is enabled in Production environment (`appsettings.json`).

If you wish to disable AV scan (at your own risk!) modify the setting as shown below:

```json
"ClamAV": {
    "Enabled": false
}
```

It is possible to use a local ClamAV installation (default is `localhost:3310`) or a remote one by setting the configuration as below:

```json
"ClamAV": {
    "Enabled": true,
    "Host": "mycustomclamavhost.com",
    "Port": 3310
}
```

### Common Issues

1. **Error: "An error occurred while scanning the uploaded file for viruses!"**
   - Ensure ClamAV is installed and running.
   - Check the `ClamAV:Enabled` setting in your configuration files.
   - Check that the host / port is correct