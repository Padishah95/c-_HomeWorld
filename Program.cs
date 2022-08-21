//Задача 1: Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.Write("Enter the first number: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
        
{
Console.WriteLine("first number " + num_A + " more than the second " + num_B);
}
else
{
Console.WriteLine("second number " + num_B + " more than the first " + num_A);
}
*/

//Задача 2: Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Enter 3 numbers:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;
if (num_2 > max)
{
max = num_2;
}
if (num_3 > max)
{
max = num_3;
}
Console.WriteLine("The largest of the entered numbers -> " + max);
*/        

//Задача 3: Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1 )
{
Console.WriteLine("number " + number + " Is an odd number");
}
else
{
Console.WriteLine("number " + number + "Is an even number");
}*/

//Задача 8: Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*int i = 1;
bool not = true;

Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even numbers from " + num);
while (i <= num)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}

if (not)
{
Console.WriteLine("there are no even numbers");
}
/*

            
    
