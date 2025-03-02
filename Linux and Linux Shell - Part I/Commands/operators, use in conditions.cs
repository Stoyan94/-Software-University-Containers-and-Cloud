Explanation of -eq and other comparison operators:

-eq: Equal � checks if two numeric values are equal.
Example:

a=5
b=5

if [ $a -eq $b] ; then
  echo "a and b are equal!"
else
  echo "a and b are not equal!"
fi
Since both a and b are equal, the output will be:
a and b are equal!


Other comparison operators:

-ne: Not equal � checks if two values are not equal.
Example:
a=5
b=3

if [ $a -ne $b] ; then
  echo "a and b are not equal!"
else
  echo "a and b are equal!"
fi

Output:
a and b are not equal!


-lt: Less than � checks if the first value is less than the second.
Example:
a=3
b=5

if [ $a -lt $b] ; then
  echo "a is less than b!"
else
  echo "a is not less than b!"
fi

Output:
a is less than b!


-le: Less than or equal to � checks if the first value is less than or equal to the second.
Example:
a=5
b=5

if [ $a -le $b] ; then
  echo "a is less than or equal to b!"
else
  echo "a is not less than or equal to b!"
fi

Output:
a is less than or equal to b!



-gt: Greater than � checks if the first value is greater than the second.
Example:
a=7
b=5

if [ $a -gt $b] ; then
  echo "a is greater than b!"
else
  echo "a is not greater than b!"
fi

Output:
a is greater than b!


-ge: Greater than or equal to � checks if the first value is greater than or equal to the second.
Example:
a=7
b=5

if [ $a -ge $b] ; then
  echo "a is greater than or equal to b!"
else
  echo "a is not greater than or equal to b!"
fi

Output:
a is greater than or equal to b!


Summary of Operators:
-eq: Equal
- ne: Not equal
-lt: Less than
-le: Less than or equal to
-gt: Greater than
-ge: Greater than or equal to
These operators are very useful for numeric comparisons, especially when writing shell scripts to perform conditional actions based on numeric values.





��������� �� -eq � ������� �������� �� ���������:
-eq: ����� � ��������� ���� ��� ������� ��������� �� �����.
������:
a=5
b=5

if [ $a -eq $b] ; then
  echo "a � b �� �����!"
else
  echo "a � b �� �� �����!"
fi

��� ���� � a, � b �� �����, ������� �� ����:
a � b �� �����!


����� �������� �� ���������:

-ne: ������� � ��������� ���� ��� ��������� �� �� �����.
������:
a=5
b=3

if [ $a -ne $b] ; then
  echo "a � b �� �� �����!"
else
  echo "a � b �� �����!"
fi

�����:
a � b �� �� �����!


-lt: �� - ����� �� � ��������� ���� ������� �������� � ��-����� �� �������.
������:
a=3
b=5

if [ $a -lt $b] ; then
  echo "a � ��-����� �� b!"
else
  echo "a �� � ��-����� �� b!"
fi

�����:
a � ��-����� �� b!


-le: �� - ����� ��� ����� �� � ��������� ���� ������� �������� � ��-����� ��� ����� �� �������.
������:
a=5
b=5

if [ $a -le $b] ; then
  echo "a � ��-����� ��� ����� �� b!"
else
  echo "a �� � ��-����� ��� ����� �� b!"
fi

�����:
a � ��-����� ��� ����� �� b!


-gt: �� - ������ �� � ��������� ���� ������� �������� � ��-������ �� �������.
������:
a=7
b=5

if [ $a -gt $b] ; then
  echo "a � ��-������ �� b!"
else
  echo "a �� � ��-������ �� b!"
fi

�����:
a � ��-������ �� b!


-ge: �� - ������ ��� ����� �� � ��������� ���� ������� �������� � ��-������ ��� ����� �� �������.
������:
a=7
b=5

if [ $a -ge $b] ; then
  echo "a � ��-������ ��� ����� �� b!"
else
  echo "a �� � ��-������ ��� ����� �� b!"
fi

�����:
a � ��-������ ��� ����� �� b!



��������� �� �����������:
-eq: �����
- ne: �������
- lt: �� - ����� ��
- le: �� - ����� ��� ����� ��
-gt: �� - ������ ��
- ge: �� - ������ ��� ����� ��
���� ��������� �� ����� ������� ��� ������� ���������, ������� ������ ������ shell ���������, 
����� ��������� ������� �������� �� ������ �� ������� ���������