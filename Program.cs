// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []


int Input(string message)
{
  Console.Write($"{message}:\t");
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void FillArray(string[] array)
{
  Console.WriteLine($"Введите {array.Length}-строковых элементов массива:");
  for (int i = 0; i < array.Length; i++)
    array[i] = Console.ReadLine();
  Console.WriteLine();
}


void PrintArray(string[] array)
{
  Console.Write("[ ");
  foreach (var el in array)
    Console.Write($"\"{el}\" ");
  Console.Write("]");
}


void CheckArray(string[] array)
{
  Console.Write("[ ");
  for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
      Console.Write($"\"{array[i]}\" ");
  Console.WriteLine("]");
}



try
{
  int n = Input("Введите количество элеменотов массива");
  string[] array = new string[n];
  FillArray(array);
  PrintArray(array);
  Console.Write(" -> ");
  CheckArray(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}