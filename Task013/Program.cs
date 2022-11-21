// Составление слов из буквенного массива

int n = 1;
void FindWorld(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWorld(alphabet, word, length +1);
    }
}

FindWorld("асив", new char[2]);
