BG Version:

Volumes в Docker – кога, защо и как да ги използваме?

1. Какво са Volumes в Docker?
Volumes в Docker са механизъм за запазване на данни извън жизнения цикъл на контейнера.
Когато контейнерът бъде изтрит, неговата файлова система изчезва.
За да избегнем загуба на данни, използваме volumes.
Volumes са директории или файлове, които се съхраняват в Docker хост системата.

2. Защо да използваме Volumes?
Запазване на данни – ако контейнерът се рестартира, данните остават.
Споделяне на данни между контейнери – няколко контейнера могат да достъпват едни и същи файлове.
Подобрен перформанс – работят по-бързо от bind mounts.
Изолираност – данните се съхраняват в Docker хост системата, но не са директно обвързани с конкретен контейнер.


3. Кога да използваме Volumes?
Когато имаме персистентни данни, като база данни (MySQL, PostgreSQL).
При логове и конфигурационни файлове.
Когато няколко контейнера трябва да достъпват едни и същи данни.
При CI/CD пайплайни – за кеширане на зависимости.


4. Как се използват Volumes в Docker?

4.1. Създаване на volume
docker volume create my_volume
4.2. Стартиране на контейнер с volume
docker run -d --name my_container -v my_volume:/ app / data nginx
Тук my_volume се монтира в /app/data вътре в контейнера.

4.3. Използване на анонимни volumes
Ако не зададем име на volume-а, Docker ще създаде такъв автоматично:
docker run -d --name temp_container -v /app/data nginx

4.4. Използване на bind mounts (алтернатива)
Bind mounts използват директории от хост машината:
docker run -d --name my_container -v /home/user/data:/ app / data nginx
Тук /home/user/data от хоста се свързва с /app/data в контейнера.

4.5. Преглед на съществуващи volumes
docker volume ls

4.6. Изтриване на volume
docker volume rm my_volume

4.7. Изтриване на всички неактивни volumes
docker volume prune


5. Реални примери
Пример 1: MySQL контейнер с volume за персистентност
docker volume create mysql_data
docker run -d --name mysql_container -e MYSQL_ROOT_PASSWORD=root -v mysql_data:/ var / lib / mysql mysql: latest
Данните от MySQL ще се пазят в mysql_data, дори контейнерът да бъде изтрит.


Пример 2: Споделен volume между два контейнера
docker volume create shared_data
docker run -d --name container1 -v shared_data:/ app / data alpine sleep 1000
docker run -d --name container2 -v shared_data:/ app / data alpine sleep 1000
И двата контейнера ще могат да пишат и четат от /app/data.

Пример 3: Използване на Docker Compose с volume
docker-compose.yml

yaml

version: '3.8'
services:
db:
image: postgres
volumes:
      -db_data:/ var / lib / postgresql / data
volumes:
db_data:
Тук db_data ще запази базата данни между рестартирания.

6. Заключение
Docker volumes са мощен начин за управление на данните в контейнери.
Те са незаменими при работа с бази данни, логове и споделяне на файлове между контейнери.
Ключовото предимство е, че данните не се губят при спиране или изтриване на контейнера.

Ако искаш да ги тестваш на практика, пробвай горните примери и виж как работят!






ENG Version:

Docker Volumes – When, Why, and How to Use Them?
1. What Are Volumes in Docker?
Volumes in Docker are a mechanism for storing data outside the container’s lifecycle.
When a container is deleted, its filesystem disappears. To prevent data loss, we use volumes.


2. Why Use Volumes?
Data persistence – Data remains even if the container restarts.
Data sharing between containers – Multiple containers can access the same files.
Better performance – Faster than bind mounts.
Isolation – Data is stored in the Docker host system but is not directly tied to a specific container.


3. When to Use Volumes?
When you need persistent data, such as databases (MySQL, PostgreSQL).
For logs and configuration files.
When multiple containers need access to the same data.
In CI/CD pipelines – for caching dependencies.

4. How to Use Volumes in Docker?
4.1. Creating a Volume
docker volume create my_volume

4.2. Running a Container with a Volume
docker run -d --name my_container -v my_volume:/ app / data nginx
Here, my_volume is mounted to /app/data inside the container.

4.3. Using Anonymous Volumes
If no name is specified, Docker automatically creates a volume:
docker run -d --name temp_container -v /app/data nginx
4.4. Using Bind Mounts (Alternative Method)
Bind mounts use directories from the host machine:

docker run -d --name my_container -v /home/user/data:/ app / data nginx
Here, /home/user/data from the host is linked to /app/data inside the container.

4.5. Listing Existing Volumes
docker volume ls

4.6. Removing a Vol
docker volume rm my_volume

4.7. Removing All Unused Volumes
docker volume prune

5. Real-World Examples
Example 1: MySQL Container with a Persistent Volume
docker volume create mysql_data
docker run -d --name mysql_container -e MYSQL_ROOT_PASSWORD=root -v mysql_data:/ var / lib / mysql mysql: latest
MySQL data will be stored in mysql_data, even if the container is deleted.

Example 2: Shared Volume Between Two Containers
docker volume create shared_data
docker run -d --name container1 -v shared_data:/ app / data alpine sleep 1000
docker run -d --name container2 -v shared_data:/ app / data alpine sleep 1000
Both containers can read and write to /app/data.

Example 3: Using Docker Compose with a Volume
docker-compose.yml

yaml

version: '3.8'
services:
db:
image: postgres
volumes:
      -db_data:/ var / lib / postgresql / data
volumes:
db_data:
Here, db_data ensures that the database persists across container restarts.

6. Conclusion
Docker volumes are a powerful way to manage data in containers.
They are essential for working with databases, logs, and sharing files between containers.
The key advantage is that data is not lost when a container stops or is removed.

If you want to test them in practice, try the examples above and see how they work! 🚀