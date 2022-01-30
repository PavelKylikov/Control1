// Создал метод вывода массива (PrintArray) в консоль 
void PrintArray(string[] Array)
{
    int count = Array.Length;
    int position = 0;
    while (position < count)
    {
         Console.Write(Array[position] + " ");
         position++;
    }
}
Console.WriteLine();
