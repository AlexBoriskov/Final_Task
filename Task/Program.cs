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