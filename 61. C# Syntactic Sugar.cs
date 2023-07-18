/* 
Реализуйте статический метод FilterString() в классе App, принимающую на вход строку и символ, и возвращающую новую строку, в которой удален переданный символ во всех его позициях.

Пример вызова:

var str = "If I look back I am lost";
App.FilterString(str, 'I'); // "f  look back  am lost"
App.FilterString(str, 'o'); // "If I lk back I am lst"
*/

// Первое решение

class App
{
    public static string FilterString(string str, char ch)
    {
        // BEGIN (write your solution here)
        int i = 0;
        while (i < str.Length - 1) 
        {
            if (str[i] == ch) 
            {
                str = str.Remove(i, 1);
            } else 
            {
                i++;
            }
        }
        return str;
        // END
    }
}

// Второе решение

class App
{
    public static string FilterString(string str, char ch)
    {
        // BEGIN (write your solution here)
        var i = 0;
        var result = "";
        while (i < str.Length)
        {
            var currentChar = str[i];
            if (currentChar != ch)
            {
                result = result + currentChar;
            }

            i += 1;
        }

        return result;
        // END
    }
}
