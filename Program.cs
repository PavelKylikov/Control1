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
Console.WriteLine();
// Определяем колличество элементов в массиве длинной 3 и менее символов
int long3 = 0;
for (int i = 0; i < Array1.Length; i++)
{
    string Text = Array1[i];
    int length = Text.Length;
    if (length <= 3)
    {
        long3 = long3 + 1;
    }
}
Console.WriteLine(long3);
// Создаём массив с длинной равному колличеству 
// элементов в массиве длинной 3 и менее символов
string[] Array2 = new string [long3];
// Заполняем новый массив нужными элементами из изначального массива
int q = 0;
for (int j = 0; j < Array1.Length; j++)
{
    string Text = Array1[j];
    int length = Text.Length;
    if (length <= 3)
    {
        Array2[q] = Array1[j];
        q++;
    }
}
PrintArray(Array2);