string[] words = { "СВЕТ", "ЦВЕТОК", "СОЛНЦЕ", "ВОДА", "ДЕНЬ" };
string sentence = "";
string word = "";
do
{
    Console.Write("Введите слово:");
    word = Console.ReadLine()!;
    string up = word.ToUpper();
    if (words.Contains(up))
    {
        sentence += "скрыто ";
    }
    else if (word != "конец")
    {
        sentence += word + " ";
    }
}
while (word != "конец");
Console.WriteLine(sentence);

