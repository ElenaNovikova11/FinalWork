void InputArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Console.ReadLine();
}
void SecondArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
Console.Write("Введите числа, которые будут составлять массив: ");
InputArray(array);
        Console.Write("Исходный массив: ");
        Console.WriteLine(string.Join(", ", array));
     
Console.WriteLine("Значения, у которых символов больше или равно 3:");
string[] array2 = new string[array.Length];
SecondArray(array, array2);
PrintArray(array2);