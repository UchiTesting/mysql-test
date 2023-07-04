Instructions
============

## Solutions for user secrets

Either:

- Create a user secrets folder manually named after the value in *csproj* file and put the *secrets.json* file in there
- Remove user secrets from *csproj* and start anew

## User Secrets: Create folder manually

- Go to User secrets folder on your system
  - Windows: *%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json*
  - Linux/MacOS: *~/.microsoft/usersecrets/<user_secrets_id>/secrets.json*
- Open the csproj file and copy the GUID for user secrets
  - `<UserSecretsId>e6db96f4-0dbe-491c-b414-61b814448cd9</UserSecretsId>`
  - Gives *e6db96f4-0dbe-491c-b414-61b814448cd9*
  - Create a *secrets.json* file in there with updated values (see [secrets.json template](<#secretsjson-template>))
## User Secrets: Start over

- Remove that line from *csproj* file
  - `<UserSecretsId>e6db96f4-0dbe-491c-b414-61b814448cd9</UserSecretsId>`
- From the project folder type those commands
  - `dotnet user-secrets init`
  - `dotnet user-secrets set "db:server" "serverName"`
  - `dotnet user-secrets set "db:database" "databaseName"`
  - `dotnet user-secrets set "db:user" "userName"`
  - `dotnet user-secrets set "db:password" "password"`

## *secrets.json* template

This is the template how it should look into the relevant folder (flattened structure).

```json
{
  "db:user": "userName",
  "db:server": "serveName",
  "db:database": "databaseName",
  "db:password": "password"
}
```
