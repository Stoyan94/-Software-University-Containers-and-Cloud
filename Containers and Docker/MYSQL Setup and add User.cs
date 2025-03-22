�N Version:

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
   -���� � ��������� ������� �� ���������� �� ��������� � Docker. �� ������� ��� ��������� �� ����� ����� � �� ��������.

2. **`-d`**:
   -����������� `-d` �������� ���������� � "��������" ����� (detach mode). 
    ���� ��������, �� ����������� �� ������ ��� ����� ����� � ���� �� ������� �������� � ���������.

3. **`--name wordpress_db`**:
   -���� ��������� ������ ��� �� ����������, ����� �� �� �������. � ������, ����������� �� ���� ������� `wordpress_db`.

4. **`-e MYSQL_ROOT_PASSWORD=pass`**:
   -����� `-e` ������ ���������� �� ������� (environment variable) � ����������. � ���� ������ ������ ������ �� root ����������� �� MySQL (`MYSQL_ROOT_PASSWORD`) � �� � `pass`.

5. **`-e MYSQL_DATABASE=wordpressdb`**:
   -���� ���������� ������ ����� �� ������ �����, ����� �� ���� ��������� ��� ������������ �� ����������. � ������, ������ ����� �� ���� `wordpressdb`.

6. **`-e MYSQL_USER=wordpress`**:
   -������ ��������������� ��� �� MySQL ����������. ������������ �� �� ������ `wordpress`.

7. **`-e MYSQL_PASSWORD=wordpress`**:
   -������ ������ �� ����������� `wordpress`. �������� �� ���� `wordpress`.

8. **`--expose 3306`**:
   -���� ����� ������, �� ����������� �� "���������" ���� 3306. ���� � ������������ ����, ����� MySQL �������� �� ���������.

9. **`--expose 33060`**:
   -���� ����� ��������� � ���� 33060, ����� � ������������ ����, ��������� �� MySQL �� ����� ������ ������.

10. **`--network stoyan_mreja`**:
    -���� ����� ������ �����, ��� ����� ����������� �� ���� �������. � ������, ����������� �� ���� ���� �� ������� � ��� `stoyan_mreja`.

11. **`-v %cd%/data:/ var / lib / mysql`**:
    -������� `-v` ������ ����(volume) �� ��������� �� ���������� ����� ����� � ����������. `%cd%` � ���������� � ��������� ���, ����� �� ������ �� �������� ���������� (� ������ �� �����). 
    ������������ `data` � �������� ���������� �� ����� �� ���� �������� � ������������ `/var/lib/mysql` � ����������. ���� �� ������� ������������� �� ������� � ������ �����.

12. **`mysql`**:
    -���� � ����� �� Docker ������, �� ����� �� �� ������� �����������. � ���� ������ ���� � ����������� MySQL ����� �� Docker Hub.

### ������:
���� ������� ������� � �������� MySQL ���������, ����� � ������������ ��� ���������� ���������� �� ������� 
(����������, ������, ���� �����), ��������� ��� ����� (3306 � 33060), ������� �� ��� ���������� 
Docker ����� � �������� ���������� �� ����� �� ���������� �� �����, ����� ���������, �� ������� �� �� ������� ���� ��� ����������� ���� ���������.



� ���������� `-e MYSQL_USER=wordpress` ������� ���������� �� ������ ����� MySQL.
���� ���������� �� � ������� � ����������� �� ������������� �������, � � MySQL ����������, ����� ��� ������ �� ������ �����, ��������� � ����������.

### ��������� �� `MYSQL_USER`:
- **`MYSQL_USER`**: ���� � ����� �� MySQL ����������, ����� �� ���� �������� � ����������. � ������ � �������� ����� �� ����������� �� ���� `wordpress`.
- ���� ���������� �� ��� ����� �� �� ������� � MySQL � �� �������� �������� � ������ �����, ����� ��������, ��� ����� ���� �����, � ���������� �� ������� ��.

### ��� ������:
1. **��������� �� ������ �����**:
   -� ���������, ����� ��������, ���������� � ���������� `MYSQL_DATABASE=wordpressdb`. 
    ���� ��������, �� ������ MySQL ����������� �� ��������, ��� �� ������� ������ ����� `wordpressdb`.

2. **������������ `wordpress`**:
   -� ���������� `MYSQL_USER=wordpress` MySQL �� ������� ����������� `wordpress`. 
    ���� ���������� �� ��� ������ �� ������ ����� `wordpressdb`, ������ ��� ����������� �� ����������� ����������� �� �� ����� ������ ����� �� ������ � ��� (���� �� ������ � MySQL).
   
3. **������ �� �����������**:
   -����������� `MYSQL_PASSWORD = wordpress` ������ �������� �� MySQL ����������� `wordpress`.
    ���� ������ �� ���� ���������� �� ������������ �� ����������� ��� ��������� ��� MySQL �������.

### ������:
- **������������ `wordpress`** � MySQL ����������, �������� � ������ ����� MySQL � ����������, � �� ��� ������ �� ������ ����� `wordpressdb` ��� ���������� ������ `wordpress`.
- ���� ���������� � �����, ��������, ������ WordPress �� ������� � MySQL �������, �� �� ���� � ���� � ������ �����.

���� ��, � ������, **���� �� � ���������� �� ������������� �������, � ���������� � ��������� �� MySQL, ����� � �������� � ��� �� �������� ������ �����, �������� � WordPress.**