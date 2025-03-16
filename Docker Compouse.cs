BG Version:

Какво е Docker Compose?
Docker Compose е инструмент за дефиниране и управление на многоконтейнерни Docker приложения.
Той позволява да се описват и стартират множество свързани контейнери чрез един YAML файл (docker-compose.yml).
Вместо да стартираш ръчно всеки контейнер с docker run, с Compose можеш да зададеш всичко необходимо и да го управляваш централизирано.

За какво се използва Docker Compose?
Лесно управление на многоконтейнерни приложения

Например, ако имаш уеб приложение с база данни, можеш да дефинираш уеб сървъра и базата в един файл и да ги стартираш заедно.

Автоматизиране на настройките на мрежа и зависимости

Не е нужно ръчно да конфигурираш мрежата между контейнерите – Compose автоматично създава мостова мрежа.

Среда за разработка

Позволява ти бързо да стартираш приложение с всички негови зависимости, без да инсталираш нищо освен Docker.

Лесно разгръщане в различни среди

Можеш да използваш същия docker-compose.yml файл както на локалния си компютър, така и на сървъра.

Примерен docker-compose.yml файл
Да кажем, че искаш да стартираш уеб приложение с база данни PostgreSQL.


version: "3.8"

services:
web:
image: nginx
ports:
      -"8080:80"
    depends_on:
-db

  db:
image: postgres
restart: always
environment:
      POSTGRES_USER: user
      POSTGRES_PASSWORD: password
      POSTGRES_DB: mydatabase
Обяснение:
services – определя контейнерите.

web – уеб сървър (Nginx), който ще работи на порт 8080.

db – PostgreSQL база, която се рестартира автоматично при срив.

depends_on – казва, че web зависи от db, но НЕ гарантира, че db е напълно готов.

Полезни команди за работа с Docker Compose
Команда	Описание
docker compose up	Стартира контейнерите (ако не съществуват, ги създава).
docker compose up -d	Стартира контейнерите в бекграунд (detach mode).
docker compose down	Спира и премахва контейнерите, мрежите и обемите.
docker compose ps	Показва активните контейнери.
docker compose logs	Показва логовете на всички услуги.
docker compose logs -f	Следи логовете в реално време.
docker compose exec web sh	Влиза в работещ контейнер (тук web).
docker compose build	Преизгражда изображенията, ако използваш build:.
docker compose restart	Рестартира всички услуги.
Сравнение с docker run

Без docker-compose.yml, трябва ръчно да стартираш всеки контейнер:

docker network create mynetwork
docker run -d --name db --network mynetwork -e POSTGRES_USER=user -e POSTGRES_PASSWORD=password -e POSTGRES_DB=mydatabase postgres
docker run -d --name web --network mynetwork -p 8080:80 nginx

С docker-compose.yml всичко става с една команда:

docker compose up -d
Docker Compose и .env файлове

Можеш да използваш .env файл, за да пазиш чувствителни данни:

.env файл:

POSTGRES_USER=user
POSTGRES_PASSWORD=password
POSTGRES_DB=mydatabase
docker-compose.yml с променливи:


services:
  db:
image: postgres
restart: always
environment:
      POSTGRES_USER: ${ POSTGRES_USER}
POSTGRES_PASSWORD: ${ POSTGRES_PASSWORD}
POSTGRES_DB: ${ POSTGRES_DB}


Заключение
Docker Compose е мощен инструмент за управление на многоконтейнерни приложения.
С него можеш бързо да стартираш, спираш и конфигурираш свързани услуги, без да пишеш дълги docker run команди.

Ако имаш въпроси или искаш конкретен пример с .NET, питай! 🚀








EN Version:




What is Docker Compose ?
Docker Compose is a tool for defining and managing multi - container Docker applications.
It allows you to describe and start multiple connected containers using a single YAML file(docker-compose.yml).
Instead of manually starting each container with docker run, Compose lets you define everything you need and manage it centrally.

What is Docker Compose used for?
Easier management of multi-container applications

For example, if you have a web application with a database, you can define both in one file and start them together.

Automates network and dependency setup

No need to manually configure the network between containers—Compose automatically creates a bridge network.

Development environment setup

Quickly start an application with all its dependencies without installing anything except Docker.

Easy deployment across environments

You can use the same docker-compose.yml file both locally and on a server.

Example docker-compose.yml file
Let’s say you want to start a web application with a PostgreSQL database.


version: "3.8"

services:
web:
image: nginx
ports:
      -"8080:80"
    depends_on:
-db

  db:
image: postgres
restart: always
environment:
      POSTGRES_USER: user
      POSTGRES_PASSWORD: password
      POSTGRES_DB: mydatabase

Explanation:
services – defines the containers.

web – a web server (Nginx) running on port 8080.

db – a PostgreSQL database that restarts automatically on failure.

depends_on – declares that web depends on db, but does not guarantee that db is fully ready.

Useful Docker Compose Commands
Command	Description
docker compose up	Starts the containers (creates them if they don’t exist).
docker compose up -d	Starts the containers in the background (detach mode).
docker compose down	Stops and removes containers, networks, and volumes.
docker compose ps	Shows running containers.
docker compose logs	Displays logs for all services.
docker compose logs -f	Follows logs in real time.
docker compose exec web sh	Enters a running container (in this case, web).
docker compose build	Rebuilds images if using build:.
docker compose restart	Restarts all services.
Comparison with docker run

Without docker-compose.yml, you would have to manually start each container:


docker network create mynetwork
docker run -d --name db --network mynetwork -e POSTGRES_USER=user -e POSTGRES_PASSWORD=password -e POSTGRES_DB=mydatabase postgres
docker run -d --name web --network mynetwork -p 8080:80 nginx
With docker-compose.yml, everything is done with a single command:


docker compose up -d
Docker Compose and .env Files

You can use an .env file to store sensitive data:

.env file:

POSTGRES_USER=user
POSTGRES_PASSWORD=password
POSTGRES_DB=mydatabase
docker-compose.yml with variables:

yaml
Copy
Edit
services:
  db:
image: postgres
restart: always
environment:
      POSTGRES_USER: ${ POSTGRES_USER}
POSTGRES_PASSWORD: ${ POSTGRES_PASSWORD}
POSTGRES_DB: ${ POSTGRES_DB}

Conclusion
Docker Compose is a powerful tool for managing multi-container applications.
It allows you to quickly start, stop, and configure interconnected services without writing long docker run commands.

If you have any questions or need a specific example with .NET, let me know! 🚀