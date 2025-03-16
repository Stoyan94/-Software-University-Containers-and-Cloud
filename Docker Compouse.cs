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