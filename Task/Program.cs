// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам.

void NewArray (string [] array)
{
    for (int i=0; i<array.Length;i++)
    {
        do 
        {
            Console.Write("Введите элемент №"+(i+1)+": ");
            array[i] = Console.ReadLine();
        } while (array[i] == "");
    }
}

Console.Clear();
Console.Write ("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

string [] array = new string[N];
NewArray(array);
Console.WriteLine();
Console.WriteLine ("["+string.Join(", ", array)+"]");
Console.WriteLine();

Console.Write ("Введите количество символов для сортировки: ");
int G = Convert.ToInt32(Console.ReadLine());

string [] newArray = new string[0];
int count = 0;
for (int i = 0; i<array.Length; i++)
{
    if (array[i].Length <= G) 
    {
        count++;
        Array.Resize(ref newArray, count);
        newArray[count-1] = array[i];
    }  
}

Console.WriteLine ("["+string.Join(", ", newArray)+"]");