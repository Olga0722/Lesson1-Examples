
/*{
    static void Main(string[] args)

    {
        int[]nums3 = {1, 4 , 6, 667, 7, 89, 13, 45, 60};
        for(int i=0; i<nums3.Length; i++)
        {
            nums3[i] = 6;
            Console.WriteLine(nums3[i]);
        }
    }
}*/

// рпг игра

class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    Dictionary<string, int> skills=new Dictionary<string, int>()
    {
        {"Сила", 0},
        {"Удача", 0},
        {"Интеллект", 0},
        {"Харизма", 0},
        {"Эмпатия", 0}
    };
}
class Program
{
static void selectRase(Hero myHero)
{
    string [] namesRase = {"Люди", "Эльфы", "Гномы", "Орки", "Гоблины"};
    Console.WriteLine("Выбери свою расу:");
    Select(namesRase);
    string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine())-1];
    Console.WriteLine("Вы выбрали расу: " + RaseHero);
    myHero.Rase = RaseHero;
}
static void selectSex(Hero myHero)
{
    string [] namesSex = {"Женский", "Мужской"};
    Console.WriteLine("Выбери свой пол:");
    Select(namesSex);
    string SexHero = namesSex[Convert.ToInt32(Console.ReadLine())-1];
    Console.WriteLine("Вы выбрали пол: " + SexHero);
    myHero.Sex = SexHero;
}

static void selectClass(Hero myHero)
{
    string [] namesClass = {"Мирянин", "Разбойник", "Вор", "Маг","Работяга"};
    Console.WriteLine("Выбери свой класс:");
    Select(namesClass);
    string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine())-1];
    Console.WriteLine("Вы выбрали класс: " + ClassHero);
    myHero.Class = ClassHero;
}
static void Select (string[]words)
{
 for(int i=0; i<words.Length-1; i++)
    {
        Console.Write(i+1 + " - " + words[i] + ";" + " ");
    }
    Console.Write(words.Length + " - " + words[words.Length-1] + "." + " ");
    Console.WriteLine(" ");
}
 static void Main(string[] args)
    {
    Hero myHero = new Hero();
    Console.WriteLine("Как вас зовут?");
    myHero.Name = Console.ReadLine();
    selectRase(myHero);
    selectSex(myHero);
    selectClass(myHero);

    Console.WriteLine("");
    Console.WriteLine("Все ваши хар-ки:");
    Console.WriteLine("");
    Console.WriteLine("Ваше имя - "+ myHero.Name);
    Console.WriteLine("Ваш пол - "+ myHero.Sex);
    Console.WriteLine("Ваша раса - " + myHero.Rase);
    Console.WriteLine("Ваш класс - " + myHero.Class);
    }
}
