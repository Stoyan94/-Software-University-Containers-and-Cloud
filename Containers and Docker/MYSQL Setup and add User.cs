ЕN Version:

Here is the full translation of the detailed explanation:

```bash
docker run -d --name wordpress_db -e MYSQL_ROOT_PASSWORD=pass -e MYSQL_DATABASE=wordpressdb -e MYSQL_USER=wordpress -e MYSQL_PASSWORD=wordpress --expose 3306 --expose 33060 --network stoyan_mreja -v %cd%/data:/ var / lib / mysql mysql
```

1. **`docker run`**:
   -This is the main command to start a Docker container. It creates a new container from a given image and starts it.

2. **`-d`**:
   -The `-d` flag starts the container in "detached" mode. This means the container will run in the background and will not display logs in the terminal.

3. **`--name wordpress_db`**:
   -This parameter assigns a name to the container that will be created. In this case, the container will be named `wordpress_db`.

4. **`-e MYSQL_ROOT_PASSWORD=pass`**:
   -The `-e` flag sets an environment variable inside the container. In this case, it sets the root password for MySQL (`MYSQL_ROOT_PASSWORD`) to `pass`.

5. **`-e MYSQL_DATABASE=wordpressdb`**:
   -This environment variable specifies the name of the database that will be created when the container starts. In this case, the database will be named `wordpressdb`.

6. **`-e MYSQL_USER=wordpress`**:
   -This sets the MySQL username. The user will be named `wordpress`.

7. **`-e MYSQL_PASSWORD=wordpress`**:
   -This sets the password for the `wordpress` user. The password will be `wordpress`.

8. **`--expose 3306`**:
   -This option exposes port 3306, which is the standard port used by MySQL for connections.

9. **`--expose 33060`**:
   -This option also exposes port 33060, which is an additional port used by MySQL for other types of connections.

10. **`--network stoyan_mreja`**:
    -This option specifies the network to which the container will be connected. In this case, the container will be part of the network named `stoyan_mreja`.

11. **`-v %cd%/data:/ var / lib / mysql`**:
    -The `-v` option specifies a volume (shared directory) between the host and the container. `%cd%` is a command-line variable referring to the current directory (on the host). 
    The `data` directory in the current directory on the host will be linked to the `/var/lib/mysql` directory in the container. This ensures that the data in the database is persistent.

12. **`mysql`**:
    -This is the name of the Docker image from which the container will be created. In this case, it is the official MySQL image from Docker Hub.

### Summary:
This command creates and starts a MySQL container, which is configured with specific environment variables (user, password, database), exposes two ports (3306 and 33060), connects to a specific Docker network, and uses a host directory for storing data, ensuring that data is preserved even if the container is removed.

---

In the parameter `-e MYSQL_USER=wordpress`, you specify a MySQL database user. This user is not connected to the operating system user but is a MySQL user who has access to the database created inside the container.

### Explanation of `MYSQL_USER`:
- **`MYSQL_USER`**: This is the name of the MySQL user that will be created inside the container. In this case, the user is named `wordpress`.
- This user will have the permissions to connect to MySQL and perform operations on the database you create, or other databases, depending on their privileges.

### How it works:
1. **Database Creation**:
   -In the command you provided, there is also the environment variable `MYSQL_DATABASE=wordpressdb`. 
     This means that when the MySQL container starts, it will create the `wordpressdb` database.

2. **The `wordpress` User**:
   -In the parameter `MYSQL_USER=wordpress`, MySQL will create the `wordpress` user. 
     This user will have access to the `wordpressdb` database because when the user is created, it will automatically be granted permissions to work with it (this happens in MySQL).
   
3. **Password for the User**:
   -The parameter `MYSQL_PASSWORD=wordpress` sets the password for the MySQL user `wordpress`.
     This password will be used for authentication when the user connects to the MySQL server.

### Summary:
- The **`wordpress`** user is a MySQL user created in the MySQL database inside the container, and it will have access to the `wordpressdb` database with the password `wordpress`.
- This user is necessary, for example, when WordPress connects to the MySQL server to read and write to the database.

So in short, **this is not an operating system user, but a MySQL user created for the purpose of interacting with the database connected to WordPress.**




BG Version:


```bash
docker run -d --name wordpress_db -e MYSQL_ROOT_PASSWORD=pass -e MYSQL_DATABASE=wordpressdb -e MYSQL_USER=wordpress -e MYSQL_PASSWORD=wordpress --expose 3306 --expose 33060 --network stoyan_mreja -v %cd%/data:/ var / lib / mysql mysql
```

1. **`docker run`**:
   -Това е основната команда за стартиране на контейнер с Docker. Тя създава нов контейнер от даден образ и го стартира.

