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
    Console.WriteLine ();
}

string[] NewArray (string[] mas)
{
int leng = 0;
for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            leng++;
        }
    }

string[] newArr = new string [leng];
int j = 0;

for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            newArr[j] = mas[i];
            j++;
        }
    }
return newArr;
}



Console.WriteLine ("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

string [] array = new string[n];
FillArray (array);

Console.WriteLine ("Первоначальный массив:");
PrintArray (array);
Console.WriteLine ();

PrintArray (NewArray (array));
Console.WriteLine ();