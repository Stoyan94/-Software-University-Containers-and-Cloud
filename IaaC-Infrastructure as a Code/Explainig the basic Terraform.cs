ENG VERSION:

This code is a **Terraform configuration** that uses the **Docker Provider** to automate the creation of Docker resources. 
It allows you to manage **Docker images** and **Docker containers** using **Terraform * *, instead of manually running `docker` commands.  

### **Code Breakdown:**

#### **1. Declaring Required Providers**

```hcl
terraform {
  required_providers {
    docker = {
      source  = "kreuzwerker/docker"
      version = "3.0.2"
    }
  }
}
```

-Defines * *Docker * * as a required** Terraform Provider**.  
- `kreuzwerker/docker` is the official **Docker Provider** for Terraform.  
- The version `3.0.2` is specified to prevent compatibility issues with future updates.  


#### **2. Configuring the Docker Provider**
```hcl
provider "docker" {
}
```
-This block tells Terraform to use the **local Docker installation**.  
- If Docker is running correctly on the host machine, no additional configuration is needed.


#### **3. Declaring the Docker Image Resource**

```hcl
resource "docker_image" "nginx" {
  name         = "nginx:latest"
  keep_locally = true
}
```

-This resource instructs Terraform to **pull the Docker image** `nginx:latest`.  
- `keep_locally = true` means that Terraform **will not remove the local image** when the resource is destroyed (`terraform destroy`).  
- Equivalent to the command:  
  ```bash
  docker pull nginx:latest
  ```


#### **4. Declaring the Docker Container**

```hcl
resource "docker_container" "nginx" {
  name    = "nginx"
  image   = docker_image.nginx.image_id

  ports {
    external = 8080
    internal = 80
  }
}
```

-Creates a Docker container named **nginx**.  
- Uses the previously pulled image (`docker_image.nginx.image_id`).  
- **Port mapping** is performed:  
  -**Host machine(local system):**port `8080`  
  -**Inside the container:**port `80` (Nginx uses this port by default)  
- This is equivalent to the command:  

  ```bash
  docker run --name nginx -p 8080:80 -d nginx:latest
  ```
  which starts the container in detached mode (`-d`).

---

### **What is this code used for?**
- **Automated deployment** of **Nginx** inside a **Docker container**.  
- **Managing Docker resources via Terraform** instead of manual commands.  
- **Declarative configuration**, useful for **CI/CD**, **DevOps**, and **Infrastructure as Code (IaC)**.  

With this setup, you can quickly deploy a web server (Nginx), accessible at `http://localhost:8080`. 🚀









BG VERSION

Този код е **Terraform конфигурация**, която използва **Docker Provider** за автоматизирано създаване на Docker ресурси. 
С нея можеш да управляваш **Docker images** и **Docker containers** чрез **Terraform**, вместо да пишеш ръчно `docker` команди.  

### Разбивка на кода:

#### **1. Деклариране на необходимите провайдъри**

```hcl
terraform {
  required_providers {
    docker = {
      source  = "kreuzwerker/docker"
      version = "3.0.2"
    }
  }
}
```
-Определя * *Docker * *като необходим** Terraform Provider**.  
- `kreuzwerker/docker` е официалният **Docker Provider** за Terraform.  
- Версията `3.0.2` е зададена, за да гарантира, че няма несъвместимости при бъдещи актуализации.  


#### **2. Конфигуриране на Docker Provider**

```hcl
provider "docker" {
}
```
-Този блок казва на Terraform да използва **локалната Docker инсталация**.  
- Ако Docker работи правилно на хост машината, няма нужда от допълнителни конфигурации.  


#### **3. Деклариране на Docker Image ресурс**

```hcl
resource "docker_image" "nginx" {
  name         = "nginx:latest"
  keep_locally = true
}
```
-Този ресурс казва на Terraform да **изтегли Docker образа** `nginx:latest`.  
- `keep_locally = true` означава, че Terraform **няма да премахва локалния образ**, когато ресурсът бъде унищожен (`terraform destroy`).  
- Еквивалентно на командата:  
  ```bash
  docker pull nginx:latest
  ```

#### **4. Деклариране на Docker контейнер**

```hcl
resource "docker_container" "nginx" {
  name    = "nginx"
  image   = docker_image.nginx.image_id

  ports {
    external = 8080
    internal = 80
  }
}
```
-Създава Docker контейнер с име **nginx**.  
- Използва образа, който преди това е изтеглен (`docker_image.nginx.image_id`).  
- Извършва **пренасочване на портове**:  
  -**Хост машина(локалната система):**порт `8080`  
  -**В контейнера: **порт `80` (Nginx по подразбиране използва този порт)  
- Това е еквивалентно на командата:  
  ```bash
  docker run --name nginx -p 8080:80 - d nginx: latest
  ```
  което стартира контейнера на заден фон (`-d`).

---

### **За какво се използва този код?**
- **Автоматизирано деплойване** на **Nginx** в **Docker контейнер**.  
- **Управление на Docker ресурси чрез Terraform** вместо ръчни команди.  
- **Декларативно конфигуриране**, което е удобно за **CI/CD**, **DevOps** и **Infrastructure as Code (IaC)**.  

С този код можеш бързо да разпънеш уеб сървър (Nginx), който ще бъде достъпен на `http://localhost:8080`. 🚀