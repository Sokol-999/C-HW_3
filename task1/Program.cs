System.Console.WriteLine("Write five digit number: ");
string text = Console.ReadLine();
if (text.Length == 5)
{
    if (text[0] == text[4] && text[1] == text[3])
    {
        System.Console.WriteLine("YES");
    }
    else
    {
        System.Console.WriteLine("NO");
    }
}
else
{
    System.Console.WriteLine("It's not five digit number");
}

// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

