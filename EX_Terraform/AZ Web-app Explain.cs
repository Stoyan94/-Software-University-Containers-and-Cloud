ENG VERSION:

### 1. **terraform block**
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
🔹 **What is this ? **
Here we tell Terraform which provider to use. In this case, it's **Azure** (via `azurerm`).

🔹 **Why?**  
Because we want Terraform to communicate with Azure and create resources there (like websites, databases, etc.).

🔹 **The version** is important to ensure we’re using compatible and stable code.

---

### 2. **provider "azurerm"**
```hcl
provider "azurerm" {
  features {}
  subscription_id = "*******************"
}
```
🔹 **What is this ? **
This tells Terraform that we will be using a specific account(called a "subscription") in Azure.

🔹 `features {}` — This is just required to enable basic Azure resource capabilities.

---

### 3. **random_integer**
```hcl
resource "random_integer" "random_integer" {
  min = 10000
  max = 99999
}
```
🔹 **What is this ? **
Generates a random number between 10000 and 99999.

🔹 **Why?**  
To make resource names unique. For example, `TaskBordRG54789`, so there are no conflicts with other resources in Azure.

---

### 4. **azurerm_resource_group**
```hcl
resource "azurerm_resource_group" "arg" {
  name     = "TaskBordRG${random_integer.random_integer.result}"
  location = "italy North"
}
```
🔹 **What is this ? **
This is a * *group * *where all related resources will be stored. Think of it like a **folder in the cloud**.

🔹 **Why?**  
It’s easier to manage and delete things when they are grouped together.  

🔹 **`location`** specifies the physical location of the data center — "Italy North" (cloud data center in Italy).

---

### 5. **azurerm_service_plan**
```hcl
resource "azurerm_service_plan" "asp" {
  name                = "TaskBordServicePlan${random_integer.random_integer.result}"
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_resource_group.arg.location
  os_type             = "Linux"
  sku_name            = "F1"
}
```
🔹 **What is this ? **
This is a "plan" for the web application — how many resources(CPU, RAM) it will get.

🔹 `sku_name = "F1"` — This is a * *free plan * *, the most basic one.

🔹 `os_type = "Linux"` — The application will run on Linux, not Windows.

-- -

### 6. **azurerm_linux_web_app**
```hcl
resource "azurerm_linux_web_app" "alwa" {
    name = "TaskoBordStoyan"...
}
```
🔹 **What is this ? **
This is the * *actual website * *that will be hosted in the cloud — a .NET application.

🔹 `name = "TaskoBordStoyan"` — The name of the web app, it must be globally unique.

🔹 `site_config > application_stack > dotnet_version = "6.0"`  
Here we specify that the site is a .NET 6.0 application.

🔹 `connection_string` — This is the **information for connecting to the database**:
```text
Data Source = where the database is located;
Initial Catalog = the name of the database;
User ID and Password = login credentials;
```

---

### 7. **azurerm_mssql_server**
```hcl
resource "azurerm_mssql_server" "sqlserver" {
  name = "takskboard-s${random_integer.random_integer.result}"
  ...
}
```
🔹 **What is this ? **
This is an * *SQL server * * in Azure — a machine that hosts the database.

🔹 `administrator_login/password` — Admin credentials for login.

🔹 `version = "12.0"` — The version of SQL Server.

---

### 8. **azurerm_mssql_database**
```hcl
resource "azurerm_mssql_database" "db" {
  name           = "taskboarddb${random_integer.random_integer.result}"
  ...
}
```
🔹 **What is this ? **
The * *actual database * *that will be used by the site.

🔹 `sku_name = "S0"` — Defines how powerful the database will be (this is the basic paid one).

🔹 `enclave_type = "VBS"` — Security improvement (virtual protection).

---

### 9. **azurerm_mssql_firewall_rule**
```hcl
resource "azurerm_mssql_firewall_rule" "firewall" {
  name             = "FirewallRule1"
  ...
}
```
🔹 **What is this ? **
This is a * *firewall rule * *that says: "allow connections to the SQL server".

🔹 `0.0.0.0` means: allow** all IP addresses** (it might not be the most secure, but it’s convenient for testing).

---

### 10. **azurerm_app_service_source_control**
```hcl
resource "azurerm_app_service_source_control" "azsc" {
  app_id   = azurerm_linux_web_app.alwa.id
  repo_url = "https://github.com/Stoyan94/TaskBoard-Azure-Deploy"
  ...
}
```
🔹 **What is this ? **
Links the web application with the **code server** in GitHub.

🔹 `branch = "master"` — It will take the code from the main branch.

🔹 `use_manual_integration = true` — We’re saying there’s no automatic deployment, but it’s managed manually.

---

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

This should now be easy to follow! Let me know if you need further details.





BG VERSION:

Супер, Стояне! Ще ти обясня целия Terraform код, **стъпка по стъпка**, така че дори някой без технически опит да разбере какво се случва.
Представи си, че **създаваш уеб приложение в облака (в случая Azure)**, и използваш Terraform като автоматизиран „строител“, който изпълнява твоите инструкции.

