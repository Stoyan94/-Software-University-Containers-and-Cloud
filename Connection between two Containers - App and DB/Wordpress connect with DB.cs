EN Version: 

---

This command creates and starts a new Docker container for a WordPress site.Let’s go through each parameter and explain what it does:

1. `docker run`
This is the main command that starts a new container.If the container doesn’t exist, Docker will pull the image(if needed) and start a new container from it.


2. `-d`
This flag tells Docker to run the container in detached mode. This means the container will run in the background, and it won’t block the terminal.


3. `--name wordpress-website`
This assigns a name to the container – in this case, **wordpress-website**. This name can be used to easily stop, restart, or remove the container.


4. `-e WORDPRESS_DB_HOST=wordpress_db`
This sets an environment variable for the container. Here, we are setting **WORDPRESS_DB_HOST**, which tells WordPress where to find the database. 
The value **wordpress_db** points to the name of another container, which is likely a database, created with Docker and connected in the same Docker network.


5. `-e WORDPRESS_DB_USER=wordpress`
This sets the username that WordPress will use to connect to the database. In this case, the username is **wordpress**.


6. `-e WORDPRESS_DB_PASSWORD=wordpress`
This sets the password for the **wordpress** user when connecting to the database. In this case, the password is **wordpress**.


7. `-e WORDPRESS_DB_NAME=wordpressdb`
This sets the name of the database that WordPress will use. In this case, the database is called **wordpressdb**.


8. `-p 80:80`
This tells Docker to map port 80 of the container to port 80 of the host machine. 
This means the WordPress site will be accessible on port 80 (the standard HTTP port) on the host machine.


9. `--network stoyan_mreja`
This sets the network the container will be connected to. In this case, the network is **stoyan_mreja**. 
This network must already exist in Docker and allows containers to communicate with each other.


### Summary:
This command starts a new Docker container with WordPress, configured to connect to a database in another container via the environment variables. 
    The container will be named **wordpress-website** and will be accessible on port 80. The container will be connected to the Docker network **stoyan_mreja**.

This configuration assumes that you have a database running in a separate container named **wordpress_db**, which is on the same network.

---

Yes, exactly! With this command, you're actually establishing a connection between two Docker containers: one for WordPress and another for the database (likely MySQL or MariaDB).

When you use the `--network stoyan_mreja` flag, you're placing both containers in the same Docker network. This allows the WordPress container to communicate with the container hosting the database using the hostname **wordpress_db** (which is the name of the database container).

This configuration is important because within a Docker network, containers can communicate with each other using the container names(e.g., **wordpress_db * * for the database).This is better than using IP addresses, which can change.

So, when WordPress tries to connect to the database, it uses **wordpress_db** as the host to find the other container and can establish a successful connection, as long as the containers are in the same network.

---

Hope this is clear now! Let me know if you need further assistance.




BG Version:

Тази команда създава и стартира нов Docker контейнер за WordPress сайт. Нека разгледаме всеки от параметрите и какво прави той:

### 1. `docker run`
Това е основната команда, която стартира нов контейнер.
Ако контейнерът не съществува, Docker ще изтегли изображението (ако е необходимо) и ще стартира нов контейнер от него.

### 2. `-d`
Този флаг указва на Docker да стартира контейнера в режим на фоново изпълнение (detached mode).
Това означава, че контейнерът ще работи на заден план, като не блокира терминала.


### 3. `--name wordpress-website`
Това задава име на контейнера – в случая **wordpress-website**.
Това име може да се използва за по-лесно спиране, рестартиране или премахване на контейнера.


### 4. `-e WORDPRESS_DB_HOST=wordpress_db`
Това задава променлива на средата за контейнера.
В този случай задаваме **WORDPRESS_DB_HOST**, който указва на WordPress къде да намери база данни.
Стойността **wordpress_db** сочи към име на друг контейнер, който вероятно е база данни, създадена с Docker и свързана в една и съща Docker мрежа.


### 5. `-e WORDPRESS_DB_USER=wordpress`
Това задава името на потребителя, който WordPress ще използва за свързване с базата данни.
В случая потребителят е **wordpress**.


### 6. `-e WORDPRESS_DB_PASSWORD=wordpress`
Това задава паролата за потребителя **wordpress** при свързване с базата данни.
В случая паролата е **wordpress**.


### 7. `-e WORDPRESS_DB_NAME=wordpressdb`
Това задава името на базата данни, която WordPress ще използва.
В случая базата данни се нарича **wordpressdb**.


### 8. `-p 80:80`
Това указва на Docker да свърже порта **80** на контейнера с порта **80** на хост машината.
Това означава, че WordPress сайтът ще бъде достъпен на порт 80 (стандартният HTTP порт) на хост машината.


### 9. `--network stoyan_mreja`
Това задава мрежата, към която ще бъде свързан контейнерът.
В този случай се използва мрежата **stoyan_mreja**. Тази мрежа трябва да е съществуваща в Docker и позволява на контейнерите да комуникират помежду си.


### Обобщение:
Тази команда стартира нов Docker контейнер с WordPress, който е конфигуриран да се свързва с база данни в друг контейнер чрез зададените променливи на средата. 
Контейнерът ще бъде наименуван "wordpress-website" и ще бъде достъпен на порт 80. Контейнерът ще бъде свързан с Docker мрежата **stoyan_mreja**.


Тази конфигурация предполага, че имате база данни, работеща в отделен контейнер, който се нарича **wordpress_db** и работи в същата мрежа.

 
С тази команда всъщност създаваш връзка между два Docker контейнера: един за **WordPress** и друг за **базата данни** (вероятно MySQL или MariaDB).

Когато използваш флага `--network stoyan_mreja`, поставяш двата контейнера в една и съща Docker мрежа. 
Това позволява на контейнера с WordPress да комуникира с контейнера, който хоства базата данни, чрез името на хоста **wordpress_db** (което е името на контейнера с базата данни). 

Тази конфигурация е важна, защото в Docker мрежата контейнерите могат да комуникират помежду си чрез имената на контейнерите (например `wordpress_db` за база данни). 
Това е по-добре от използването на IP адреси, които могат да се променят.

Така, когато WordPress се опитва да се свърже с базата данни, той използва **wordpress_db** като хост, 
за да намери другия контейнер, и може да осъществи успешна връзка, стига контейнерите да са в една и съща мрежа.