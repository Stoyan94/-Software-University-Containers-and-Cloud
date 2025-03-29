ENG VERSION:

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql --rm --network task_board -d --name sqlserver mcr.microsoft.com/mssql/server
docker run -d -p 5000:80--rm--name web_app --network task_board stoyan94/taskboard

These two commands start two containers in the same Docker network (`task_board`), 
where the first container is for Microsoft SQL Server, and the second one is for a web application. 
Let's break down what each command does and why they are used together.  

---

## 🔹 **First Command (SQL Server Container)**  
```sh
docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# \
  -p 1433:1433 - v sqldata:/ var / opt / mssql--rm--network task_board \
  -d --name sqlserver mcr.microsoft.com/mssql/server
```

### What does it do?
1. **`docker run`** – Creates and starts a new Docker container.

2. **`-e ACCEPT_EULA = Y`** – Sets an environment variable to accept the Microsoft SQL Server license agreement.

3. **`-e MSSQL_SA_PASSWORD = yourStrongPassword12#`** – Sets the password for the system administrator (`SA`) in SQL Server.
      The password must meet security policies (uppercase, lowercase, number, special character).

4. **`-p 1433:1433`** – Maps ports:
   - `1433` (inside the container) is the standard SQL Server port.
   - `1433` (on the host) allows access to the database externally on the same port.

5. **`-v sqldata:/ var / opt / mssql`** – Uses a Docker volume (`sqldata`) to store data in the `/var/opt/mssql` directory inside the container, ensuring persistence across restarts.

6. **`--rm`** – Automatically removes the container when stopped.

7. **`--network task_board`** – Connects the container to the Docker network `task_board`, enabling communication with other containers in the same network.

8. **`-d`** – Runs the container in "detached" mode (background process).

9. **`--name sqlserver`** – Names the container `sqlserver`.

10. **`mcr.microsoft.com/mssql/server`** – The official Microsoft SQL Server image pulled from Microsoft Container Registry (MCR).

---

## 🔹 **Second Command (Web Application Container)**  
```sh
docker run -d -p 5000:80--rm--name web_app --network task_board stoyan94/taskboard
```
### What does it do?
1. **`docker run`** – Starts a new container.

2. * *`-d`** – Runs the container in the background.

3. **`-p 5000:80`** – Maps ports:
   - `80` (inside the container) is the standard port for web applications.
   - `5000` (on the host) makes the web app accessible at `http://localhost:5000`.

4. * *`--rm`** – Automatically removes the container when stopped.

5. **`--name web_app`** – Names the container `web_app`.

6. **`--network task_board`** – Connects the container to the `task_board` network, allowing communication with `sqlserver`.

7. **`stoyan94/taskboard`** – The Docker image of the web application, hosted on Docker Hub under the account `stoyan94`.

---

## 🔹 **What do the two containers have in common?**  

1. **They are in the same network** – Both containers are connected to `task_board`, meaning `web_app` can reach `sqlserver` by name (`sqlserver` instead of an IP address).

2. **They form a complete solution**:
   - `sqlserver` provides the database.
   - `web_app` is a web application that likely interacts with the database.

3. **No local installation is required** – Instead of manually installing SQL Server and the web application, Docker allows an isolated environment where everything is automated and easily redeployable.

---

## 🔹 **Why are both containers in the same network?**  

1. **To allow direct communication** – The `web_app` container can connect to `sqlserver` using its name (`sqlserver`) instead of an IP address.

2. **Better security** – Containers in the same network can communicate without exposing ports to the outside world.

3. **Flexibility** – If you need to replace the database with another one (e.g., PostgreSQL), you only need to change the image in the first command without modifying the web application code.

---

## 🔹 **How does the web application connect to the database?**  
Inside `web_app`, there is likely a connection string similar to this:  
```
Server = sqlserver; Database = TaskBoard; User Id = sa; Password = yourStrongPassword12#;
```
This means:
-Connect to `sqlserver` (the container name).
- Use the `TaskBoard` database.
- Log in with `sa` and the specified password.

---

## 🔹 **Conclusion**  
These two commands create a fully functional system with a database and a web application running together in an isolated environment.
Using the same network (`task_board`) simplifies communication, while Docker ensures everything can be quickly restarted and redeployed.






BG VERSION:


docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql --rm --network task_board -d --name sqlserver mcr.microsoft.com/mssql/server
docker run -d -p 5000:80--rm--name web_app --network task_board stoyan94/taskboard


Тези две команди стартират два контейнера в една и съща Docker мрежа (`task_board`), 
като първият контейнер е за Microsoft SQL Server, а вторият е за уеб приложение. 
Да разгледаме в детайли какво прави всяка команда и защо те се използват заедно.  

---

