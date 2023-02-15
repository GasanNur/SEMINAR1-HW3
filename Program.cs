// Напишите программу, которая на вход принимает число и выдаёт, является 
// ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите число  ");      // вводим начальную информацию 

string inputValue = Console.ReadLine();     // для первых чисел присваиваем переменных из консоли

 int Value = Convert.ToInt32(inputValue);
 
 
 if (Value % Value == 1)  
{
    System.Console.WriteLine($"Число {Value} четное число ");
}
else
{
    System.Console.WriteLine ($"Число {Value} нечетное число");
}
