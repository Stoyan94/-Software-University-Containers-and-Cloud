BG Version:

Общ поглед

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql -d mcr.microsoft.com/mssql/server
Какво прави тази команда?

Стартира контейнер с MS SQL Server (Microsoft SQL Server)

Задава среда за работа с нужните променливи

Отваря порт 1433, за да можем да се свържем със SQL сървъра

Запазва данните в постоянен Docker volume, за да не се губят при рестарт

Използва официалното SQL Server изображение от Microsoft Container Registry


Разбивка на всеки аргумент

1. docker run
Това е основната команда, която стартира нов контейнер.


2. -e ACCEPT_EULA=Y
👉 -e означава "environment variable" (среда на изпълнение).

ACCEPT_EULA=Y казва на SQL сървъра, че приемаме лицензионното споразумение на Microsoft (EULA - End User License Agreement).

Без тази променлива контейнерът няма да се стартира, защото лицензионното споразумение не е прието.

В реална работна среда: Ако деплойваме контейнера автоматично (CI/CD), можем да добавим тази променлива в .env файл или в Kubernetes Secrets.

Пример:

-e ACCEPT_EULA=Y
💡 Ако не я зададем, контейнерът ще изведе грешка и ще спре.



3. -e MSSQL_SA_PASSWORD=yourStrongPassword12#
Задава паролата на sa (System Administrator) акаунта на SQL Server.

sa е супер администраторски акаунт с всички права.

Паролата трябва да отговаря на следните изисквания:

Минимум 8 символа

Поне 1 главна буква

Поне 1 цифра

