{
    Dictionary<int, string>eve = new Dictionary<int, string>()
    {
       {1, "ПН - рабочий день"},
       {2, "ВТ - рабочий день"},
       {3, "ср - рабочий день"},
       {4, "чтв - рабочий день"},
       {5, "Пт - рабочий день"},
       {6, "суб - рабочий день"},
       {7, "вск - рабочий день"},
    };
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(eve[index]);
}