## 🔹 **Първа команда (SQL Server контейнер)**  
```sh
docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# \
  -p 1433:1433 - v sqldata:/ var / opt / mssql--rm--network task_board \
  -d --name sqlserver mcr.microsoft.com/mssql/server
```
### Какво прави тя?

1. **`docker run`** – създава и стартира нов Docker контейнер.

2. **`-e ACCEPT_EULA=Y`** – задава променливата на средата за приемане на лицензионните условия на Microsoft SQL Server.

3. **`-e MSSQL_SA_PASSWORD=yourStrongPassword12#`** – задава парола за системния администратор (`SA`) в SQL Server. 
     Паролата трябва да отговаря на политиките за сигурност (главна буква, малка буква, число, специален символ).

4. **`-p 1433:1433`** – пренасочва порта:
   - `1433` (в контейнера) е стандартният порт за SQL Server.
   - `1433` (на хоста) означава, че базата ще бъде достъпна отвън на този порт.

5. **`-v sqldata:/ var / opt / mssql`** – използва Docker volume (`sqldata`), за да съхранява данните в директорията `/var/opt/mssql` в контейнера. 
    Това гарантира, че при рестартиране данните няма да се загубят.

6. **`--rm`** – контейнерът ще бъде автоматично изтрит при спиране.

7. **`--network task_board`** – свързва контейнера към Docker мрежа с име `task_board`, така че другите контейнери в същата мрежа да могат да го достъпват чрез името му (`sqlserver`).

8. **`-d`** – стартира контейнера в "detached" режим (работи във фонов режим).

9. **`--name sqlserver`** – задава име `sqlserver` за контейнера.

10. **`mcr.microsoft.com/mssql/server`** – това е образът (image) на Microsoft SQL Server, който се тегли от Microsoft Container Registry (MCR).

---

## 🔹 **Втора команда (Уеб приложение)**  
```sh
docker run -d -p 5000:80 --rm --name web_app --network task_board stoyan94/taskboard
```
### Какво прави тя?

1. **`docker run`** – стартира нов контейнер.

2. **`-d`** – стартира контейнера във фонов режим.

3. **`-p 5000:80`** – пренасочва портовете:
   - `80` (в контейнера) е стандартният порт за уеб приложения.
   - `5000` (на хоста) означава, че уеб приложението ще бъде достъпно на `http://localhost:5000`.

4. **`--rm`** – контейнерът ще бъде изтрит автоматично при спиране.

5. **`--name web_app`** – задава име `web_app` на контейнера.

6. **`--network task_board`** – свързва контейнера към същата Docker мрежа (`task_board`), което позволява комуникация с `sqlserver`.

7. **`stoyan94/taskboard`** – това е Docker образът на уеб приложението, който е качен в Docker Hub под акаунта `stoyan94`.

---

## 🔹 **Какво е общото между двата контейнера?**  

1. **Работят в една и съща мрежа** – И двата контейнера са свързани към `task_board`, което означава, че `web_app` може да комуникира със `sqlserver` по име (`sqlserver` вместо IP адрес).

2. **Създават цялостно решение**:
   - `sqlserver` предоставя база данни.
   - `web_app` е уеб приложение, което вероятно използва тази база данни.

3. **Не използват локална инсталация** – вместо да инсталираш SQL Server и уеб приложението ръчно, Docker позволява изолирана среда, където всичко е автоматизирано и лесно за повторно разгръщане.

---

## 🔹 **Защо двата контейнера са в една и съща мрежа?**  

1. **За да могат да се виждат директно** – Контейнерът `web_app` може да се свърже към `sqlserver`, използвайки името `sqlserver` вместо IP адрес, което улеснява конфигурацията.

2. **По-добра сигурност** – Контейнерите в една и съща мрежа могат да комуникират без нужда от отваряне на портове към външния свят.

3. **Гъвкавост** – Ако трябва да замениш базата данни с друга (например PostgreSQL), просто сменяш образа в първата команда, без да променяш кода на уеб приложението.

---

## 🔹 **Как уеб приложението ще се свърже към базата данни?**  
В `web_app` вероятно има connection string, който изглежда така:  
```
Server=sqlserver;Database=TaskBoard;User Id=sa;Password=yourStrongPassword12#;
```
Това казва на приложението:
- Свържи се към `sqlserver` (името на контейнера).
- Използвай базата `TaskBoard`.
- Логни се с потребител `sa` и парола `yourStrongPassword12#`.

---

## 🔹 **Заключение**
Тези две команди създават цяла система с база данни и уеб приложение, които работят заедно в изолирана среда. 
Използването на една и съща мрежа (`task_board`) улеснява комуникацията, а Docker гарантира, че всичко може да бъде стартирано отново бързо и лесно.