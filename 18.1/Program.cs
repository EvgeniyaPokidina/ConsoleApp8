string[] words = { "СВЕТ", "ЦВЕТОК", "СОЛНЦЕ", "ВОДА", "ДЕНЬ" };
string sentence = "";
string word = "";
do

{
    Console.Write("Введите слово:");
    word = Console.ReadLine();
    for (int i = 0; i < words.Length; i++)
    {
        if (word == words[i])
        {
            word = "(скрыто)";

            break;
        }
    }
    sentence += word + " ";
}
while (word != "конец");
Console.WriteLine(sentence);





