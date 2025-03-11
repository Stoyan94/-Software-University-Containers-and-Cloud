ENG Version:

To add a volume to an already existing Docker container, you can't do it directly with a command like docker run. 

Instead, you need to use the following approach:

Create a new container with the same settings as the old one, but with an added volume: 
You can create a new container from the same image and add a volume using the docker run command with the -v parameter.

Example:

docker run -d --name new_container -v c:\ST:/ stoyancontainer < image_name >

Copy data from the old container to the new one: If you have data in the old container, you can copy it to the new container using docker cp or other mechanisms.

Use docker exec to add a volume: To mount a directory into a container that is already running, you can use the docker exec command, 
but keep in mind that this will not create a permanent volume, and it will only create a link to the directory for the current session.

Example:
docker exec -it <container_id_or_name> bash
mount --bind c:\ST / stoyancontainer
This will only apply for the current execution of the container and won't create a permanent volume. 
If you want a permanent link, you need to create a new container with the necessary volume settings.




Volumes in Docker
Volumes in Docker are used to manage data outside of containers.
They allow data to persist even when containers are deleted or recreated, while also providing a way to share data between different containers. 
This is very useful for storing configuration files, databases, log files, and other important data.

Here’s a real-world example:

Example: Using a volume for a database
Imagine you want to run a MySQL container with a database, and you want to store the data in a separate volume so that it’s not lost when the container is removed.

Create a MySQL container with a volume:

You will create a container that uses a volume to store data related to MySQL.

docker run -d \
  --name mysql-container \
  -e MYSQL_ROOT_PASSWORD=rootpassword \
  -v mysql-data:/ var / lib / mysql \
  mysql: latest

Here:

-v mysql - data:/ var / lib / mysql creates a volume named mysql-data, which will be used to store the database in the /var/lib/mysql directory inside the container.
MYSQL_ROOT_PASSWORD=rootpassword sets the root password for MySQL.

What does the volume do?

Data persistence: The volume mysql-data will store all database data, and it will persist even if the container is removed.
Data migration: If you decide to migrate to a new container or MySQL version, you can start a new container and attach the same volume to access the old data.

Create a new container with access to the existing volume:

If you want to create a new container with access to the same volume, you can do it like this:

docker run -d \
  --name new- mysql - container \
  -e MYSQL_ROOT_PASSWORD = newpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql: latest

In this case, the new container will use the same volume and have access to the data from the old container.

Advantages of using volumes:

Data persistence: Data doesn’t get lost when containers are removed.
Easy sharing of data between containers: You can link the same volume to multiple containers.
Easy backup and restore: You can back up data from a volume and restore it to another machine or container.

Example with log files
Another real-world example could be a container that generates log files.
For instance, if you have a container that generates logs for a web server(like Nginx or Apache), 
you can use a volume to store those logs on the host while still keeping them outside the container.


docker run - d \
  --name nginx - container \
  -v / path / to / logs:/ var / log / nginx \
  nginx

Here, the log files will be stored on the host in the / path / to / logs directory, allowing easy access to them and keeping them outside the container.

Conclusion:
Volumes are very useful for storing data that needs to be persistent and accessible outside of containers, such as databases, configuration files, logs, and others.
They allow easy management of data and provide better isolation and compatibility between containers and the host machine.







 BG Version:



За да добавиш volume към вече съществуващ Docker контейнер, не можеш директно да го направиш с команда като docker run.
Вместо това, трябва да използваш следния подход:

Създаване на нов контейнер със същите настройки като стария, но с добавен volume: 
Можеш да създадеш нов контейнер от същия образ и да добавиш volume, използвайки командата docker run с параметър - v.

Например:

docker run - d--name нов_контейнер - v c:\ST:/ stoyancontainer < образ_на_контейнера >
Прекопиране на данни от стария контейнер към новия: Ако имаш данни в стария контейнер, можеш да ги копираш към новия контейнер чрез docker cp или други механизми.

Използване на docker exec за добавяне на volume:
За да монтираш директория в контейнер, който вече работи, можеш да използваш командата docker exec, но имай предвид, 
че това няма да бъде постоянен volume, а само ще създаде връзка с директорията за текущата сесия.

Пример:

docker exec - it < container_id_or_name > bash
mount--bind c:\ST / stoyancontainer
Това е само за текущото изпълнение на контейнера и не създава постоянен volume.
Ако искаш постоянна връзка, трябва да създадеш нов контейнер с необходимите volume настройки.



Volumes в Docker се използват за управление на данни извън контейнерите.
Те позволяват данните да се запазват, дори когато контейнерите се изтриват или пресъздават, като същевременно предоставят средство за споделяне на данни между различни контейнери.
Това е много полезно за съхранение на конфигурационни файлове, бази данни, лог файлове и други важни данни.

Ето един реален пример:

Пример: Използване на volume за база данни
Представи си, че искаш да стартираш MySQL контейнер с база данни и искаш да съхраняваш данните в отделен volume, за да не ги изгубиш, ако контейнерът бъде премахнат.

Създаване на MySQL контейнер с volume:

Ще създадеш контейнер, който използва volume за съхранение на данни, свързани с MySQL.

docker run - d \
  --name mysql - container \
  -e MYSQL_ROOT_PASSWORD = rootpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql:latest

Тук:

-v mysql - data:/ var / lib / mysql създава volume с името mysql - data, който ще се използва за съхранение на базата данни в директорията / var / lib / mysql на контейнера.
MYSQL_ROOT_PASSWORD = rootpassword задава парола за root потребителя на MySQL.

Какво прави volume:

Съхранение на данни: Volume mysql - data ще запази всички данни на базата данни, като те ще се запазят дори ако контейнерът бъде премахнат.
Миграция на данни: Ако решиш да мигрираш към нов контейнер или версия на MySQL, можеш да стартираш нов контейнер и да свържеш същото volume, за да използваш старите данни.

Добавяне на нов контейнер с достъп до съществуващия volume:

Ако искаш да създадеш нов контейнер с достъп до същото volume, можеш да го направиш по следния начин:

docker run - d \
  --name new- mysql - container \
  -e MYSQL_ROOT_PASSWORD = newpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql:latest

В този случай новият контейнер ще използва същото volume и ще има достъп до данните от базата данни на стария контейнер.

Предимства на използването на volumes:

Постоянство на данни: Данните не се губят, когато контейнерите се премахват.
Лесно споделяне на данни между контейнери: Можеш да свържеш едно и също volume към различни контейнери.
Лесно архивиране и възстановяване: Можеш да архивираш данни от volume и да ги възстановиш на друга машина или контейнер.

Пример с лог файлове
Друг реален пример може да бъде контейнер, който генерира лог файлове.
Например, ако имаш контейнер, който генерира логове за уеб сървър(като Nginx или Apache), можеш да използваш volume, 
за да съхраняваш тези логове на хоста, като същевременно да ги запазиш извън контейнера.

docker run - d \
  --name nginx - container \
  -v / path / to / logs:/ var / log / nginx \
  nginx

Тук лог файловете ще се съхраняват на хоста в директорията / path / to / logs, което позволява лесен достъп до тях и запазване извън контейнера.

Заключение:
Volumes са много полезни за запазване на данни, които трябва да бъдат перманентни и достъпни извън контейнерите, 
като бази данни, конфигурационни файлове, логове и други.
Те позволяват лесно управление на данни и осигуряват по - добра изолация и съвместимост между контейнерите и хост машината.