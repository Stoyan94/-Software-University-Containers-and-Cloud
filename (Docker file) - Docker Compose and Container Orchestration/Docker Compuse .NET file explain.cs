﻿Ще разгледаме всяка част от `docker-compose.yml`, ред по ред:  

---

### **1. Заглавие на версията**
```yaml
version: "3.8"
```
-**`version:`** – Декларира версията на Docker Compose, която се използва.  
- **`"3.8"`** – Това е версия 3.8 на Compose файла, съвместима с по-новите версии на Docker.  

---

### **2. Дефиниране на услуги (services)**
```yaml
services:
```
-**`services:`** – Определя, че започва секция с услуги (контейнери). Всяка услуга е отделен контейнер.

---

### **3. Дефиниране на първата услуга – `backend`**
```yaml
  backend:
```
-**`backend:`** – Името на услугата (контейнера), може да бъде произволно.


```yaml
    image: mcr.microsoft.com / dotnet / aspnet:8.0
```
-**`image:`** – Определя образа(image), от който ще се стартира контейнерът.  
- **`mcr.microsoft.com/dotnet/aspnet:8.0`** – Това е официалният образ на .NET Core ASP.NET 8.0, хостван в Microsoft Container Registry (MCR).


```yaml
    ports:
      -"5000:5000"
```
-**`ports:`** – Указва, че ще се пренасочват портове от контейнера към хост машината.  
- **`- "5000:5000"`** – Това означава:  
  -Порт * *5000 * *на локалната машина(хост) ще пренасочва трафик към порт **5000** на контейнера.  
  - Така приложението, което работи вътре в контейнера на порт 5000, ще бъде достъпно през `localhost:5000`.  


```yaml
    depends_on:
      -db
```
-**`depends_on:`** – Задава зависимост между контейнерите.  
- **`- db`** – Казва, че `backend` трябва да изчака `db` контейнера да се стартира първо.  
  - ⚠️ Важно: `depends_on` гарантира само, че `db` контейнерът ще бъде стартиран, но не гарантира, че е готов за заявки.

---

### **4. Дефиниране на втората услуга – `db` (база данни)**
```yaml
  db:
```
-**`db:`** – Името на услугата (контейнера), която ще стартира база данни.


```yaml
    image: mcr.microsoft.com / mssql / server:2022 - latest
```
-**`image:`** – Определя образа, от който ще се стартира контейнерът.  
- **`mcr.microsoft.com/mssql/server:2022 - latest`** – Това е официалният образ на Microsoft SQL Server 2022.


```yaml
    environment:
```
-**`environment:`** – Определя списък с променливи на средата, които ще бъдат зададени за контейнера.


```yaml
      SA_PASSWORD: "MyStrongPassword!"
```
-**`SA_PASSWORD:`** – Задава парола за системния администратор (`SA`) на SQL Server.  
- **`"MyStrongPassword!"`** – Тук се задава паролата (трябва да отговаря на изискванията на SQL Server – минимум 8 знака, с главни, малки букви, цифри и символи).


```yaml
      ACCEPT_EULA: "Y"
```
-**`ACCEPT_EULA:`** – SQL Server изисква да приемеш лицензионното споразумение преди стартиране.  
- **`"Y"`** – Това означава „да“ (приемане на EULA).


```yaml
    ports:
      -"1433:1433"
```
-**`ports:`** – Указва пренасочване на портове.  
- **`- "1433:1433"`** – Това означава:  
  -Порт * *1433 * *на локалната машина(хост) ще бъде свързан с порт **1433** на контейнера, което е стандартният порт за MSSQL.

---

### **Обобщение на цялостната функционалност**  
- **Стартираме два контейнера:**
  - `backend` (ASP.NET Core приложение).  
  - `db` (Microsoft SQL Server 2022).  
- `backend` **изисква** `db`, така че `depends_on` гарантира, че `db` стартира първи.  
- `backend` **е достъпен** на `localhost:5000`.  
- `db` **е достъпен** на `localhost:1433`, като има зададена парола и приета лицензия.  

Този `docker-compose.yml` е удобен за разработка, защото осигурява среда за работа без нужда от ръчно инсталиране на базата и конфигуриране на връзки.