## Deploying the cloudsql

```console
gcloud deployment-manager deployments create db01 \
    --config cloud_sql.yaml
```


## Modify the appsettings.Production.json

Modify the host, username and password to point to the one provisioned in GCP

```
"DefaultConnection": "Host=localhost;Port=5432;Username=postgres;Password=password;Database=CloudProvider;"
```