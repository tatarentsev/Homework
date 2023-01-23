Console.Write("Введите пятизначное число, а я проверю является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = number % 10; // последняя цифра
int n2 = (number % 100) / 10; // предпоследняя цифра
int n4 = number / 1000 % 10;
int n5 = number / 10000;

if (n1 == n5 & n2 == n4)
{
    Console.WriteLine($"Число {number} является палиндромом");
}

else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}