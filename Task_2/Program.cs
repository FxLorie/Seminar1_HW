// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine($"Число {n1} больше числа {n2}");
else if (n1 < n2)
    Console.WriteLine($"Число {n2} больше числа {n1}");
else
    Console.WriteLine("Числа равны");