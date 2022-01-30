// Создал метод вывода массива (PrintArray) в терминал 
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
// Создаём массив заполнив его текстами
string[] Array1 = {"hello", "Ура", "world", "по", ";%:?*", "лу", "f4ы3", "чил", "sgbcr", "ось", "!"};
PrintArray(Array1);
