/* 
Реализуйте статический метод App.PrintReversedNameBySymbol(), который печатает переданное слово посимвольно, как в примере из теории, но делает это в обратном порядке.

var name = "Arya";
App.PrintReversedNameBySymbol(name);
// 'a'
// 'y'
// 'r'
// 'A'
*/

// Первое решение

class App
{
    public static void PrintReversedNameBySymbol(string name)
    {
        // BEGIN (write your solution here)
        int i = 0;
        while (i < name.Length) 
        {
            Console.WriteLine(name[name.Length - i - 1]);
            i++;
        }
        // END
    }
}

// Второе решение

class App
{
    public static void PrintReversedNameBySymbol(string name)
    {
        // BEGIN (write your solution here)
        var i = name.Length - 1;
        while (i >= 0)
        {
            Console.WriteLine(name[i]);
            i = i - 1;
        }
        // END
    }
}