Поне 1 специален символ (#, !, @ и т.н.)


Пример в работна среда:
Ако автоматизираме деплоя на база данни, паролата обикновено не се задава директно в командата. Вместо това:

Може да се използва секрет в Kubernetes

Или .env файл (който НЕ се комитва в Git)

Пример с .env файл:

MSSQL_SA_PASSWORD=MySecurePassw0rd!

И после командата:
docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=$MSSQL_SA_PASSWORD -p 1433:1433 - d mcr.microsoft.com / mssql / server


4. - p 1433:1433
- p означава "publish", което значи отваряне на портове между хост машината и контейнера.

Формат: хост_порт: контейнер_порт.

💡 В този случай:

1433:1433 означава "пренасочи порт 1433 от контейнера към порт 1433 на хоста".

1433 е стандартният порт за Microsoft SQL Server.

След като контейнерът се стартира, можем да се свържем към SQL Server чрез:

SQL Server Management Studio (SSMS)

sqlcmd (команден ред)

.NET приложение (ConnectionString="Server=localhost,1433;...")

Реален пример:
Ако този контейнер работи на сървър, можем да се свържем отдалечено:

sqlcmd -S <server_ip>,1433 -U sa -P yourStrongPassword12#
⚠ ВАЖНО! Ако ще използваме контейнера в продукция, не е добра практика да оставяме порта 1433 отворен за всички.
Можем да използваме Docker Network вместо това.


5. -v sqldata:/ var / opt / mssql
- v означава "volume" – постоянна памет за контейнера.

sqldata:/ var / opt / mssql казва на Docker:

Създай volume с име sqldata

Запази файловете от /var/opt/mssql в този volume

В /var/opt/mssql SQL Server държи всички данни, лога и конфигурации.

💡 Защо го правим?
Ако не използваме volume, всички данни ще се загубят, когато контейнерът бъде спрян или изтрит.

Реален пример:
Ако искаме да бекъпнем базата, просто копираме файловете от sqldata или стартираме нов контейнер, като използваме същия volume:

docker run --rm -v sqldata:/ backup busybox tar cvf /backup/backup.tar /var/opt/mssql


6. -d
-d означава "detached mode" – контейнерът работи във фонов режим.

Ако го изпуснем, контейнерът ще работи в интерактивен режим и ще виждаме логовете в терминала.

Пример в работна среда:
Ако искаме да следим логовете, можем да използваме:
docker logs -f <container_id>


7. mcr.microsoft.com/mssql/server
Това е Docker образът на Microsoft SQL Server.

mcr.microsoft.com е Microsoft Container Registry (официалният източник на Docker образи на Microsoft).

По подразбиране се тегли последната версия на SQL Server.

💡 По-добра практика: Използвай конкретна версия, за да избегнеш неочаквани промени. 
   Например:

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2022-latest

Заключение
Тази команда стартира Microsoft SQL Server в Docker контейнер, като:
✅ Приема лицензионното споразумение
✅ Задава парола за sa акаунта
✅ Отваря порт 1433 за достъп до базата
✅ Създава volume за запазване на данните
✅ Работи във фонов режим

📌 Как можем да проверим дали SQL Server работи?

docker ps

docker logs <container_id>

sqlcmd -S localhost,1433 -U sa -P yourStrongPassword12#

⚠ Важно за продукция:

Не използвай sa, създай друг потребител

Не оставяй порта 1433 отворен за всички

Използвай Kubernetes Secrets или .env за паролата

Ако искаш, мога да ти покажа как да използваш този контейнер с .NET приложение! 🚀






EN Version:

Here’s a detailed breakdown of your Docker command in English:

Overview

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql -d mcr.microsoft.com/mssql/server
What does this command do?

Starts a container running Microsoft SQL Server

Sets the necessary environment variables for the SQL Server instance

Exposes port 1433, allowing connections to the database

Uses a persistent volume, so database data is not lost when the container stops

Pulls and runs the official Microsoft SQL Server image from Microsoft Container Registry


Breaking down each argument
1. docker run
This is the base command used to start a new container.


2. - e ACCEPT_EULA = Y
👉 -e stands for "environment variable", allowing us to pass configuration values.

ACCEPT_EULA=Y tells SQL Server that we accept the End User License Agreement (EULA).

Without this, the container will not start.

In a real-world scenario, this variable is often included in an .env file or in Kubernetes Secrets when deploying automatically (CI/CD pipelines).

Example:

-e ACCEPT_EULA=Y
💡 If we don’t include this, the container will show an error and stop.



3. -e MSSQL_SA_PASSWORD=yourStrongPassword12#
Defines the password for the sa (System Administrator) account.

The sa account is the superuser with full control over the database.

Password requirements:

At least 8 characters

At least 1 uppercase letter

At least 1 digit

At least 1 special character (#, !, @, etc.)


Real-world best practice:
Instead of passing the password directly in the command, it’s safer to store it in:

Kubernetes Secrets

An .env file (which should NOT be committed to Git)

Example with an .env file:

MSSQL_SA_PASSWORD=MySecurePassw0rd!
Then, run the command:

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=$MSSQL_SA_PASSWORD -p 1433:1433 - d mcr.microsoft.com / mssql / server


4. - p 1433:1433
- p stands for "publish", which exposes a port from the container to the host machine.

Format: host_port: container_port.

💡 In this case:

1433:1433 means "map port 1433 from the container to port 1433 on the host".

1433 is the default port for Microsoft SQL Server.

After starting the container, we can connect to the SQL Server instance using:

SQL Server Management Studio (SSMS)

sqlcmd (command-line tool)

A .NET application (ConnectionString="Server=localhost,1433;...")

Real-world example:
If this container runs on a remote server, we can connect to it like this:

sqlcmd -S<server_ip>,1433 -U sa -P yourStrongPassword12#
⚠ IMPORTANT: Exposing port 1433 to everyone is not safe in a production environment.Instead, use Docker Networks to restrict access.



5. -v sqldata:/var/opt/mssql
-v stands for "volume", which provides persistent storage for the container.

sqldata:/var/opt/mssql tells Docker to:

Create a volume named sqldata

Store all database files in /var/opt/mssql, which is where SQL Server stores its data, logs, and configuration files.

💡 Why is this important?
Without a volume, all data would be lost when the container is stopped or deleted.

Real-world scenario:
If we want to back up the database, we can simply copy the sqldata volume or start a new container using the same volume:

docker run --rm -v sqldata:/ backup busybox tar cvf /backup/backup.tar /var/opt/mssql


6. -d
-d means "detached mode", which runs the container in the background.

If omitted, the container would run in the foreground, displaying logs in the terminal.

Example in real-world use:
To check logs while the container is running:

docker logs -f <container_id>


7. mcr.microsoft.com/mssql/server
This is the Docker image for Microsoft SQL Server.

mcr.microsoft.com is Microsoft Container Registry, the official source for Microsoft Docker images.

By default, the latest version is pulled unless a specific version is specified.

💡 Best practice: Instead of using the latest version, specify a version to avoid unexpected changes:

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2022-latest


Final Summary
This command starts a Microsoft SQL Server container with:
✅ EULA accepted
✅ Password set for the sa user
✅ Port 1433 exposed for external connections
✅ Persistent storage using a Docker volume
✅ Running in detached mode

📌 How to check if SQL Server is running?

docker ps

docker logs <container_id>

sqlcmd -S localhost,1433 -U sa -P yourStrongPassword12#


⚠ Production best practices:

Do NOT use the sa user – create a separate database user instead

Do NOT expose port 1433 publicly – use Docker Networks

Store the password in secrets or environment variables

Would you like me to show you how to use this container with a .NET application? 🚀