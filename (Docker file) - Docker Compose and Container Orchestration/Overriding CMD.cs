ENG Version:

In Docker, `CMD` can easily be **overridden** when running a container by providing a new command after `docker run`.  

### **Example with CMD**  
```dockerfile
FROM ubuntu:latest
CMD["echo", "Hello, world!"]
```
If you start the container normally:  
```sh
docker run mycontainer
```
You'll get:  
```
Hello, world!
```
But if you provide a new command, it will **replace** the default CMD:  
```sh
docker run mycontainer echo "Custom Message"
```
The output will be:  
```
Custom Message
```
This is useful when you want your container to have a **default command**, but still allow flexibility at runtime.  

---

### **Overriding CMD in Docker Compose**
In `docker-compose.yml`, you can override `CMD` using `command`:  
```yaml
version: '3'
services:
myapp:
image: ubuntu: latest
command: echo "Overwritten CMD"
```
Here, `CMD ["echo", "Hello, world!"]` from the Dockerfile will be ignored, and `"Overwritten CMD"` will be executed instead.

---

### **What if I use ENTRYPOINT?**  
If your Dockerfile has `ENTRYPOINT`, providing a command after `docker run` will be treated as **an argument to ENTRYPOINT**, instead of overriding it.  

Example:  
```dockerfile
FROM ubuntu:latest
ENTRYPOINT["echo"]
CMD ["Hello, world!"]
```
- `docker run mycontainer` → **Hello, world!**  
- `docker run mycontainer "Custom Message"` → **Custom Message** (passed as an argument to `echo`)  
- `docker run mycontainer /bin/bash` → Will try to execute `echo /bin/bash`  

If you want to **override** `ENTRYPOINT` as well, use `--entrypoint`:  
```sh
docker run --entrypoint /bin/bash mycontainer
```
This will ignore `ENTRYPOINT` and start `/bin/bash`.

---

### **Conclusion**
- CMD can be overridden using `docker run mycontainer new_command`.  
- In `docker-compose.yml`, you can override it with `command`.  
- ENTRYPOINT is not easily overridden – it treats new commands as arguments unless replaced with `--entrypoint`.  
- **The combination of ENTRYPOINT + CMD is powerful**, as CMD acts as **default arguments** for ENTRYPOINT.








BG Version:


В Docker `CMD` може лесно да бъде **презаписан** при стартиране на контейнера, като подадеш нова команда след `docker run`.  

### **Пример с CMD**  
```dockerfile
FROM ubuntu:latest
CMD["echo", "Hello, world!"]
```
Ако стартираш контейнера по стандартния начин:  
```sh
docker run mycontainer
```
Ще получиш:  
```
Hello, world!
```
Но ако подадеш нова команда, тя ще **замени** CMD:  
```sh
docker run mycontainer echo "Custom Message"
```
Изходът ще бъде:  
```
Custom Message
```
Това е полезно, когато искаш контейнерът да има **команда по подразбиране**, но също така да позволява гъвкавост при изпълнение.  

---

### **Презаписване на CMD в Docker Compose**
В `docker-compose.yml` можеш да презапишеш `CMD`, като използваш `command`:  
```yaml
version: '3'
services:
myapp:
image: ubuntu: latest
command: echo "Overwritten CMD"
```
Тук `CMD ["echo", "Hello, world!"]` от Dockerfile ще бъде игнориран и ще се изпълни `"Overwritten CMD"`.

---

### **А ако използвам ENTRYPOINT?**  
Ако в Dockerfile има `ENTRYPOINT`, подаването на команда след `docker run` ще я третира като **аргумент на ENTRYPOINT**, вместо да я презапише.  

Пример:  
```dockerfile
FROM ubuntu:latest
ENTRYPOINT ["echo"]
CMD ["Hello, world!"]
```
- `docker run mycontainer` → **Hello, world!**  
- `docker run mycontainer "Custom Message"` → **Custom Message** (аргумент към `echo`)  
- `docker run mycontainer /bin/bash` → ще се опита да изпълни `echo /bin/bash`  

Ако искаш да **презапишеш** и `ENTRYPOINT`, използвай `--entrypoint`:  
```sh
docker run --entrypoint /bin/bash mycontainer
```
Това ще игнорира `ENTRYPOINT` и ще стартира `/bin/bash`.

---

### **Заключение**
- CMD може да бъде презаписан с `docker run mycontainer new_command`.  
- В `docker-compose.yml` можеш да използваш `command`.  
- ENTRYPOINT не се презаписва толкова лесно – той приема аргументи, освен ако не го замениш с `--entrypoint`.  
- **Комбинацията ENTRYPOINT + CMD е мощна**, защото CMD се ползва като **подразбирани аргументи** към ENTRYPOINT.