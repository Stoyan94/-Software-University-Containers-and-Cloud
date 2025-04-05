ENG VERSION:


---

## 🧩 **What is `connection_string` in Terraform context?**

```hcl
connection_string {
  name  = "DefaultConnection"
  type  = "SQLAzure"
  value = "Data Source=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.db.name};User ID=${azurerm_mssql_server.sqlserver.administrator_login};Password=${azurerm_mssql_server.sqlserver.administrator_login_password};Trusted_Connection=False; MultipleActiveResultSets=True;"
}
```

This block tells the **App Service (Linux Web App)** how to connect to your **Azure SQL Database**. 
Think of it as a piece of configuration that **automatically fills** the `appsettings.json` in your ASP.NET Core application under the `"DefaultConnection"` key.

---

## 🔬 Breakdown by line and element

### `name  = "DefaultConnection"`
- The name of the connection string within the App Service configuration.
- This is the key that your .NET application looks for in `IConfiguration["ConnectionStrings:DefaultConnection"]`.
- It typically matches `"DefaultConnection"` from `Startup.cs`, `appsettings.json`, etc.

---

### `type  = "SQLAzure"`
- The type of the connection – `SQLAzure` tells Azure that you are connecting to an **Azure SQL Database**, which:
  - Automatically encrypts the connection.
  - Enables specific security policies.
  - Helps Azure log and debug more effectively.
- Other valid types could be:
  - `"MySQL"`
  - `"Custom"`
  - `"SQLServer"` (if on-premises)
  
But `SQLAzure` is the correct one here for Azure SQL.

---

### `value = "..."`
Now comes the magic – the classic ADO.NET connection string. Let's break it down:

```txt
Data Source=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;
```
- **Data Source** specifies the location of the SQL server.
- `${azurerm_mssql_server.sqlserver.fully_qualified_domain_name}` will generate something like:
  ```
  taskboard-s32131.database.windows.net
  ```
- `tcp:` specifies the protocol.
- `1433` is the default port for SQL Server.

---

```txt
Initial Catalog=${azurerm_mssql_database.db.name};
```
- This specifies which database to use (like `USE [TaskBoarddb12345]`).
- `Initial Catalog` = database name.

---

```txt
User ID=${azurerm_mssql_server.sqlserver.administrator_login};
Password=${azurerm_mssql_server.sqlserver.administrator_login_password};
```
- Classic user/password authentication for accessing the database.
- ⚠️ This is not the most secure method in production. It's recommended to use:
  - **Managed Identity**
  - **Azure AD Authentication**

---

```txt
Trusted_Connection=False;
```
- This tells Azure **not to use Windows Authentication**.
- In Azure, this is always `False` unless you are in an AD domain and using AAD tokens.

---

```txt
MultipleActiveResultSets=True;
```
- Allows **multiple active `SqlDataReader` objects simultaneously**.
- Without this:
  ```csharp
  var reader1 = cmd1.ExecuteReader();
  var reader2 = cmd2.ExecuteReader(); // will fail if the first one isn't closed yet
  ```
- Not mandatory, but often used in ORMs like Entity Framework.

---

## 📦 What happens after `terraform apply`?

After running `terraform apply`, the App Service will get this connection string:

- In Azure Portal → Web App → Configuration → Connection Strings
- It will show up there with:
  - **Name**: `DefaultConnection`
  - **Value**: The full connection string
  - **Type**: `SQLAzure`

