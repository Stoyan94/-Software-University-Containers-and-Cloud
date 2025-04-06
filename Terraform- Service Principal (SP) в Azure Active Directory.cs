ENG VERSION:

Absolutely, master. Here is the **full translation in English**, combining both explanations in a clear and professional way:

---

## 🔐 Command:

```bash
az ad sp create-for-rbac \
  --name "Stoyan-Terraform-SP-Contributor" \
  --role contributor \
  --scopes /subscriptions/11111111111\
  --sdk-auth
```

---

## 🧠 What this command does:

### 1. `az ad sp create-for-rbac`
Creates a **Service Principal (SP)** in Azure Active Directory. This is a special type of identity used by:
-Terraform
- Scripts
- CI / CD tools(e.g., GitHub Actions, Azure DevOps)
- Azure SDKs(Python, .NET, Node.js, etc.)

It allows secure, automated access to Azure resources.

---

### 2. `--name "Stoyan-Terraform-SP-Contributor"`
Specifies the name of the Service Principal. Best practice is to name it according to its purpose – in this case, it’s meant for Terraform and assigned the "Contributor" role.

---

### 3. `--role contributor`
Assigns the **Contributor** role to the SP, which grants:
✅ Full read/write access to create, update, and delete resources  
⛔ No permission to manage RBAC (i.e., can’t assign roles to other users)

---

### 4. `--scopes /subscriptions/<subscription-id>`
Restricts the SP’s permissions to a **specific scope** – in this case:
-An entire Azure Subscription with the ID `1111111111111111`  
(You can also limit it to a specific Resource Group or resource)

---

### 5. `--sdk-auth`
💎 This is a very useful flag!  
It returns the authentication details in a **JSON format compatible with SDKs, Terraform, and CI/CD tools**.

The output will look like this:

```json
{
  "clientId": "SP-app-id",
  "clientSecret": "SP-password",
  "subscriptionId": "111111111111111111111111111111",
  "tenantId": "tenant-id",
  "activeDirectoryEndpointUrl": "https://login.microsoftonline.com",
  "resourceManagerEndpointUrl": "https://management.azure.com/",
  ...
}
```

This JSON can be:
-Stored as a secret in **GitHub Actions**
- Used directly by **Terraform**
- Consumed by any **Azure SDK**

---

## 🎯 What this Service Principal can be used for:

| Use Case               | Description                                                              |
|------------------------|--------------------------------------------------------------------------|
| Terraform Provider     | To automate the creation and management of Azure infrastructure          |
| GitHub Actions / DevOps| CI/CD pipelines – securely authenticate with Azure                       |
| Scripts / CLI          | Scripting or CLI-based automation with Azure resources                   |
| Azure REST API         | Secure programmatic access to Azure APIs                                 |

---

## 🧱 Example: Terraform provider with this SP

```hcl
provider "azurerm" {
  features = {}

  subscription_id = "11111111111111111111111111"
  client_id = "SP-app-id"
  client_secret = "SP-password"
  tenant_id = "tenant-id"
}
```

---

## 🧪 Example: GitHub Actions usage

1.Copy the JSON output from `--sdk-auth`
2. Save it as a GitHub secret named `AZURE_CREDENTIALS`
3. Use it in your workflow:

```yaml
env:
  AZURE_CREDENTIALS: ${ { secrets.AZURE_CREDENTIALS } }
```

---

If you'd like, I can also generate:
- A ready-to-use Terraform config
- A working GitHub Actions YAML
- Or even a Bash script that automates this entire process

Just say the word, master 😎








BG VERSION:
---

## 🔐 Команда:

```bash
az ad sp create-for-rbac \
  --name "Stoyan-Terraform-SP-Contributor" \
  --role contributor \
  --scopes /subscriptions/11111111111 \
  --sdk-auth
```

---

## 🧠 Какво прави тази команда:

### 1. `az ad sp create-for-rbac`
Създава **Service Principal (SP)** в Azure Active Directory.
Това е специален вид "потребител", който се използва от:
-Terraform
- Скриптове
- CI / CD инструменти(напр.GitHub Actions)
- Azure SDK - та(за Python, C#, JS и т.н.)

Този SP позволява * *автоматизиран достъп до Azure ресурси * *.

-- -

### 2. `--name "Stoyan-Terraform-SP-Contributor"`
Задава уникално име на Service Principal-а.
Добра практика е името да отразява целта – тук става ясно, че SP ще се ползва от Terraform и ще има роля Contributor.

-- -

### 3. `--role contributor`
Присвоява ролята * *Contributor * *на SP, което му дава:
✅ Пълен достъп за създаване, промяна и изтриване на ресурси  
⛔ Без възможност да променя достъпа на други потребители(т.е.не може да дава роли / RBAC)

-- -

### 4. `--scopes /subscriptions/<subscription-id>`
Ограничава достъпа само до конкретен * *обхват * * – в случая:
-цялата Azure Subscription с ID `11111111111111111111111`  
(Може да се ползва и по - малък обхват – напр.към конкретна Resource Group)

-- -

### 5. `--sdk-auth`
💎 Изключително полезен флаг!  
Връща информацията във **формат, съвместим с Azure SDK, Terraform и CI/CD инструменти**.

Ще получиш JSON като този:

```json
{
  "clientId": "SP-app-id",
  "clientSecret": "SP-password",
  "subscriptionId": "1111111111111111111111",
  "tenantId": "tenant-id",
  "activeDirectoryEndpointUrl": "https://login.microsoftonline.com",
  "resourceManagerEndpointUrl": "https://management.azure.com/",
  ...
}
```

Този JSON можеш директно да:
-използваш като secret в **GitHub Actions**
- импортираш в **Terraform**
- ползваш с **Azure SDK**

---

## 🎯 Какво можеш да правиш с този Service Principal:

| Употреба                | Обяснение                                                                |
|-------------------------|--------------------------------------------------------------------------|
| Terraform Provider      | За автоматизирано създаване и управление на Azure ресурси                |
| GitHub Actions / DevOps | CI/CD deployment-и – сигурно свързване с Azure                           |
| Скриптове и CLI         | Скриптово управление на ресурси през Azure CLI или SDK                   |
| REST API Calls          | Авторизация към Azure REST API                                           |

---

## 🧱 Пример: Terraform provider с този SP

```hcl
provider "azurerm" {
  features = {}

  subscription_id = "111111111111111111111111111"
  client_id = "SP-app-id"
  client_secret = "SP-password"
  tenant_id = "tenant-id"
}
```

---

## 🧪 Пример: GitHub Actions секрет

1.Копираш JSON - а от `--sdk-auth`
2. Създаваш secret в GitHub с име: `AZURE_CREDENTIALS`
3. Използваш го така:

```yaml
env:
  AZURE_CREDENTIALS: ${ { secrets.AZURE_CREDENTIALS } }
```

---