/*// вид1 - ничего не принимают и не возвращают
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
Method21(count:4, msg:"новый Текст");

//Вид 3
 
int Method3()
{
    return DateTime.Now.Year;
} 
int year = Method3();
Console.WriteLine(year);

//Вид4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result=result+text;
        i++;
    }
    return result
}

string res = Method4(10, asdf);
Console.WriteLine(res);

// Цикл for
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    for (int i=0; i, i< count; i++)
    {
        result=result+text;
    }
    return result
}

string res = Method4(10, asdf);
Console.WriteLine(res);

// Цикл for/ таблица умножения 

for (int i = 2; i<=10; i++)
{
    for (int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}


//======Работа с текстом. 
//Дан текст. В тексте нужно все пробелы заменить четрочками, мал буквы к зам больш К,
//больш С заменить маленькими

string text = "– Я думаю, – сказал князь, улыбаясь, – что, " 
            +  "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. " 
            + "Вы так красноречивы. Вы дадите мне чаю? ";
//string s = "qwerty"
//            0123
//s[3] r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'е', 'Е');
Console.WriteLine(newText); */

int [] arr={4, 1, 7, 8, 3, 9, 5, 9};
void PrintArray(int[] array)
{
   int count = array.Length;
   for (int i=0; i<count; i++)
   {
    Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}
/*void SelectionSort (int [] array)
{
   for (int i=0; i< array.Length-1 ; i++) 
   {
    int minPosition = i;
    for (int j = i+1; j<array.Length; j++)
   {
    if (array[j]<array[minPosition]) minPosition=j;
   }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
   }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);*/
void SelectionSort (int [] array)
{
   for (int i=0; i< array.Length-1 ; i++) 
   {
    int minPosition = i;
    for (int j = i+1; j<array.Length; j++)
   {
    if (array[j]>array[minPosition]) minPosition=j;
   }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
   }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);