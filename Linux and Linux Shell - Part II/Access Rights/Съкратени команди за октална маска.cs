��������� chmod u+rwm script.sh �� ������ ����� �� ������ (r), ������ (w) � ���������� (x) �� ����������� �� ����� (u �� "user").
 ���� ������� ��������:

r(����): ������ ����� �� ������ �� ����������� �� �����.
w (����): ������ ����� �� ������ �� ����������� �� �����.
x (���������): ������ ����� �� ���������� �� ����������� �� �����.
���� �� ������� �� ����������� �� ����� �� ���� �� �� ����, ������� � ���������, �� �� ������� ������� �� ������� ��� ���������� �����������.

��� ����� �� ������� ����� ����� �� ������� ��� ���������� �����������, ����� �� ������� ��������� g (�����) ��� o (����������). 
��������:

chmod g+rx script.sh � ������ ����� �� ������ � ���������� �� �������.
chmod o+x script.sh � ������ ���� ����� �� ���������� �� ���������� �����������.



��� ������ � ��������� ��������� ���������� �� ��������� chmod, chown � chgrp:

1.chmod(������� �� ����� �� ������ �� �������)
r � ������ (read)
w � ������ (write)
x � ���������� (execute)
+ � ������ �������
- � �������� �������
= � ��������� ������� �� ���������� ����������
u � ���������� �� ����� (user)
g � ����� �� ����� (group)
o � ����� ����������� (others)
a � ������ (all)

�������� ����������:

chmod u+x file � ������ ������������ ����� �� ����������� �� �����.
chmod g-w file � �������� ������� �� ������ �� �������.
chmod o=r file � ��������� ������� �� ������ �� ������� �����������.
chmod a+x file � ������ ������������ ����� �� ������ (����������, �����, �����).
������� ���������:

4 � ������(r)
2 � ������(w)
1 � ����������(x)
0 � ��� �����

������:
chmod 755 file � �� ����� ����� ����� �� ����������� (7 = 4 + 2 + 1), ����� �� ������ � ���������� �� ������� � ������� (5 = 4 + 1).


2. chown (������� �� ���������� � ����� �� ����)
user � ���������� �� �����
group � ����� �� �����

���������:
chown [����������][:�����] ����

�������� ����������:

chown user file � ������� ����������� �� ����� �� "user".
chown user:group file � ������� ����������� �� ����� �� "user" � ������� �� "group".
chown :group file � ������� ���� ������� �� ����� �� "group".
chown user: file � ������� ���� ����������� �� ����� �� "user", �� �� ������� �������.


3. chgrp (������� �� ����� �� ����)
group � ����� �� �����

���������:
chgrp ����� ����


�������� ����������:

chgrp group file � ������� ������� �� ����� �� "group".
chgrp -R group directory � ������� ������� �� ������ ������� � �������� � ������������ ����������.
���� ��������� ����� �� chmod, chown � chgrp �� ���-����� ������������ �� ���������� �� ����� � ����������� �� ������� � Unix-������� ����������� �������.



������� �� ��������� chmod, chown, � chgrp, ����������� ������ �� ����������:

1.chmod(������� �� ����� �� ������)

������� �� �������:
chmod u+x file � ������ ������������ ����� �� ����������� �� �����.

chmod g-w file � �������� ������� �� ������ �� �������.

chmod o=r file � ��������� ������� �� ������ �� ������� �����������.

chmod a+x file � ������ ������������ ����� �� ������ (����������, �����, �����).

chmod 644 file � ����� �� ������ � ������ �� �����������, ���� �� ������ �� ������� � �������. (644 = 4 + 2 + 0 �� �����������, 4 + 0 + 0 �� ������� � �������).

chmod 777 file � ���� ����� ����� �� ������ (����, ����, ���������) �� �����������, ������� � �������.



������� �� ����������:

chmod u+x directory � ������ ������������ ����� �� ����������� �� ������������. ���� ��������, �� ������������ ���� �� �������� � ������������ (�.�., �� ����� � ���).

chmod g+rx directory � ������ ����� �� ������ � ���������� �� �������, ����� ��������, �� ������� ���� �� ���� ������������ � �� �������� � ������������.

chmod a+rx directory � ������ ����� �� ������ � ���������� �� ������ ����������� (����������, �����, �����).

chmod -R 755 directory � ���������� ������ ����� �� ������, ������ � ���������� �� ����������� � ����� �� ������ � ���������� �� ������� � ������� �� ������ ������� � ���������� ����� � ��������� ����������.


2. chown (������� �� ���������� � ����� �� ���� ��� ����������)

������� �� �������:

chown user file � ������� ����������� �� ����� �� "user".

chown user:group file � ������� ����������� �� ����� �� "user" � ������� �� "group".

chown :group file � ������� ������� �� ����� �� "group", ��� �� ������� �����������.

chown user: file � ������� ���� ����������� �� ����� �� "user", ��� �� ������� �������.


������� �� ����������:

chown user:group directory � ������� ����������� � ������� �� ������������ �� "user" � "group".

chown -R user:group directory � ���������� ������� ����������� � ������� �� ������ ������� � �������� � ������������.

chown -R user: directory � ���������� ������� ����������� �� ������ ������� � �������� � ������������ �� "user", ��� �� ������� �������.



3. chgrp (������� �� ����� �� ���� ��� ����������)

������� �� �������:

chgrp group file � ������� ������� �� ����� �� "group".

chgrp -v group file � ������� ������� �� ����� �� "group" � ������� ���������� �� ���������.

chgrp --reference=another_file file � ������� ������� �� �����, ���� �� �� �� ������� � ������� �� another_file.


������� �� ����������:

chgrp group directory � ������� ������� �� ������������ �� "group".

chgrp -R group directory � ���������� ������� ������� �� ������ ������� � �������� � ������������.


4. ������� ����������

���������� �� ���������� � �������������:

chmod - R 755 directory � ������ ����� �� ������, ������ � ���������� �� ����������� � ����� �� ������ � ���������� �� ������� � ������� �� ������ ������� � ���������� ����� � ��������� ����������.

chown -R user:group directory � ���������� ������� ����������� � ������� �� ������ ������� � ���������� ����� � ��������� ����������.

chgrp -R group directory � ���������� ������� ������� �� ������ ������� � ���������� ����� � ��������� ����������.


����������
������������ �� ���� ������� � ���������� � ����� ���� -R (����������) ���� �� ������� ��� ������������ �� ����� � ����������� �� ������� � ����������, ������� ������ ������� � ������ ���������� ������� ��� ����������.