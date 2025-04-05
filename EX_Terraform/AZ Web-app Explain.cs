ENG VERSION:

---

## 🧠 **1. `terraform` block**

```hcl
terraform
{
    required_providers
    {
        azurerm = {
            source = "hashicorp/azurerm"
          version = "4.25.0"
        }
    }
}
```

### ✅ What it does:
-Declares that we’re using **Azure Resource Manager(azurerm)** as our cloud provider.
-Specifies the** provider source** as `"hashicorp/azurerm"` – official from HashiCorp.
- Pins the version to `4.25.0`, avoiding breaking changes from future versions.

### 💡 Pro tips:
- To always use the latest compatible version (not ideal for production):
  ```hcl
  version = "~> 4.0"
  ```
- Terraform fetches this provider from the [Terraform Registry] (https://registry.terraform.io/).

---

## 🌍 **2. `provider` block (azurerm)**

```hcl
provider "azurerm" {
  features {}
  subscription_id = "4f627dc8-8f5a-4112-a072-9284f6d182d0"
}
```

### ✅ What it does:
-Configures Azure as the target cloud for deploying infrastructure.
- `features {}` is required with modern `azurerm` versions, even if left empty.
- Specifies a particular Azure `subscription_id` for resource provisioning.

### 💡 Best practices:
- Use environment variables or Azure CLI for authentication in production.
- Run `az login` for local development authentication.

---

## 🎲 **3. `random_integer` resource**

```hcl
resource "random_integer" "random_integer" {
  min = 10000
  max = 99999
}
```

### ✅ What it does:
-Generates a** random number** between 10000 and 99999.
- This is typically used as a **suffix** in resource names for uniqueness.

### 💡 Why it matters:
- Some Azure resources require globally unique names (e.g., App Services, SQL servers).
- This ensures no name collision during `terraform apply`.

---

## 🏗️ **4. `azurerm_resource_group`**

```hcl
resource "azurerm_resource_group" "arg" {
  name     = var.resource_group_name
  location = var.resource_group_location
}
```

### ✅ What it does:
-Creates an Azure Resource Group – a logical container for all resources.

### 💡 Tips:
- Deleting the group in Azure deletes **all** resources inside it.
- Ensure all resources share the same region as the resource group.

---

## ☁️ **5. `azurerm_service_plan`**

```hcl
resource "azurerm_service_plan" "asp" {
  name                = var.sql_server_name
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_resource_group.arg.location
  os_type             = "Linux"
  sku_name            = "F1"
}
```

### ✅ What it does:
-Creates an App Service Plan (the hosting environment for Web Apps).
- `sku_name = "F1"` is the **free** tier.

### 💡 Considerations:
- `os_type = "Linux"` means the app will run on a Linux container.
- `F1` has serious limitations (no custom domains, no Always On).
- Use `B1`, `P1v2`, or higher for production.

---

## 🧑‍💻 **6. `azurerm_linux_web_app`**

```hcl
resource "azurerm_linux_web_app" "alwa" {
  ...
  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
    always_on = false
  }
  connection_string {
    ...
  }
}
```

### ✅ What it does:
-Deploys a Web App on Azure App Services running on Linux.
- Configures the .NET 6.0 runtime.
- Attaches a database connection string.

### 💡 Tips:
- `always_on = false` is required for free plans, but apps may "go to sleep".
- You can deploy Docker images, custom domains, and enable SSL.
- Add deployment slots for staging environments.

---

## 🗄️ **7. `azurerm_mssql_server`**

```hcl
resource "azurerm_mssql_server" "sqlserver" {
  name                         = var.sql_server_name
  resource_group_name          = azurerm_resource_group.arg.name
  location                     = azurerm_resource_group.arg.location
  version                      = "12.0"
  administrator_login          = var.sql_admin_login
  administrator_login_password = var.sql_admin_login_password
  minimum_tls_version          = "1.2"
}
```

### ✅ What it does:
-Creates a managed **SQL Server** in Azure.
- Configures admin login and password.

### 💡 Notes:
- `version = "12.0"` is the default backend version for Azure SQL, not SQL Server 2012.
- Direct machine access is **not possible** – only via connection strings/firewalls.

---

## 💾 **8. `azurerm_mssql_database`**

```hcl
resource "azurerm_mssql_database" "db" {
  name                 = var.sql_database_name
  server_id            = azurerm_mssql_server.sqlserver.id
  collation            = "SQL_Latin1_General_CP1_CI_AS"
  license_type         = "LicenseIncluded"
  max_size_gb          = 2
  sku_name             = "S0"
  enclave_type         = "VBS"
  zone_redundant       = false
  storage_account_type = "Zone"
  geo_backup_enabled   = false
}
```

### ✅ What it does:
-Provisions a new **database * * in the SQL server.

### 💡 Considerations:
- `S0` is the lowest paid tier (ideal for testing).
- `geo_backup_enabled = false` disables automatic cross-region backups.
- `enclave_type = "VBS"` is for confidential computing – can be omitted in basic setups.

---

## 🔥 **9. `azurerm_mssql_firewall_rule`**

```hcl
resource "azurerm_mssql_firewall_rule" "firewall" {
  name             = var.firewall_rule_name
  server_id        = azurerm_mssql_server.sqlserver.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"
}
```

### ✅ What it does:
-Opens the database to allow **Azure services** access.

### 💡 Important:
- `0.0.0.0` is a **special Azure-reserved IP** allowing internal services.
-To allow your machine, set `start_ip_address = "your.public.ip"`.

---

## 🔗 **10. `azurerm_app_service_source_control`**

```hcl
resource "azurerm_app_service_source_control" "azsc" {
  app_id                 = azurerm_linux_web_app.alwa.id
  repo_url               = var.repo_url
  branch                 = "master"
  use_manual_integration = true
}
```

### ✅ What it does:
-Connects the Web App to a GitHub repository.
- Configures deployments from the `master` branch.

### 💡 Details:
- `use_manual_integration = true` means **no automatic webhook**.
- Set it to `false` for automatic deploy on push.
- For advanced CI/CD: consider GitHub Actions or Azure DevOps Pipelines.

---

## 🧮 **11. `variables.tf`**

```hcl
variable "sql_database_name" {
  type        = string
  description = "The name of the database."
}
```

### ✅ What it does:
-Declares * *input variables** required by the Terraform config.

### 💡 Usage:
- You can define defaults:
  ```hcl
  variable "sql_database_name" {
    default = "MyDB"
  }
  ```
-Provide values via:
  - `-var - file = "values.tfvars"`
  - `-var 'sql_database_name=abc'`
  -Environment variable: `TF_VAR_sql_database_name = abc`

---

## 🧠 Bonus: Suggestions & Best Practices

-Use `locals` for consistent naming:
  ```hcl
  locals
{
    suffix = random_integer.random_integer.result
    sql_server_name = "sql-${local.suffix}"
  }
  ```

- Add an `outputs.tf` to expose useful data:
  ```hcl
  output "webapp_url" {
    value = azurerm_linux_web_app.alwa.default_site_hostname
  }
  ```

- Split your configuration into:
  - `main.tf` – core resources
  - `provider.tf` – provider setup
  - `variables.tf` – input variables
  - `outputs.tf` – result values
  - `values.tfvars` – actual values

---

## 🔚 Summary Table:

| Component           | What is it?             | What does it do? |
|---------------------|-------------------------|------------------|
| Terraform Provider  | Sets up connection with Azure | Authorizes access |
| Resource Group      | Folder in the cloud     | Gathers related resources together |
| Service Plan        | Plan for the site       | Defines how many resources the web app will use |
| Linux Web App       | Web application (.NET)  | This is your website |
| SQL Server          | Host for databases      | The place where the database is stored |
| SQL Database        | The actual database     | Connects to the site |
| Firewall Rule       | Access to the database  | Allows external access |
| Source Control      | Links to GitHub         | Automatically loads code |

---

Ако искаш, мога да го запазя като Markdown, PDF или да добавя примерна структура на директория. Кажи какво следва, мастер. 😎


### 🧠 Summary:

| Component           | What is it?             | What does it do? |
|---------------------|-------------------------|------------------|
| Terraform Provider  | Sets up connection with Azure | Authorizes access |
| Resource Group      | Folder in the cloud     | Gathers related resources together |
| Service Plan        | Plan for the site       | Defines how many resources the web app will use |
| Linux Web App       | Web application (.NET)  | This is your website |
| SQL Server          | Host for databases      | The place where the database is stored |
| SQL Database        | The actual database     | Connects to the site |
| Firewall Rule       | Access to the database  | Allows external access |
| Source Control      | Links to GitHub         | Automatically loads code |

---






BG VERSION:


- `terraform` блок
- `provider`
- `resource` за всяка услуга (resource group, service plan, web app, SQL сървър и т.н.)
- `variables`
- Динамични имена с `random_integer`
- Идеи за подобрения и добри практики

---

## 🔧 **1. terraform блок**:

```hcl
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "4.25.0"
    }
  }
}
```

### ✅ Какво прави:
- Декларира, че проектът използва **Azure Resource Manager (azurerm)** като доставчик на ресурси.
- Задава **източника** на доставчика: `"hashicorp/azurerm"` – официален от HashiCorp.
- Фиксира версията до `4.25.0`, което предотвратява проблеми от промени в API между версии.

### 💡 Полезни факти:
- Ако искаш винаги най-новата версия (не се препоръчва за production), може да пишеш:
  ```hcl
  version = "~> 4.0"
  ```
- Terraform ще търси този доставчик в [Terraform Registry](https://registry.terraform.io/).

---

## 🌍 **2. provider блок (azurerm)**:

```hcl
provider "azurerm" {
  features {}
  subscription_id = "4f627dc8-8f5a-4112-a072-9284f6d182d0"
}
```

### ✅ Какво прави:
- Настройва Azure като целева платформа за Terraform.
- `features {}` е изискване от новите версии на `azurerm`, дори да е празно.
- Задава конкретно `subscription_id`, което казва в коя Azure абонаментна сметка ще се създават ресурсите.

### 💡 Полезни факти:
- За production: по-добре е `subscription_id`, `client_id`, `client_secret`, `tenant_id` да се четат от ENV или Azure CLI логин.
- `az login` в терминал е по-добър начин за автентикация в development.

---

## 🎲 **3. random_integer ресурс**

```hcl
resource "random_integer" "random_integer" {
  min = 10000
  max = 99999
}
```

### ✅ Какво прави:
- Генерира **случайно число** между 10000 и 99999.
- Това число се използва като **суфикс** за имената на ресурсите, за да са уникални.

### 💡 Защо е важно:
- Azure не позволява дублирани имена на някои ресурси (например App Services, SQL сървъри).
- Използвайки `random_integer`, всяко `terraform apply` ще създаде уникални ресурси.

---

## 🏗️ **4. azurerm_resource_group**

```hcl
resource "azurerm_resource_group" "arg" {
  name     = var.resource_group_name
  location = var.resource_group_location
}
```

### ✅ Какво прави:
- Създава Azure Resource Group – логически контейнер, който събира всички ресурси.

### 💡 Особености:
- Ако искаш да изтриеш всичко наведнъж, просто изтрий тази група в Azure – всичко вътре пада.
- `location` трябва да съвпада с другите ресурси (пример: "North Europe").

---

## ☁️ **5. azurerm_service_plan**

```hcl
resource "azurerm_service_plan" "asp" {
  name                = var.sql_server_name
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_resource_group.arg.location
  os_type             = "Linux"
  sku_name            = "F1"
}
```

### ✅ Какво прави:
- Създава App Service план, върху който ще се хоства Web App-а.
- `sku_name = "F1"` е най-евтината (безплатна) опция.

### 💡 Особености:
- `os_type = "Linux"` – това означава, че ще се използват Linux базирани контейнери.
- `F1` има ограничения: няма custom domains, няма "Always On".
- За production се ползва поне `B1` или `P1v2`.

---

## 🧑‍💻 **6. azurerm_linux_web_app**

```hcl
resource "azurerm_linux_web_app" "alwa" {
  ...
  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
    always_on = false
  }
  connection_string {
    ...
  }
}
```

### ✅ Какво прави:
- Създава Web App в Azure, хостван в App Service плана.
- Конфигурира .NET 6.0 среда.
- Свързва се със SQL база данни чрез connection string.

### 💡 Особености:
- `always_on = false` – това ще спира апликацията, когато няма трафик (при безплатни планове).
- Можеш да добавиш слотове (deployment slots), custom domains, SSL и др.
- Terraform може да деплойва и Docker images чрез `container_settings`.

---

## 🗄️ **7. azurerm_mssql_server**

```hcl
resource "azurerm_mssql_server" "sqlserver" {
  name                         = var.sql_server_name
  resource_group_name          = azurerm_resource_group.arg.name
  location                     = azurerm_resource_group.arg.location
  version                      = "12.0"
  administrator_login          = var.sql_admin_login
  administrator_login_password = var.sql_admin_login_password
  minimum_tls_version          = "1.2"
}
```

### ✅ Какво прави:
- Създава SQL Server инстанция в Azure.
- Използва потребител и парола за администраторски достъп.

### 💡 Особености:
- `version = "12.0"` всъщност не е пълно MSSQL 2012, а просто версия на Azure SQL backend.
- Не можеш да достъпваш машината директно – само чрез connection string и firewall правила.

---

## 💾 **8. azurerm_mssql_database**

```hcl
resource "azurerm_mssql_database" "db" {
  name                 = var.sql_database_name
  server_id            = azurerm_mssql_server.sqlserver.id
  collation            = "SQL_Latin1_General_CP1_CI_AS"
  license_type         = "LicenseIncluded"
  max_size_gb          = 2
  sku_name             = "S0"
  enclave_type         = "VBS"
  zone_redundant       = false
  storage_account_type = "Zone"
  geo_backup_enabled   = false
}
```

### ✅ Какво прави:
- Създава база данни в горния SQL Server.

### 💡 Полезни неща:
- `sku_name = "S0"` – най-ниското платено ниво.
- `enclave_type = "VBS"` – използва виртуален защитен модул (не винаги нужен).
- `geo_backup_enabled = false` – по подразбиране Azure прави backup-и, тук ги изключваме.

---

## 🔥 **9. azurerm_mssql_firewall_rule**

```hcl
resource "azurerm_mssql_firewall_rule" "firewall" {
  name             = var.firewall_rule_name
  server_id        = azurerm_mssql_server.sqlserver.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"
}
```

### ✅ Какво прави:
- Отваря SQL сървъра за IP-та.
- `0.0.0.0` е специален адрес, който **позволява достъп на Azure услуги**.

### 💡 Внимание:
- Ако искаш достъп от твоето IP, трябва да зададеш `start_ip_address` и `end_ip_address` с твоя реален IP.

---

## 🔗 **10. azurerm_app_service_source_control**

```hcl
resource "azurerm_app_service_source_control" "azsc" {
  app_id                 = azurerm_linux_web_app.alwa.id
  repo_url               = var.repo_url
  branch                 = "master"
  use_manual_integration = true
}
```

### ✅ Какво прави:
- Свързва App Service-а с GitHub repository.
- Задава деплой от master branch, но без автоматичен hook.

### 💡 Особености:
- Ако искаш автоматичен деплой при push, ползвай `use_manual_integration = false`.
- Може да се настрои и CI/CD с GitHub Actions или Azure Pipelines.

---

## 🧮 **11. variables.tf**

```hcl
variable "sql_database_name" {
  type        = string
  description = "The name of the database."
}
```

### ✅ Какво прави:
- Това са **входни параметри**, които Terraform ще очаква от потребителя (или от `.tfvars` файл).

### 💡 Особености:
- Ако искаш да им зададеш стойности по подразбиране:
  ```hcl
  variable "sql_database_name" {
    type        = string
    default     = "MyDB"
    description = "..."
  }
  ```
- Можеш да ги предаваш с:
  - `-var-file="values.tfvars"`
  - `-var 'sql_database_name=abc'`
  - или чрез ENV: `TF_VAR_sql_database_name=abc`

---

## 🧠 Бонус: Какво можеш да добавиш/подобриш?

- Използвай `locals` за генериране на имена с `random_integer`, вместо да го правиш ръчно:
  ```hcl
  locals {
    suffix = random_integer.random_integer.result
    sql_server_name = "sql-${local.suffix}"
  }
  ```

- Добави `outputs.tf`, за да виждаш важни неща след `terraform apply`:
  ```hcl
  output "webapp_url" {
    value = azurerm_linux_web_app.alwa.default_site_hostname
  }
  ```

- Раздели файловете:
  - `main.tf` – ресурси
  - `variables.tf`
  - `outputs.tf`
  - `provider.tf`
  - `values.tfvars`

---

## 🧠 Обобщено:

| Компонент          | Какво е това             | Какво прави |
|-----------|--------|--------------------------|
| Terraform Provider | Настройва връзка с Azure | Упълномощава достъпа |
| Resource Group     | Папка в облака           | Събира всички ресурси на едно място |
| Service Plan       | План за сайта            | Определя колко ресурси ще ползва уеб приложението |
| Linux Web App      | Уеб приложение (.NET)    | Това е твоят уебсайт |
| SQL Server         | Хост за бази данни       | Място където се държи базата |
| SQL Database       | Истинската база данни    | Връзва се със сайта |
| Firewall Rule      | Достъп до базата         | Разрешава външен достъп |
| Source Control     | Свързване с GitHub       | Автоматично зареждане на кода |