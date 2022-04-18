// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first integer number");
int num1 = Convert.ToInt32 (Console .ReadLine ());
Console.Write("Input second integer number");
int num2 = Convert.ToInt32 (Console .ReadLine ());


if(num1 > num2)
{
     Console.WriteLine("Первое число больше второго" );
}
 else if (num1 < num2)
{
     Console.WriteLine("Первое число меньше второго" );
}
else
{
     Console.WriteLine("серьезно? иди поспи!" );
}


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first integer number");
int num1 = Convert.ToInt32 (Console .ReadLine ());
Console.Write("Input second integer number");
int num2 = Convert.ToInt32 (Console .ReadLine ());
Console.Write("Input third integer number");
int num3 = Convert.ToInt32 (Console .ReadLine ());

if(num1 > num2 & num1 > num3 )
{
    Console.WriteLine("first number max " + num1 );
}

else if(num2 > num1 & num2 > num3 )
{
    Console.WriteLine("second number max " + num2 );
}

else if(num3 > num1 & num3 > num1 )
{
    Console.WriteLine("third number max " + num3 );
}


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Write("Input first integer number");
int num1 = Convert.ToInt32 (Console .ReadLine ());


if (num1 % 2 == 0)

{
    Console.WriteLine("число четное "  );
}

else
{
    Console.WriteLine("число не четное "  );
}
*/


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N



Console.Write("Input first integer number");
int num1 = Convert.ToInt32 (Console .ReadLine ());
int current = 0 * num1;

while(current <= num1 )

{
    Console.Write(current + " ");
    current++;
}
