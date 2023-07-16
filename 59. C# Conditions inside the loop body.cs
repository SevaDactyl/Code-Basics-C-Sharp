/* 
Метод из теории учитывает регистр букв. То есть A и a, с его точки зрения, это разные символы. Реализуйте вариант этого же метода так, чтобы регистр букв был не важен:

App.CountChars("HexlEt", 'e'); // 2
App.CountChars("HexlEt", 'E'); // 2
char.ToLower() – переводит символ в нижний регистр
*/

// Первое решение

class App
{
    public static int CountChars(string str, char ch)
    {
        // BEGIN (write your solution here)
        var i = 0;
        var count = 0;
        str = str.ToLower();
        ch = Char.ToLower(ch);
        
        while (i < str.Length) 
        {
            if (str[i] == ch) 
            {
                count += 1;
            }
            i += 1;
        }
        return count;
        // END
    }
}

// Второе решение

class App
{
    public static int CountChars(string str, char ch)
    {
        // BEGIN (write your solution here)
        var i = 0;
        var count = 0;
        while (i < str.Length)
        {
            var currentChar = char.ToLower(str[i]);
            if (currentChar == char.ToLower(ch))
            {
                count = count + 1;
            }

            i = i + 1;
        }

        return count;
        // END
    }
}
