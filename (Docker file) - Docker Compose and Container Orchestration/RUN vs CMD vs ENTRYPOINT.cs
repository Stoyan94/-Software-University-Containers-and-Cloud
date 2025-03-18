ENG Version:

In Docker, `RUN`, `CMD`, and `ENTRYPOINT` serve different purposes:  

-**RUN * * – Used during the build process to execute commands that modify the image (installing packages, copying files, etc.).  
- **CMD** – Specifies the default command that runs when the container starts (it can be overridden).  
- **ENTRYPOINT** – Defines the main command that always executes, while allowing parameters to be added via CMD or arguments at runtime.  

---

### **Examples and Best Practices**

#### **1. RUN - Installing dependencies (during build)**
```dockerfile
FROM ubuntu:latest
RUN apt-get update && apt-get install -y curl
```
✅ **Best practice**: Used for installing software in the image.  
❌ **Bad practice**: Should not be used for commands that need to run every time the container starts.  

---

#### **2. CMD - Default command**
```dockerfile
FROM node:latest
WORKDIR /app
COPY . .
CMD ["node", "server.js"]
```
✅ **Best practice * *: Allows the command to be overridden when running the container with `docker run` (e.g., `docker run myapp node debug.js`).  
❌ **Bad practice**: If the container should always run a specific command without change, CMD is not the best choice (use ENTRYPOINT instead).  

---

#### **3. ENTRYPOINT - Fixed command**
```dockerfile
FROM python:latest
WORKDIR /app
COPY . .
ENTRYPOINT ["python", "script.py"]
```
✅ **Best practice * *: Suitable when the container should always execute a specific command (e.g., `docker run mypythonapp` will always run `script.py`).  
❌ **Bad practice**: If you want to allow flexibility in specifying commands, ENTRYPOINT limits that.  

---

#### **4. ENTRYPOINT + CMD - Combining them**
```dockerfile
FROM alpine
ENTRYPOINT ["echo"]
CMD["Hello, World!"]
```
✅ **Best practice * *: ENTRYPOINT defines a fixed command (`echo`), while CMD allows modifying its argument (`docker run myapp "Custom Message"` will output "Custom Message").  
❌ **Bad practice**: If you don’t need a fixed command and want more flexibility, just use CMD.  

---

### **Which combination should you use?**
| **Scenario** | **Solution** |
|-------------|------------|
| Installing packages and setup during build | RUN |
| Setting a default command that can be changed | CMD |
| Ensuring a fixed command always runs | ENTRYPOINT |
| A combination of a fixed command with configurable parameters | ENTRYPOINT + CMD |

---

### **My Advice**
- **Always use RUN for the build process**, not for executing programs at runtime.  
- **Use CMD when you want to allow easy customization of behavior**.  
- **Use ENTRYPOINT for containers that must have a strictly defined function**.  
- **Don’t use both ENTRYPOINT and CMD together unless necessary**, as it can create confusion.  

If you're building a container for a microservice or a single-purpose application (e.g., an API), ENTRYPOINT is the better choice. 
If the container needs to be more flexible (e.g., running different Node scripts), CMD is more appropriate.






BG Version:



В Docker `RUN`, `CMD` и `ENTRYPOINT` имат различни роли:  

-**RUN * * – използва се по време на билд процеса, за да изпълни команди, които модифицират образа (инсталиране на пакети, копиране на файлове и т.н.).  
- **CMD** – задава командата по подразбиране, която се изпълнява при стартиране на контейнера (може да бъде презаписана).  
- **ENTRYPOINT** – дефинира неизменната основна команда, като позволява параметри да бъдат добавени чрез CMD или аргументи при стартиране на контейнера.  

---

### Примери и добри практики:

#### **1. RUN - инсталиране на зависимости (по време на билд)**
```dockerfile
FROM ubuntu:latest
RUN apt-get update && apt-get install -y curl
```
✅ **Добра практика**: Използва се за инсталиране на софтуер в образа.  
❌ **Лоша практика**: Не трябва да се използва за команди, които трябва да се изпълняват при всяко стартиране на контейнера.  

---

#### **2. CMD - команда по подразбиране**
```dockerfile
FROM node:latest
WORKDIR /app
COPY . .
CMD ["node", "server.js"]
```
✅ **Добра практика * *: Позволява командата да бъде презаписана при стартиране с `docker run` (напр. `docker run myapp node debug.js`).  
❌ **Лоша практика**: Ако контейнерът трябва да изпълнява конкретна команда и не трябва да бъде заменяна, CMD не е най-добрият избор (по-добре ENTRYPOINT).  

---

#### **3. ENTRYPOINT - фиксирана команда**
```dockerfile
FROM python:latest
WORKDIR /app
COPY . .
ENTRYPOINT ["python", "script.py"]
```
✅ **Добра практика * *: Подходящо, когато контейнерът винаги трябва да изпълнява дадена команда (напр. `docker run mypythonapp` винаги ще стартира `script.py`).  
❌ **Лоша практика**: Ако искаш да даваш възможност за динамично задаване на команди, ENTRYPOINT ограничава това.  

---

#### **4. ENTRYPOINT + CMD - комбиниране**
```dockerfile
FROM alpine
ENTRYPOINT ["echo"]
CMD["Hello, World!"]
```
✅ **Добра практика * *: ENTRYPOINT задава фиксирана команда (`echo`), а CMD позволява аргументът ѝ да бъде променен (`docker run myapp "Custom Message"` ще изведе "Custom Message").  
❌ **Лоша практика**: Ако не искаш фиксирана команда, а по-гъвкаво изпълнение, просто използвай CMD.  

---

### **Коя комбинация да използваш?**
| **Сценарий** | **Решение** |
|-------------|------------|
| Инсталиране на пакети и настройки при билд | RUN |
| Задаване на команда по подразбиране, която може да бъде променена | CMD |
| Фиксирана команда, която винаги се изпълнява | ENTRYPOINT |
| Комбинация от фиксирана команда с опции за параметри | ENTRYPOINT + CMD |

---

### **Моите съвети**
- **RUN винаги трябва да се използва за билд процеса**, а не за изпълнение на програми при стартиране на контейнера.  
- **CMD е за сценарии, в които искаш да дадеш възможност за лесна промяна на поведението**.  
- **ENTRYPOINT е за контейнери, които трябва да имат строго определена функция**.  
- **Не използвай едновременно ENTRYPOINT и CMD, ако не е необходимо**, защото може да доведе до неяснота.  

Ако ще правиш контейнер за микросървис или единствено приложение (например API), ENTRYPOINT е по-добрият избор.
Ако контейнерът е по-гъвкав (напр. изпълнява различни Node скриптове), CMD е по-логичен.