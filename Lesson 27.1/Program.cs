using Lesson_27._1;
//private: Методы или члены с модификатором private доступны только в пределах того же класса, в котором они объявлены.
//Они не доступны из других классов. private обеспечивает наивысший уровень защиты данных и инкапсуляцию.
//public: Методы или члены с модификатором public доступны из любой части программы, даже из других классов.
//protected: Методы или члены с модификатором protected доступны внутри того же класса, также в производных классах.
//Они не доступны из других классов, не являющихся производными. 
static void Main(string[] args)
{
    Console.Write("Укажите количество рублей: ");
    decimal rub;
    decimal.TryParse(Console.ReadLine(), out rub);
    decimal rubToDollars=RubleConverter.toDollars(rub);
    Console.WriteLine($"{rubToDollars:F2} долларов");
    decimal rubToEuros = RubleConverter.ToEuros(rub);
    Console.WriteLine($"{rubToEuros:F2} евро");
    decimal rubToZlotys = RubleConverter.ToZlotys(rub);
    Console.WriteLine($"{rubToZlotys:F2} злотых");
    decimal rubToYuan = RubleConverter.ToYuan(rub);
    Console.WriteLine($"{rubToYuan:F2} юаней");
    decimal rubToRupes = RubleConverter.ToRupes(rub);
    Console.WriteLine($"{rubToRupes:F2} рупий"); 
}
Main(args);
