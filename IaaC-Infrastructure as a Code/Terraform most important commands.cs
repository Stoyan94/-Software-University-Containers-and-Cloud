ENG VERSION:


These** Terraform** commands are used for managing infrastructure as code (IaC).
Each command performs a specific task in the Terraform workflow.  

---

## **1. `terraform fmt` (Formatting)**
```bash
terraform fmt
```
- **Formats** `.tf` files to match Terraform's official style.  
- Helps improve readability and maintain consistent code formatting.  

📌 *Example:*
If there are misaligned elements or extra spaces in the code, this command will fix them.  

---

## **2. `terraform validate` (Validation)**
```bash
terraform validate
```
- **Checks the syntax** and validity of the configuration files.  
- Does not apply any changes, only verifies if the code is correct.  

📌 *Example:*
If there are syntax errors or missing resources, this command will detect them.  

---

## **3. `terraform plan` (Preview Changes)**
```bash
terraform plan
```
- **Simulates execution** without making real changes.  
- Shows what resources will be created, modified, or destroyed.  
- Helps prevent unexpected changes.  

📌 *Example Output:*
```plaintext
Plan: 1 to add, 0 to change, 0 to destroy.
```
This means Terraform will **create 1 resource**, with no modifications or deletions.  

---

## **4. `terraform apply` (Apply Changes)**
```bash
terraform apply
```
- **Executes the changes** simulated by `terraform plan`.  
- After confirmation, it creates, modifies, or deletes resources as per the configuration.  

📌 *Example:*
When executed, Terraform will ask for confirmation:  
```plaintext
Do you want to perform these actions? (yes/no)
```
If you type **"yes"**, Terraform will create or modify the resources.

---

## **5. `terraform show` (View Current State)**
```bash
terraform show
```
- **Displays the current state** of the infrastructure managed by Terraform.  
- Outputs details of all created resources and their attributes.  

📌 *Example Output:*
```plaintext
# docker_container.nginx:
resource "docker_container" "nginx" {
    id      = "123456abc"
    name    = "nginx"
    image   = "nginx:latest"
    ports {
        external = 8080
        internal = 80
    }
}
```
This means the `nginx` container is running with port `8080:80`.

---

## **6. `terraform destroy` (Destroy Resources)**
```bash
terraform destroy
```
- **Deletes all resources** created by the current configuration.  
- Used when the created resources are no longer needed.  

📌 *Example:*
Terraform will ask for confirmation:  
```plaintext
Do you really want to destroy all resources? (yes/no)
```
If you type **"yes"**, all resources will be deleted.

---

## **🔗 Summary**
| Command              | Description |
|----------------------|-------------|
| `terraform fmt`      | Formats `.tf` files for better readability. |
| `terraform validate` | Checks if the configuration is valid. |
| `terraform plan`     | Simulates execution and previews upcoming changes. |
| `terraform apply`    | Applies the configuration and creates/updates resources. |
| `terraform show`     | Displays the current state of resources. |
| `terraform destroy`  | Destroys all Terraform-managed resources. |

---

**⚡ Example Terraform Workflow:**
1️⃣ `terraform fmt` → Formats the code  
2️⃣ `terraform validate` → Checks for errors  
3️⃣ `terraform plan` → Previews upcoming changes  
4️⃣ `terraform apply` → Applies the configuration  
5️⃣ `terraform show` → Checks the current state  
6️⃣ `terraform destroy` → (If no longer needed) Deletes everything  

This is how to efficiently work with **Terraform**! 🚀





BG VERSION:

Тези** Terraform** команди се използват за управление на инфраструктурата като код (IaC).
Всяка от тях изпълнява различна задача в Terraform работния процес.  

---

## **1. `terraform fmt` (Форматиране)**
```bash
terraform fmt
```
- **Форматира** `.tf` файловете, за да отговарят на официалния Terraform стил.  
- Помага за по-добра четимост и поддържа кодовия стил последователен.  

📌 *Пример:*
Ако в кода има неправилно подравнени елементи или излишни интервали, командата ще ги поправи.  

---

## **2. `terraform validate` (Валидация)**
```bash
terraform validate
```
- **Проверява синтаксиса** и валидността на конфигурационните файлове.  
- Не изпълнява промените, а само тества дали кодът е коректен.  

📌 *Пример:*
Ако има грешки в синтаксиса или липсващи ресурси, командата ще ги открие.  

---

## **3. `terraform plan` (Преглед на промените)**
```bash
terraform plan
```
- **Симулира изпълнението** без да прилага реални промени.  
- Показва какви ресурси ще бъдат създадени, модифицирани или изтрити.  
- Помага да се предотвратят неочаквани промени.  

📌 *Примерен изход:*
```plaintext
Plan: 1 to add, 0 to change, 0 to destroy.
```
Това означава, че Terraform ще създаде **1 ресурс**, няма да модифицира или унищожи съществуващи.

---

## **4. `terraform apply` (Прилагане на промените)**
```bash
terraform apply
```
- **Изпълнява промените**, които са били симулирани с `terraform plan`.  
- След потвърждение, създава, модифицира или изтрива ресурси според конфигурацията.  

📌 *Пример:*
При изпълнение Terraform ще поиска потвърждение:
```plaintext
Do you want to perform these actions? (yes/no)
```
Ако въведеш **"yes"**, Terraform ще създаде или промени ресурсите.

---

## **5. `terraform show` (Преглед на текущото състояние)**
```bash
terraform show
```
- **Показва текущото състояние** на инфраструктурата, управлявана от Terraform.  
- Извежда информация за всички създадени ресурси и техните атрибути.  

📌 *Примерен изход:*  
```plaintext
# docker_container.nginx:
resource "docker_container" "nginx" {
    id      = "123456abc"
    name    = "nginx"
    image   = "nginx:latest"
    ports {
        external = 8080
        internal = 80
    }
}
```
Това означава, че контейнерът `nginx` работи с порт `8080:80`.

---

## **6. `terraform destroy` (Унищожаване на ресурсите)**
```bash
terraform destroy
```
- **Премахва всички ресурси**, създадени от текущата конфигурация.  
- Използва се, когато повече не са нужни създадените ресурси.  

📌 *Пример:*  
Terraform ще поиска потвърждение:
```plaintext
Do you really want to destroy all resources? (yes/no)
```
Ако въведеш **"yes"**, всички ресурси ще бъдат изтрити.

---

## **🔗 Обобщение**
| Команда              | Описание |
|----------------------|----------|
| `terraform fmt`      | Форматира `.tf` файловете за по-добра четимост. |
| `terraform validate` | Проверява дали конфигурацията е валидна. |
| `terraform plan`     | Симулира изпълнението и показва предстоящите промени. |
| `terraform apply`    | Прилага конфигурацията и създава/променя ресурсите. |
| `terraform show`     | Показва текущото състояние на ресурсите. |
| `terraform destroy`  | Унищожава всички Terraform ресурси. |

---

**⚡ Примерен Terraform работен процес:**  
1️⃣ `terraform fmt` → Форматира кода  
2️⃣ `terraform validate` → Проверява за грешки  
3️⃣ `terraform plan` → Преглеждаш предстоящите промени  
4️⃣ `terraform apply` → Прилагаш конфигурацията  
5️⃣ `terraform show` → Проверяваш състоянието  
6️⃣ `terraform destroy` → (Ако вече не ти трябва) изтриваш всичко  

Така се работи ефективно с **Terraform**! 🚀