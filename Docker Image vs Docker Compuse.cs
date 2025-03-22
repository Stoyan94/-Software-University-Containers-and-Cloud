EN Version:

📌 **Docker Image vs. Docker Compose**  


Feature	            Docker Image 🖼	                                                                    Docker Compose 📜
What is it?	        A ready-made template (image) containing everything needed to run an application.	A tool (docker-compose.yml) that starts multiple containers together.
How does it work?	You create a container from an image: docker run image_name.	                    You start multiple containers at once: docker - compose up.
Example             mcr.microsoft.com / dotnet / aspnet:8.0(a.NET image).                               A docker - compose.yml file that runs.NET and MSSQL together.
Why use it?         Provides a prebuilt environment for running an application.                         Manages multiple containers at once, defining their dependencies


### 🎯 **Example of a Docker Image**  
If you have a single .NET application, you can start it like this:  

```sh
docker run -p 5000:5000 mcr.microsoft.com / dotnet / aspnet:8.0
```  
✅ This will start a single .NET container, but it lacks a database and connectivity.  

### 🎯 **Example of Docker Compose**  
If you want to run .NET + MSSQL together, you’ll need a `docker-compose.yml` file:  

```yaml
version: "3.8"
services:
backend:
image: mcr.microsoft.com / dotnet / aspnet:8.0
    ports:
-"5000:5000"
    depends_on:
-db
  db:
image: mcr.microsoft.com / mssql / server:2022 - latest
    environment:
SA_PASSWORD: "MyStrongPassword!"
      ACCEPT_EULA: "Y"
    ports:
-"1433:1433"
```  
✅ This starts both the backend and the database simultaneously.  

### 🚀 **Summary**  
- **Docker Image** = A ready-made template for a container.  
- **Docker Compose** = A tool that starts multiple containers and manages their dependencies.  

📌 **Use Docker Image** if you need just one container.  
📌 **Use Docker Compose** if you have multiple containers.




BG Version:


Не са едно и също. Разликата е голяма! 😃  

## 📌 **Docker Image vs. Docker Compose**  

Характеристика	    Docker Image 🖼	                                                            Docker Compose 📜
Какво е?	    Готов шаблон (image), съдържащ всичко необходимо за изпълнение на приложение.	Инструмент (docker-compose.yml), който стартира множество контейнери заедно.
Как работи?	    Създаваш контейнер от образ: docker run image_name.	                            Създаваш няколко контейнера наведнъж: docker - compose up.
Пример          mcr.microsoft.com / dotnet / aspnet:8.0(образ на.NET).                          docker - compose.yml, който стартира .NET и MSSQL заедно.
Защо се ползва?	Съдържа предварително изградена среда за работа с приложението.	                Управлява няколко контейнера наведнъж, като дефинира техните зависимости.

## 🎯 **Пример за Docker Image**
Ако имаш **единично** .NET приложение, можеш да го стартираш така:  

```sh
docker run -p 5000:5000 mcr.microsoft.com / dotnet / aspnet:8.0
```
✅ Това ще стартира един .NET контейнер, но **няма база данни, няма свързаност**.  

---

## 🎯 **Пример за Docker Compose**  
Ако искаш да стартираш **.NET + MSSQL заедно**, ще ти трябва `docker-compose.yml`:  

```yaml
version: "3.8"
services:
backend:
image: mcr.microsoft.com / dotnet / aspnet:8.0
    ports:
-"5000:5000"
    depends_on:
-db
  db:
image: mcr.microsoft.com / mssql / server:2022 - latest
    environment:
SA_PASSWORD: "MyStrongPassword!"
      ACCEPT_EULA: "Y"
    ports:
-"1433:1433"
```
✅ Това стартира **и бекенда, и базата данни едновременно**.  

---

## 🚀 **Обобщение**
- **Docker Image** = готов шаблон за контейнер.  
- **Docker Compose** = инструмент, който стартира **няколко** контейнера и управлява зависимостите между тях.  

Ако ти трябва само един контейнер → **Docker Image**.  
Ако имаш няколко контейнера → **Docker Compose**.  