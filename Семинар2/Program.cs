
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
class Program
{
static void selectRase()
{
    string [] namesRase = {"люди", "эльфы", "гномы", "орки", "гоблины"};
    Console.WriteLine("Выбери свою расу");
    for(int i=0; i<namesRase.Length; i++)
    {
        Console.Write(i+1 + " - " + namesRase[i] + ";" + " ");
    }
}
 static void Main(string[] args)
    {
    selectRase();
    }
}