2. **`-d`**:
   -Параметърът `-d` стартира контейнера в "демонски" режим (detach mode). 
    Това означава, че контейнерът ще работи във фонов режим и няма да показва логовете в терминала.

3. **`--name wordpress_db`**:
   -Този параметър задава име на контейнера, който ще се създаде. В случая, контейнерът ще бъде наречен `wordpress_db`.

4. **`-e MYSQL_ROOT_PASSWORD=pass`**:
   -Опция `-e` задава променлива на средата (environment variable) в контейнера. В този случай задава парола за root потребителя на MySQL (`MYSQL_ROOT_PASSWORD`) и тя е `pass`.

5. **`-e MYSQL_DATABASE=wordpressdb`**:
   -Тази променлива задава името на базата данни, която ще бъде създадена при стартирането на контейнера. В случая, базата данни ще бъде `wordpressdb`.

6. **`-e MYSQL_USER=wordpress`**:
   -Задава потребителското име за MySQL потребител. Потребителят ще се нарича `wordpress`.

7. **`-e MYSQL_PASSWORD=wordpress`**:
   -Задава парола за потребителя `wordpress`. Паролата ще бъде `wordpress`.

8. **`--expose 3306`**:
   -Тази опция указва, че контейнерът ще "експозира" порт 3306. Това е стандартният порт, който MySQL използва за свързване.

9. **`--expose 33060`**:
   -Тази опция експозира и порт 33060, който е допълнителен порт, използван от MySQL за други типове връзки.

10. **`--network stoyan_mreja`**:
    -Тази опция задава мрежа, към която контейнерът ще бъде свързан. В случая, контейнерът ще бъде част от мрежата с име `stoyan_mreja`.

11. **`-v %cd%/data:/ var / lib / mysql`**:
    -Опцията `-v` указва обем(volume) за споделяне на директория между хоста и контейнера. `%cd%` е променлива в командния ред, която се отнася до текущата директория (в случая на хоста). 
    Директорията `data` в текущата директория на хоста ще бъде свързана с директорията `/var/lib/mysql` в контейнера. Това ще осигури постоянството на данните в базата данни.

12. **`mysql`**:
    -Това е името на Docker образа, от който ще се създаде контейнерът. В този случай това е официалният MySQL образ от Docker Hub.

### Резюме:
Тази команда създава и стартира MySQL контейнер, който е конфигуриран със специфични променливи на средата 
(потребител, парола, база данни), експозира два порта (3306 и 33060), свързва се към специфична 
Docker мрежа и използва директория на хоста за съхранение на данни, което гарантира, че данните ще се запазят дори ако контейнерът бъде премахнат.



В параметъра `-e MYSQL_USER=wordpress` задаваш потребител за базата данни MySQL.
Този потребител не е свързан с потребителя на операционната система, а е MySQL потребител, който има достъп до базата данни, създадена в контейнера.

### Обяснение на `MYSQL_USER`:
- **`MYSQL_USER`**: Това е името на MySQL потребител, който ще бъде създаден в контейнера. В случая е зададено името на потребителя да бъде `wordpress`.
- Този потребител ще има права да се свързва с MySQL и да извършва операции в базата данни, която създаваш, или други бази данни, в зависимост от правата му.

### Как работи:
1. **Създаване на базата данни**:
   -В командата, която показваш, съществува и променлива `MYSQL_DATABASE=wordpressdb`. 
    Това означава, че когато MySQL контейнерът се стартира, той ще създаде базата данни `wordpressdb`.

2. **Потребителят `wordpress`**:
   -В параметъра `MYSQL_USER=wordpress` MySQL ще създаде потребителя `wordpress`. 
    Този потребител ще има достъп до базата данни `wordpressdb`, защото при създаването на потребителя автоматично ще му бъдат дадени права за работа с нея (това се случва в MySQL).
   
3. **Парола за потребителя**:
   -Параметърът `MYSQL_PASSWORD = wordpress` задава паролата за MySQL потребителя `wordpress`.
    Тази парола ще бъде използвана за автентикация на потребителя при свързване към MySQL сървъра.

### Резюме:
- **Потребителят `wordpress`** е MySQL потребител, създаден в базата данни MySQL в контейнера, и ще има достъп до базата данни `wordpressdb` със зададената парола `wordpress`.
- Този потребител е нужен, например, когато WordPress се свързва с MySQL сървъра, за да чете и пише в базата данни.

Така че, в кратко, **това не е потребител на операционната система, а потребител в контекста на MySQL, който е създаден с цел да използва базата данни, свързана с WordPress.**