BG Version:

docker run -p 27017:27017 -v %cd%:/data/db -d -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=558955 mongo
Тази команда стартира MongoDB контейнер в Docker и прави няколко важни настройки.

Разбивка на командата по части
1. docker run

docker run
Това е основната команда за стартиране на нов Docker контейнер от образ (image).

2. -p 27017:27017

-p 27017:27017
Този флаг задава пренасочване на портове между контейнера и твоята машина:

27017(първото число) → порта на твоя компютър (localhost)

27017 (второто число) → порта вътре в контейнера, където MongoDB слуша заявки

👉 Това означава, че можеш да достъпиш MongoDB на localhost:27017 от твоята машина.


3. -v %cd%:/data/db (Много важно! Свързване на директории)

-v %cd%:/ data / db
Това е volume mapping, което означава, че свързваме директорията от твоя компютър към вътрешната директория в контейнера.

%cd% (в cmd) или $(pwd) (в PowerShell) → текущата директория на твоя компютър

/data/db → пътя вътре в контейнера, където MongoDB съхранява базите данни

❓ Защо /data/db?
По подразбиране MongoDB винаги записва своите данни в /data/db вътре в контейнера. Ако не направиш volume mapping, данните ще се изгубят при спиране на контейнера!

👉 Свързването гарантира, че дори след спиране на контейнера, данните ще останат запазени на твоя компютър.


4. -d (Detached Mode)

-d
Този флаг казва на Docker да стартира контейнера във фонов режим (detached mode).
👉 Без -d, ще виждаш логовете на MongoDB в терминала, което може да бъде неудобно.


5. -e MONGO_INITDB_ROOT_USERNAME=mongoadmin

-e MONGO_INITDB_ROOT_USERNAME=mongoadmin
Този флаг задава environment variable (променлива на средата), която казва на MongoDB да създаде администраторски потребител с име mongoadmin.

👉 Това е нужно, защото по подразбиране MongoDB в Docker няма зададена автентикация.


6. -e MONGO_INITDB_ROOT_PASSWORD=558955

-e MONGO_INITDB_ROOT_PASSWORD=558955
Задава паролата за администратора (mongoadmin).

👉 След като контейнерът стартира, ако искаш да се логнеш в MongoDB, ще трябва да използваш тези креденшъли.


7. mongo

Това е името на Docker образа, от който се създава контейнерът.

👉 Ако Docker не го намира локално, автоматично ще го изтегли от Docker Hub.

Какво се случва, когато изпълниш тази команда?
Docker проверява дали имаш mongo образа локално. Ако не – го изтегля.

Стартира нов контейнер с MongoDB.

Пренасочва порт 27017 (за да можеш да се свържеш от твоята машина).

Създава администраторския потребител mongoadmin с дадената парола.

Свързва текущата ти директория с /data/db в контейнера (така че базата да не се губи при рестарт).

Стартира контейнера във фонов режим (-d), без да показва логове в терминала.






ENG Version:




Full Explanation of the Command

docker run -p 27017:27017 - v % cd %:/ data / db - d - e MONGO_INITDB_ROOT_USERNAME = mongoadmin - e MONGO_INITDB_ROOT_PASSWORD = 558955 mongo
This command starts a MongoDB container in Docker and applies several important configurations.

Breaking Down the Command
1. docker run

docker run
This is the main command used to start a new Docker container from an image.

2. - p 27017:27017

-p 27017:27017
This flag maps the ports between your computer and the container:

27017(first number) → The port on your local machine (localhost)

27017 (second number) → The port inside the container, where MongoDB listens for requests

👉 This means you can access MongoDB at localhost:27017 from your machine.


3. - v % cd %:/ data / db(Important! Directory Mapping)
sh
Copy
Edit
-v %cd%:/ data / db
This is volume mapping, which links a directory on your computer to a directory inside the container.

%cd% (in cmd) or $(pwd) (in PowerShell) → The current directory on your computer

/data/db → The directory inside the container, where MongoDB stores its database files

❓ Why /data/db?
By default, MongoDB always stores its data in /data/db inside the container.
If you don’t use volume mapping, all data will be lost when the container stops!

👉 Mapping ensures that the data remains on your computer, even after the container is stopped or deleted.


4. -d (Detached Mode)

-d
This flag tells Docker to run the container in the background (detached mode).

👉 Without -d, you will see MongoDB logs in the terminal, which can be inconvenient.


5. -e MONGO_INITDB_ROOT_USERNAME=mongoadmin

-e MONGO_INITDB_ROOT_USERNAME=mongoadmin
This flag sets an environment variable, instructing MongoDB to create an admin user with the username mongoadmin.

👉 This is required because, by default, MongoDB in Docker does not have authentication enabled.


6. -e MONGO_INITDB_ROOT_PASSWORD=558955

-e MONGO_INITDB_ROOT_PASSWORD=558955
Sets the password for the admin user (mongoadmin).

👉 After the container starts, you will need this username and password to log into MongoDB.


7. mongo

This is the name of the Docker image that will be used to create the container.

👉 If Docker does not find this image locally, it will automatically download it from Docker Hub.

What Happens When You Run This Command?
Docker checks if the mongo image exists locally. If not, it downloads it.

It starts a new MongoDB container.

It maps port 27017, allowing connections from your local machine.

It creates an admin user (mongoadmin) with the specified password.

It links your local directory to /data/db inside the container to persist database files.

It runs the container in the background (-d), without showing logs in the terminal.


How to Check If MongoDB is Running?
1. Check Running Containers

docker ps
If MongoDB is running, you will see the container in the list.


2. Access the MongoDB Shell
If you want to log into MongoDB inside the container:

docker exec -it <container_id> mongosh -u mongoadmin -p 558955 --authenticationDatabase admin
Note: Replace<container_id> with the actual container ID from docker ps.

3. Stop and Remove the Container
To stop the container:

docker stop <container_id>
To delete the container:


docker rm <container_id>
Additional Tips
🛠 If You Are Using PowerShell Instead of cmd
Replace %cd% with $(pwd):


docker run -p 27017:27017 - v "$(pwd):/data/db" - d - e MONGO_INITDB_ROOT_USERNAME = mongoadmin - e MONGO_INITDB_ROOT_PASSWORD = 558955 mongo
📌 Assigning a Name to the Container
To make managing the container easier, give it a name (--name):


docker run --name mongodb-container -p 27017:27017 - v % cd %:/ data / db - d - e MONGO_INITDB_ROOT_USERNAME = mongoadmin - e MONGO_INITDB_ROOT_PASSWORD = 558955 mongo
👉 Then, you can stop it with docker stop mongodb-container and restart it with docker start mongodb-container.

Conclusion
MongoDB stores its data in /data/db inside the container.

Volume mapping (-v %cd%:/ data / db) ensures data is saved on your computer.

Port 27017 is the default MongoDB port.

The admin user is created using -e MONGO_INITDB_ROOT_USERNAME and -e MONGO_INITDB_ROOT_PASSWORD.

The -d flag runs the container in the background.

💡 Now you fully understand how to run MongoDB in Docker as a junior dev! 🚀