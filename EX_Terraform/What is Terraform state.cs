ENG VERSION:
---

### ⚙️ **What is Terraform state?**

Terraform **state** is a critical part of managing infrastructure with Terraform because it **keeps track of the resources** that are created and managed through Terraform.
It acts as a database that records all the resources Terraform manages, as well as their current configuration and properties.

### 🧩 **What does Terraform state do?**

The Terraform **state file** contains information about:
-Existing resources
- Changes made to them
- The state of the infrastructure at a given moment

Typically, this file is stored locally on your machine, but when working in teams or with automation, it’s recommended to store it in 
**remote storage**, such as **Azure Blob Storage**, to ensure consistency and synchronization across team members or different automated workflows (workflows).

### 🧩 **What does a Terraform state fail have to do with Azure?**

If the state file is stored locally or in an insecure location, issues can arise, such as:
-**State conflicts * * if two users or processes modify infrastructure simultaneously.
- **State loss** if the file is deleted or corrupted.

In **Azure**, we typically store the Terraform state file in **Azure Blob Storage** to avoid these problems.
When the **state file** is stored in **remote storage**, Terraform can:
-**Support state locking**, which prevents multiple operations from running simultaneously.
- **Ensure synchronization** across team members, ensuring no parallel changes happen on the same resource.

### 🔒 **Why do we need the state file and how do we use it in workflows?**

- **We need it** so Terraform doesn’t perform unnecessary operations on the infrastructure. For example, if Terraform already knows that a resource exists, it won't try to create it again.
- **It’s used to manage changes**: The state file helps record changes to infrastructure and determine only what needs to be applied next.

---

### 🌐 **How and when do we add the state file in Azure?**

When setting up **Azure** as a backend for Terraform, we create an **Azure Storage Account** and **Blob Container** where the state file will be stored. 
This can be set up using Terraform configuration for the** backend**.

#### Example of backend configuration for Azure:
```hcl
terraform {
    backend "azurerm" {
        resource_group_name = "myResourceGroup"
      storage_account_name = "mytfstatestorage"
      container_name = "tfstate"
      key = "terraform.tfstate"
    }
}
```

**What are we doing here?**
- We create a backend resource that tells Terraform where to store the state file.
- **resource_group_name**: The name of the resource group in Azure.
- **storage_account_name**: The name of the Azure Storage Account.
- **container_name**: The name of the container in Azure Blob Storage where the state file will be stored.
- **key**: The name of the state file that will be created or updated.

### 🏗️ **How to add this in a workflow (workflow)?**

When working with **GitHub Actions** or another CI/CD tool, you can add steps that:
1. * *Configure Terraform backend** for Azure.
2. **Run Terraform operations** like `init`, `plan`, and `apply` in the appropriate workflow.

#### Example of a GitHub Actions workflow that includes using Azure as the backend:

```yaml
name: 'Terraform Plan and Apply'

on:
push:
branches:
-main

env:
ARM_CLIENT_ID: ${ { secrets.AZURE_CLIENT_ID } }
ARM_CLIENT_SECRET: ${ { secrets.AZURE_CLIENT_SECRET } }
ARM_SUBSCRIPTION_ID: ${ { secrets.AZURE_SUBSCRIPTION_ID } }
ARM_TENANT_ID: ${ { secrets.AZURE_TENANT_ID } }

jobs:
terraform:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
        uses: actions / checkout@v4

      - name: Login to Azure
        uses: azure / login@v1
        with:
          creds: ${ { secrets.AZURE_CREDENTIALS } }

-name: Setup Terraform
        uses: hashicorp / setup - terraform@v1

      - name: Terraform Init(with Azure Backend)
        run: terraform init

      -name: Terraform Apply
        run: terraform apply -auto-approve
```

### 📅 **When and how do we add it to CI/CD workflows?**

- **When:**Always, when working in teams or using automated workflows (CI / CD), you **must * *store the Terraform state in centralized storage to avoid locking or synchronization issues.
  
- **How:**Simply add the backend configuration in Terraform and set up the appropriate secrets and resources in CI/CD tools (like GitHub Secrets for Azure credentials).

### 📝 **Summary:**

- **Terraform state** is a foundational file that records the current state of the infrastructure.
- When working with **Azure**, using **Azure Blob Storage** as the backend for the state file is key to team collaboration and avoiding conflicts.
- **State fail** occurs when there is no good synchronization between the state of resources, and **remote state** resolves this issue by ensuring consistency.
- In **workflows**, we add the backend configuration and use automated steps like `terraform init` to prepare the workflow.






BG VERSION:




Terraform** state** е критична част от управлението на инфраструктурата с Terraform, защото той **поддържа състоянието на ресурсите**, които са създадени и управлявани чрез Terraform. 
Той действа като база данни, в която се записват всички ресурси, които Terraform управлява, както и тяхната текуща конфигурация и свойства.

### ⚙️ **Какво е Terraform state?**

Terraform **state файлът** съдържа информация за:
-Съществуващите ресурси
- Промените, които са направени върху тях
- Състоянието на инфраструктурата в даден момент

