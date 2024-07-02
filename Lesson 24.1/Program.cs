//Дано слово, состоящее только из строчных букв. Проверьте, является ли это слово палиндромом.
//Выведите Is a palindrom если слово таковым является и Not a palindrom в
//противном случае
Console.Write("Введите слово:");
string word = Console.ReadLine()!;
Console.WriteLine(IsPalindrome(word));
static bool IsPalindrome(string word)
{
    if (word.Length <= 1)
    {
        Console.WriteLine("Is a palindrom");
        return true;
    }
    else
    {
        if (word[0] != word[word.Length - 1])
        {
            Console.WriteLine("Not a palindrom");
            return false;
        }
        else
        {
            return IsPalindrome(word.Substring(1, word.Length - 2));
        }
    }
}

