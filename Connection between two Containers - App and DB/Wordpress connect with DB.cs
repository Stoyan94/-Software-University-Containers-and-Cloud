EN Version: 

---

This command creates and starts a new Docker container for a WordPress site.Let�s go through each parameter and explain what it does:

1. `docker run`
This is the main command that starts a new container.If the container doesn�t exist, Docker will pull the image(if needed) and start a new container from it.


2. `-d`
This flag tells Docker to run the container in detached mode. This means the container will run in the background, and it won�t block the terminal.


3. `--name wordpress-website`
This assigns a name to the container � in this case, **wordpress-website**. This name can be used to easily stop, restart, or remove the container.


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

���� ������� ������� � �������� ��� Docker ��������� �� WordPress ����. ���� ���������� ����� �� ����������� � ����� ����� ���:

### 1. `docker run`
���� � ��������� �������, ����� �������� ��� ���������.
��� ����������� �� ����������, Docker �� ������� ������������� (��� � ����������) � �� �������� ��� ��������� �� ����.

### 2. `-d`
���� ���� ������ �� Docker �� �������� ���������� � ����� �� ������ ���������� (detached mode).
���� ��������, �� ����������� �� ������ �� ����� ����, ���� �� ������� ���������.


### 3. `--name wordpress-website`
���� ������ ��� �� ���������� � � ������ **wordpress-website**.
���� ��� ���� �� �� �������� �� ��-����� �������, ������������ ��� ���������� �� ����������.


### 4. `-e WORDPRESS_DB_HOST=wordpress_db`
���� ������ ���������� �� ������� �� ����������.
� ���� ������ �������� **WORDPRESS_DB_HOST**, ����� ������ �� WordPress ���� �� ������ ���� �����.
���������� **wordpress_db** ���� ��� ��� �� ���� ���������, ����� �������� � ���� �����, ��������� � Docker � �������� � ���� � ���� Docker �����.


### 5. `-e WORDPRESS_DB_USER=wordpress`
���� ������ ����� �� �����������, ����� WordPress �� �������� �� ��������� � ������ �����.
� ������ ������������ � **wordpress**.


### 6. `-e WORDPRESS_DB_PASSWORD=wordpress`
���� ������ �������� �� ����������� **wordpress** ��� ��������� � ������ �����.
� ������ �������� � **wordpress**.


### 7. `-e WORDPRESS_DB_NAME=wordpressdb`
���� ������ ����� �� ������ �����, ����� WordPress �� ��������.
� ������ ������ ����� �� ������ **wordpressdb**.


### 8. `-p 80:80`
���� ������ �� Docker �� ������ ����� **80** �� ���������� � ����� **80** �� ���� ��������.
���� ��������, �� WordPress ������ �� ���� �������� �� ���� 80 (������������ HTTP ����) �� ���� ��������.


### 9. `--network stoyan_mreja`
���� ������ �������, ��� ����� �� ���� ������� �����������.
� ���� ������ �� �������� ������� **stoyan_mreja**. ���� ����� ������ �� � ������������ � Docker � ��������� �� ������������ �� ����������� ������� ��.


### ���������:
���� ������� �������� ��� Docker ��������� � WordPress, ����� � ������������ �� �� ������� � ���� ����� � ���� ��������� ���� ���������� ���������� �� �������. 
����������� �� ���� ���������� "wordpress-website" � �� ���� �������� �� ���� 80. ����������� �� ���� ������� � Docker ������� **stoyan_mreja**.


���� ������������ ����������, �� ����� ���� �����, �������� � ������� ���������, ����� �� ������ **wordpress_db** � ������ � ������ �����.

 
� ���� ������� �������� �������� ������ ����� ��� Docker ����������: ���� �� **WordPress** � ���� �� **������ �����** (�������� MySQL ��� MariaDB).

������ ��������� ����� `--network stoyan_mreja`, �������� ����� ���������� � ���� � ���� Docker �����. 
���� ��������� �� ���������� � WordPress �� ���������� � ����������, ����� ������ ������ �����, ���� ����� �� ����� **wordpress_db** (����� � ����� �� ���������� � ������ �����). 

���� ������������ � �����, ������ � Docker ������� ������������ ����� �� ����������� ������� �� ���� ������� �� ������������ (�������� `wordpress_db` �� ���� �����). 
���� � ��-����� �� ������������ �� IP ������, ����� ����� �� �� ��������.

����, ������ WordPress �� ������ �� �� ������ � ������ �����, ��� �������� **wordpress_db** ���� ����, 
�� �� ������ ������ ���������, � ���� �� ��������� ������� ������, ����� ������������ �� �� � ���� � ���� �����.