Обикновено този файл се съхранява локално на вашата машина, но при работа в екип или с автоматизация е препоръчително да го съхранявате в 
**удалечено хранилище**, като **Azure Blob Storage**, за да се осигури консистентност и синхронизация между различни членове на екипа или между различни автоматизирани работни потоци (workflows).

### 🧩 **Какво общо има Terraform state fail с Azure?**

Ако state файлът се съхранява локално или на несигурно място, е възможно да се появят проблеми, като:
-**Конфликти на състоянието**, ако два потребителя или два процеса променят инфраструктурата едновременно.
- **Загуба на състояние**, ако файлът бъде изтрит или повреден.

В **Azure**, обикновено съхраняваме Terraform state файла в **Azure Blob Storage**, за да избегнем тези проблеми. 
Когато state файлът е съхранен в **удалечено хранилище**, Terraform може да:

-**Поддържа заключване на състоянието** (state locking), което предотвратява едновременно изпълнение на операции.
- **Поддържа синхронизация** между различни членове на екипа, като така се гарантира, че няма да се случват паралелни промени върху същия ресурс.


### 🔒 **Защо трябва да имаме state файл и как го използваме в workflows?**

- **Трябва да го имаме**, за да не се изпълняват излишни операции върху инфраструктурата. 
    Например, ако Terraform вече знае, че даден ресурс съществува, той няма да го създаде отново.
- **Използва се за управление на промените**: 
    State файлът помага да се запишат промените върху инфраструктурата и да се определят само тези, които трябва да се приложат в бъдеще.

---

### 🌐 **Как и кога добавяме state файл в Azure?**

Когато настройваме **Azure** като back-end за Terraform, създаваме **Storage Account** и **Blob Container** в Azure, в които ще се съхранява state файлът. 
Това може да се настрои чрез Terraform конфигурация за **backend**.

#### Пример за конфигурация на backend за Azure:
```hcl
terraform {
  backend "azurerm" {
    resource_group_name   = "myResourceGroup"
    storage_account_name  = "mytfstatestorage"
    container_name        = "tfstate"
    key                    = "terraform.tfstate"
  }
}
```

**Какво правим тук?**
- Създаваме backend ресурс, който указва на Terraform къде да съхранява state файла.
- **resource_group_name**: Името на ресурсната група в Azure.
- **storage_account_name**: Името на Azure Storage Account.
- **container_name**: Името на контейнера в Azure Blob Storage, където ще се съхранява state файлът.
- **key**: Името на файла за състоянието, който ще бъде създаден или актуализиран.

### 🏗️ **Как да добавим това в работен процес (workflow)?**

Когато работиш с **GitHub Actions** или друг CI/CD инструмент, можеш да добавиш стъпки, които:
1. * *Конфигурират Terraform backend** за Azure.
2. **Провеждат Terraform операции** като `init`, `plan` и `apply` в съответния workflow.

#### Пример на GitHub Actions workflow, който включва използване на Azure като backend:

```yaml
name: 'Terraform Plan and Apply'

on:
push:
branches:
-main

env:
ARM_CLIENT_ID: ${ { secrets.AZURE_CLIENT_ID } }
ARM_CLIENT_SECRET: ${ { secrets.AZURE_CLIENT_SECRET } }
ARM_SUBSCRIPTION_ID: ${ { secrets.AZURE_SUBSCRIPTION_ID } }
ARM_TENANT_ID: ${ { secrets.AZURE_TENANT_ID } }

jobs:
terraform:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
        uses: actions / checkout@v4

      - name: Login to Azure
        uses: azure / login@v1
        with:
          creds: ${ { secrets.AZURE_CREDENTIALS } }

-name: Setup Terraform
        uses: hashicorp / setup - terraform@v1

      - name: Terraform Init(with Azure Backend)
        run: terraform init

      -name: Terraform Apply
        run: terraform apply -auto-approve
```

### 📅 **Кога и как да го добавим в CI/CD workflows?**

- **Кога:**Винаги, когато работите в екип или използвате автоматизирани работни потоци (CI/CD), 
    **задължително** трябва да съхранявате Terraform state в централизирано хранилище, за да се избегнат проблеми с блокиране или синхронизация.
  
- **Как:**Просто добавете конфигурацията на backend в Terraform и настройте съответните секрети и ресурси в CI/CD инструментите (като GitHub Secrets за Azure креденциали).

### 📝 **Обобщение:**

- **Terraform state** е основополагащ файл, който записва текущото състояние на инфраструктурата.
- Когато работите в **Azure**, използването на **Azure Blob Storage** като backend за съхранение на state файла е ключово за съвместна работа и предотвратяване на конфликти.
- **State fail** се получава, когато няма добра синхронизация между състоянието на ресурсите, а **remote state** решава този проблем, като гарантира консистентност.
- В **workflows** добавяме backend конфигурацията и използваме автоматизирани стъпки като `terraform init`, за да подготвим работния процес.