void FillArray (string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine ($"Введите {i}-тый элемент массива");
        mas[i] = Console.ReadLine();
    }
}
 
 void PrintArray (string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
}

Console.WriteLine ("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

string [] array = new string[n];

FillArray (array);
PrintArray (array);
Console.WriteLine ();
