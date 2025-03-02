Explanation of -eq and other comparison operators:

-eq: Equal – checks if two numeric values are equal.
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

-ne: Not equal – checks if two values are not equal.
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


-lt: Less than – checks if the first value is less than the second.
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


-le: Less than or equal to – checks if the first value is less than or equal to the second.
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



-gt: Greater than – checks if the first value is greater than the second.
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


-ge: Greater than or equal to – checks if the first value is greater than or equal to the second.
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





Обяснение на -eq и другите операнти за сравнение:
-eq: Равно – проверява дали две числови стойности са равни.
Пример:
a=5
b=5

if [ $a -eq $b] ; then
  echo "a и b са равни!"
else
  echo "a и b не са равни!"
fi

Тъй като и a, и b са равни, изходът ще бъде:
a и b са равни!


Други операнти за сравнение:

-ne: Неравно – проверява дали две стойности не са равни.
Пример:
a=5
b=3

if [ $a -ne $b] ; then
  echo "a и b не са равни!"
else
  echo "a и b са равни!"
fi

Изход:
a и b не са равни!


-lt: По - малко от – проверява дали първата стойност е по-малка от втората.
Пример:
a=3
b=5

if [ $a -lt $b] ; then
  echo "a е по-малко от b!"
else
  echo "a не е по-малко от b!"
fi

Изход:
a е по-малко от b!


-le: По - малко или равно на – проверява дали първата стойност е по-малка или равна на втората.
Пример:
a=5
b=5

if [ $a -le $b] ; then
  echo "a е по-малко или равно на b!"
else
  echo "a не е по-малко или равно на b!"
fi

Изход:
a е по-малко или равно на b!


-gt: По - голямо от – проверява дали първата стойност е по-голяма от втората.
Пример:
a=7
b=5

if [ $a -gt $b] ; then
  echo "a е по-голямо от b!"
else
  echo "a не е по-голямо от b!"
fi

Изход:
a е по-голямо от b!


-ge: По - голямо или равно на – проверява дали първата стойност е по-голяма или равна на втората.
Пример:
a=7
b=5

if [ $a -ge $b] ; then
  echo "a е по-голямо или равно на b!"
else
  echo "a не е по-голямо или равно на b!"
fi

Изход:
a е по-голямо или равно на b!



Обобщение на операторите:
-eq: Равно
- ne: Неравно
- lt: По - малко от
- le: По - малко или равно на
-gt: По - голямо от
- ge: По - голямо или равно на
Тези оператори са много полезни при числови сравнения, особено когато пишете shell скриптове, 
които извършват условни действия на базата на числови стойности