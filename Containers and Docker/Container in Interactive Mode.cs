ENG Version:

In Docker, interactive mode is used when you want to work with a container in real-time, such as through a terminal or shell with commands.

How to start a container in interactive mode?

docker run -it ubuntu bash
➡️ Explanation:

docker run – starts a new container.
- i(interactive) – allows input from the keyboard.
-t (tty) – creates a terminal interface.
ubuntu – uses the official Ubuntu image.
bash – starts the Bash shell inside the container.


How to enter a running container?
If the container is already running, you can access it using:

docker exec -it <container_id> bash
or
docker attach <container_id>

How to exit a container?

Without stopping it: Press Ctrl + P followed by Ctrl + Q.
Or to stop it completely: Type exit.



    BG Version:



В Docker, интерактивният режим се използва, когато искаш да работиш с контейнер в реално време, например чрез терминал или shell с команда.

Как се стартира контейнер в интерактивен режим?

docker run -it ubuntu bash

➡️ Обяснение:

docker run – стартира нов контейнер.
-i (interactive) – позволява въвеждане от клавиатурата.
-t (tty) – създава терминален интерфейс.
ubuntu – използва официалния образ на Ubuntu.
bash – стартира Bash shell в контейнера.


Как да влезеш в работещ контейнер?
Ако контейнерът вече работи, можеш да влезеш в него с:

docker exec -it <container_id> bash
или
docker attach <container_id>

Как да излезеш от контейнера?
Без да го спираш: натискаш Ctrl + P след това Ctrl + Q.
Или да го спреш напълно: с exit.