---

## 🔧 1. **terraform block**
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
🔹 **Какво е това?**  
Тук казваме на Terraform кой доставчик (provider) ще използваме. В случая това е **Azure** (через `azurerm`).

🔹 **Защо?**  
Защото искаме Terraform да говори с Azure и да създава ресурси там (като сайтове, бази данни и т.н.).

🔹 **Версията** е важна, за да сме сигурни, че използваме съвместим и стабилен код.

---

## ☁️ 2. **provider "azurerm"**
```hcl
provider "azurerm" {
  features {}
  subscription_id = "*******************"
}
```
🔹 **Какво е това?**  
Това казва на Terraform, че ще използваме конкретен акаунт (наречен „абонамент“) в Azure.

🔹 `features {}` — просто се изисква, за да активира базовите възможности на Azure ресурси.

---

## 🎲 3. **random_integer**
```hcl
resource "random_integer" "random_integer" {
  min = 10000
  max = 99999
}
```
🔹 **Какво е това?**  
Генерира произволно число между 10000 и 99999.

🔹 **Защо?**  
За да направим имената на ресурсите уникални. Например, `TaskBordRG54789`, така няма конфликт с други ресурси в Azure.

---

## 📦 4. **azurerm_resource_group**
```hcl
resource "azurerm_resource_group" "arg" {
  name     = "TaskBordRG${random_integer.random_integer.result}"
  location = "italy North"
}
```
🔹 **Какво е това?**  
Това е **група**, в която ще се съхраняват всички свързани ресурси. Представи си я като **папка в облака**.

🔹 **Защо?**  
По-лесно е да управляваш и триеш неща, когато са групирани.  

🔹 **`location`** е физическо място на датацентъра — "Italy North" (облачен център в Италия).

---

## 💻 5. **azurerm_service_plan**
```hcl
resource "azurerm_service_plan" "asp" {
  name                = "TaskBordServicePlan${random_integer.random_integer.result}"
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_resource_group.arg.location
  os_type             = "Linux"
  sku_name            = "F1"
}
```
🔹 **Какво е това?**  
Това е „план“ за уеб приложение — колко ресурси (CPU, RAM) ще получи.

🔹 `sku_name = "F1"` — това е **безплатен план**, най-базов.

🔹 `os_type = "Linux"` — приложението ще работи под Linux, не Windows.

---

## 🌐 6. **azurerm_linux_web_app**
```hcl
resource "azurerm_linux_web_app" "alwa" {
  name                = "TaskoBordStoyan"
  ...
}
```
🔹 **Какво е това?**  
Това е **истинският уеб сайт**, който ще бъде качен в облака — хостнато .NET приложение.

🔹 `name = "TaskoBordStoyan"` — име на уеб приложението, трябва да е уникално в целия свят.

🔹 `site_config > application_stack > dotnet_version = "6.0"`  
Тук казваме, че сайтът е .NET 6.0 приложение.

🔹 `connection_string` — това е **информацията за свързване с базата данни**:
```text
Data Source = къде се намира базата данни;
Initial Catalog = името на базата;
User ID и Password = данни за вход;
```

---

## 🛢️ 7. **azurerm_mssql_server**
```hcl
resource "azurerm_mssql_server" "sqlserver" {
  name = "takskboard-s${random_integer.random_integer.result}"
  ...
}
```
🔹 **Какво е това?**  
Това е **SQL сървър** в Azure — машина, която хоства базата данни.

🔹 `administrator_login/password` — входни данни за администратор.

🔹 `version = "12.0"` — версията на SQL Server.

---

## 📊 8. **azurerm_mssql_database**
```hcl
resource "azurerm_mssql_database" "db" {
  name           = "taskboarddb${random_integer.random_integer.result}"
  ...
}
```
🔹 **Какво е това?**  
Истинската **база данни**, която ще се използва от сайта.

🔹 `sku_name = "S0"` — определя колко мощна ще е базата (тук е основна, платена).

🔹 `enclave_type = "VBS"` — подобрение на сигурността (виртуална защита).

---

## 🔥 9. **azurerm_mssql_firewall_rule**
```hcl
resource "azurerm_mssql_firewall_rule" "firewall" {
  name             = "FirewallRule1"
  ...
}
```
🔹 **Какво е това?**  
Това е **правило за защитна стена**, което казва: „позволи връзка към SQL сървъра“.

🔹 `0.0.0.0` значи: позволи на **всички IP адреси** (може да не е най-сигурно, но е удобно за тестове).

---

## 🔗 10. **azurerm_app_service_source_control**
```hcl
resource "azurerm_app_service_source_control" "azsc" {
  app_id   = azurerm_linux_web_app.alwa.id
  repo_url = "https://github.com/Stoyan94/TaskBoard-Azure-Deploy"
  ...
}
```
🔹 **Какво е това?**  
Свързва уеб приложението със **сървъра на кода** в GitHub.

🔹 `branch = "master"` — ще вземе кода от главния клон.

🔹 `use_manual_integration = true` — казваме, че няма автоматичен deploy, а се управлява ръчно.

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