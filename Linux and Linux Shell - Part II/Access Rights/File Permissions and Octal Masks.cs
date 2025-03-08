File and Directory Permissions in Linux
In Linux, files and directories have access permissions that define who can read, write, or execute a given file or directory.

Understanding Permissions and Octal Mask
Linux uses three types of permissions:

r(read) – Read(4)
w(write) – Write(2)
x(execute) – Execute(1)
Permissions are assigned to three user levels:

Owner – The user who owns the file
Group – Users belonging to the same group
Others – All other users
The table below shows some common permission combinations:

Bit Mask	Decimal	 Description
---------	000	     No permissions
rw-rw-rw-	666	     Everyone can read and write
rwxr-xr-x	755	     Owner has full access, others can read and execute
rwxrwxrwx	777	     Everyone can read, write, and execute


Commands for Managing Permissions and Ownership

1. Changing Permissions with chmod
The chmod command allows you to modify file and directory permissions.

Syntax:
chmod [options][permissions][file/directory]
Examples:

Grant full access to the owner only:
chmod 700 myfile

Allow execution for all users:
chmod 755 script.sh


2. Changing Ownership with chown
File or directory ownership can be changed using chown.

Syntax:
chown [new_owner][file]

Examples:

Change file owner:
chown user myfile

Change both owner and group:
chown user:group myfile

Recursively change ownership (for all files in a directory):
chown -R user:group mydir/


3. Changing Group with chgrp
The group ownership of a file can be modified with chgrp.

Syntax:
chgrp [new_group][file]

Example:
chgrp developers project.txt



Where Do These Number Combinations Come From?
The numbers (e.g., 755, 777, 666) come from the octal (base-8) numbering system and represent how Linux manages file permissions.

How Are They Calculated?
Each permission type has a numerical value:

Permission Symbol  Value
Read	    r	   4
Write	    w	   2
Execute	    x	   1
By combining these values, permissions are assigned to each user level (owner, group, others).
Each of them receives a three-digit code, where:

First digit → Owner
Second digit → Group
Third digit → Others


Examples of Permission Calculation

Example 1: 755
Owner has rwx (read + write + execute) → 4+2+1 = 7
Group has r-x (read + execute) → 4+0+1 = 5
Others have r-x (read + execute) → 4+0+1 = 5

So, 755 means:
rwxr-xr-x
(The owner has full rights, while the group and others can only read and execute.)


Example 2: 777
Owner: rwx(4 + 2 + 1 = 7)
Group: rwx(4 + 2 + 1 = 7)
Others: rwx(4 + 2 + 1 = 7)

This means everyone has full access (read, write, and execute):
rwxrwxrwx


Example 3: 644
Owner: rw - (4 + 2 + 0 = 6)
Group: r--(4 + 0 + 0 = 4)
Others: r--(4 + 0 + 0 = 4)

This means:
rw-r--r--
(The owner can read and write, but the group and others can only read.)

Quick Reference Table for Permission Values
Number	Meaning
0	    No permissions (---)
1	    Execute (--x)
2	    Write (-w-)
3	    Write + Execute (-wx)
4	    Read (r--)
5	    Read + Execute (r-x)
6	    Read + Write (rw-)
7	    Read + Write + Execute (rwx)
This makes it easy to quickly understand or set file permissions in Linux. 🚀







В Linux файловите и директориите имат права за достъп, които се задават чрез permissions (разрешения).
Те определят кой може да чете, записва или изпълнява даден файл/директория.

Разбиране на правата и окталната маска

Linux използва три вида права:

r(read) – четене(4)
w(write) – запис(2)
x(execute) – изпълнение(1)

Правата се задават за три нива на потребители:

Owner(собственик) – кой е собственик на файла
Group (група) – потребителите, които принадлежат към същата група
Others (други) – всички останали потребители
Таблицата по-долу показва някои често срещани комбинации:

Битова маска	Десетично	Описание
---------	    000	        Без права
rw-rw-rw-	    666	        Всички могат да четат и пишат
rwxr-xr-x	    755	        Собственикът има всички права, останалите могат само да четат и изпълняват
rwxrwxrwx	    777	        Всички могат да четат, пишат и изпълняват


Команди за управление на права и собственост
1. Промяна на права с chmod
С командата chmod можеш да променяш правата на файлове и директории.

Синтаксис:
chmod [опции][права][файл/директория]

Примери:

Даване на пълен достъп само на собственика:
chmod 700 myfile

Разрешаване на изпълнение за всички:
chmod 755 script.sh


2. Промяна на собственика с chown
Собствеността върху даден файл или директория може да бъде променена с chown.

Синтаксис:
chown [нов_собственик][файл]

Примери:

Смяна на собственика на файла:
chown user myfile

Смяна на собственика и групата:
chown user:group myfile

Промяна на собственика рекурсивно (за всички файлове в директория):
chown -R user:group mydir/


3. Промяна на групата с chgrp
Груповата собственост на файл може да бъде сменена с chgrp.

Синтаксис:
chgrp [нова_група][файл]

Пример:
chgrp developers project.txt
Това са основните команди за работа с права и собственост в Linux.🚀



Тези комбинации от цифри (напр. 755, 777, 666) идват от основата на окталната (осмична) бройна система и са свързани с начина, 
по който Linux управлява файловите разрешения.

Как се изчисляват?
В Linux всяко право (read, write, execute) има цифрова стойност:

Право                 Буква	 Стойност
Read (четене)	      r	     4
Write (запис)	      w	     2
Execute (изпълнение)  x	     1

Комбинирайки тези стойности, се формират разрешенията за всеки тип потребител (собственик, група и други).
Всеки от тях получава трицифрен код, където:

Първата цифра е за собственика (owner).
Втората цифра е за групата (group).
Третата цифра е за останалите (others).

Примери за изчисляване на права:

Пример 1: 755
Собственикът има rwx (четене + запис + изпълнение) → 4+2+1 = 7
Групата има r-x (четене + изпълнение) → 4+0+1 = 5
Другите имат r-x (четене + изпълнение) → 4+0+1 = 5

Следователно, 755 означава:
rwxr-xr-x
(Собственикът има всички права, а групата и останалите могат само да четат и изпълняват)

Пример 2: 777
Собственик: rwx(4 + 2 + 1 = 7)
Група: rwx(4 + 2 + 1 = 7)
Други: rwx(4 + 2 + 1 = 7)

Това означава, че всички имат пълен достъп (четене, писане и изпълнение):
rwxrwxrwx

Пример 3: 644
Собственик: rw - (4 + 2 + 0 = 6)
Група: r--(4 + 0 + 0 = 4)
Други: r--(4 + 0 + 0 = 4)

Това означава:
rw-r--r--
(Собственикът може да чете и пише, но групата и останалите могат само да четат)

Как бързо да пресметнеш?
0 = Няма права ---
1 = Изпълнение --x
2 = Запис -w-
3 = Запис + изпълнение -wx
4 = Четене r--
5 = Четене + изпълнение r-x
6 = Четене + запис rw-
7 = Четене + запис + изпълнение rwx
Така можеш бързо да разбираш или задаваш права на файлове в Linux. 🚀😊