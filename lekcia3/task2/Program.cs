// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить на черточки, маленькие буквы к
// заменить на большие К, а большие буквы С заменить на маленькие с.
Console.Clear();
string text = "И трепетом ветра окутала разум."
            + "И я, очарованный дикими пазлами гетто "
            + "Сам наломал тех дров, а художник "
            + "Слепо рисует сюжеты. ";
string RepLase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = RepLase(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLase(newText, 'С', 'с');
Console.WriteLine(newText);
