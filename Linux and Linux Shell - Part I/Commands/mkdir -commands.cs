� Linux ����� �� �������� ���������� � ��������� mkdir. ��� ������� �������:

������� �������:
��������� �� ���� ����������
mkdir my_directory


��������� �� ������� ���������� ��������
mkdir -p parent/child/grandchild
������ -p ������� ������ ���������� �������������, ��� �� �����������.

��������� �� ������� ���������� ��������
mkdir dir1 dir2 dir3

��������� �� ���������� � �������������� �����
mkdir dir_{1..5}
���� �� ������� dir_1, dir_2, dir_3, dir_4, dir_5.



������� � �������:
��������� �� ���������� � "��������" ���

mkdir " "
���� ������� ���������� � ������ ��� (��������), ����� ���� �� � ������ �� ��������. 
�� �� � ������ � ���:
cd " "


��������� �� ���������� � escape �������
mkdir $'\n'

����� �� � ������� ����:
rm -rf $'\n'


��������� �� ���������� � ��������� � �����
mkdir $'\t'
���� �� ������� ���������� � ��� "���". 

����� �� � ������� �:
rm -rf $'\t'


��������� �� ���������� ��� ��������� �������
mkdir -- "-l"
���� ����� ���������� � ��� -l, ����� �������� ���� ����. 
�� �� � �������:
rmdir -- "-l"


��������� �� ���������� � /dev/shm/ �� �������� �������� �������

� ������������ /dev/shm/ (��������� �����) ����� �� �������� ���������� �� �������� �������, ����� �������� ��� �������:
mkdir /dev/shm/my_secret

���� �� ������ �� �������� �� ����������� �� ����������� ���������, ������ �� �� ������� � �����.

��������� �� "������������" ����������
mkdir protected_folder
chmod -w protected_folder
���� �������� ������� �� ������ � ����� �� �����������, ����� ��� �� ������ ������� �:
chmod +w protected_folder


���������� �� mktemp �� �������� ����������
mktemp -d /tmp/secret_XXXX
���� ������� ���������� � �������� ���, ����. /tmp/secret_KJH8. ������� �� ���������.