Then, your ASP.NET Core application will read it from `Environment Variables` and access it like:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "..."
  }
}
```

---

## 🛡️ Security Warning

> ❗ The password is stored in plain text within the Terraform configuration.

I recommend:
- Providing it through `terraform.tfvars` (which **is not uploaded to Git**).
- Or, even better – use [Azure Key Vault + App Service Managed Identity].

---

## 💡 Alternatives

- You could set it via `az webapp config connection-string set` if you don't want to store it in `.tf`.
- You could use `local.settings.json` (locally) and `appsettings.Production.json` (with CI/CD).






BG VERSION:


---

## 🧩 **Какво е `connection_string` в Terraform context?**

```hcl
connection_string {
  name  = "DefaultConnection"
  type  = "SQLAzure"
  value = "Data Source=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.db.name};User ID=${azurerm_mssql_server.sqlserver.administrator_login};Password=${azurerm_mssql_server.sqlserver.administrator_login_password};Trusted_Connection=False; MultipleActiveResultSets=True;"
}
```

Това блокче казва на **App Service-а (Linux Web App)** как да се свърже към твоя **Azure SQL Database**. 
Представи си го като парче конфигурация, което **автоматично попълва** `appsettings.json` в ASP.NET Core приложението ти под ключа `"DefaultConnection"`.

---

## 🔬 Разбивка по ред и елемент

### `name  = "DefaultConnection"`
- Име на connection string-а вътре в App Service конфигурацията.
- Това е ключът, който твоето .NET приложение очаква в `IConfiguration["ConnectionStrings:DefaultConnection"]`.
- Типично съвпада с `"DefaultConnection"` от `Startup.cs`, `appsettings.json` и т.н.

---

### `type  = "SQLAzure"`
- Типът на връзката – `SQLAzure` казва на Azure, че ще се свързваш към **Azure SQL Database**, което:
  - Автоматично криптира връзката.
  - Активира специфични политики за сигурност.
  - Помага на Azure да логва и дебъгва по-добре.
- Други валидни типове:
  - `"MySQL"`
  - `"Custom"`
  - `"SQLServer"` (ако е он-премис)
  
Но `SQLAzure` си е правилното тук за Azure SQL.

---

### `value = "..."`
Тук идва магията – класически ADO.NET connection string. Да го разбием:

```txt
Data Source=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;
```
- **Data Source** казва на клиента (Web App-а) къде се намира SQL сървърът.
- `${azurerm_mssql_server.sqlserver.fully_qualified_domain_name}` генерира нещо като:
  ```
  taskboard-s32131.database.windows.net
  ```
- `tcp:` указва протокола.
- `1433` е дефолтният порт за SQL Server.

---

```txt
Initial Catalog=${azurerm_mssql_database.db.name};
```
- Указва коя база да се използва (като `USE [TaskBoarddb12345]`).
- `Initial Catalog` = database name.

---

```txt
User ID=${azurerm_mssql_server.sqlserver.administrator_login};
Password=${azurerm_mssql_server.sqlserver.administrator_login_password};
```
- Класически потребител/парола за достъп.
- ⚠️ Това не е най-сигурният начин в production. Препоръчително е да се ползва:
  - **Managed Identity**
  - **Azure AD Authentication**

---

```txt
Trusted_Connection=False;
```
- Това казва да **не се използва Windows Authentication**.
- В Azure това винаги е `False`, освен ако не си в AD domain и не ползваш AAD tokens.

---

```txt
MultipleActiveResultSets=True;
```
- Позволява **няколко активни `SqlDataReader` обекта едновременно**.
- Без това:
  ```csharp
  var reader1 = cmd1.ExecuteReader();
  var reader2 = cmd2.ExecuteReader(); // ще гръмне, ако първият още не е затворен
  ```
- Не е задължително, но често се използва в ORM-и като Entity Framework.

---

## 📦 Какво става след apply?

След `terraform apply`, App Service-а получава това:

- В Azure Portal → Web App → Configuration → Connection Strings
- Там ще има запис:
  - **Name**: `DefaultConnection`
  - **Value**: Пълният connection string
  - **Type**: `SQLAzure`

И вече ASP.NET Core приложението ти ще чете от `Environment Variables` и ще намери това под:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "..."
  }
}
```

---

## 🛡️ Security Warning

> ❗ Паролата е в plain text вътре в Terraform конфигурацията.

Препоръчвам да:
- Я подаваш чрез `terraform.tfvars` (което **не се качва в Git**).
- Или още по-добре – да ползваш [Azure Key Vault + App Service Managed Identity].

---

## 💡 Алтернативи

- Може да го зададеш и чрез `az webapp config connection-string set` ако не искаш да го съхраняваш в `.tf`.
- Може да използваш `local.settings.json` (локално) и `appsettings.Production.json` (с CI/CD).