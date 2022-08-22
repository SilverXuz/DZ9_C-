/*  Перестановки
Дана строка, состоящая из N попарно различных символов. 
Требуется вывести все перестановки символов данной строки. Без повторений.
*/


Console.Write("Введите символы, буквы английского алфавита или цифры(от 1 до 8 знаков): ");
string word = Convert.ToString(Console.ReadLine());
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords(word, new char[word.Length]);
