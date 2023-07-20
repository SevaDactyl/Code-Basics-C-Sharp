/* 
Реализуйте статический метод App.HasChar() в классе App, который проверяет (с учётом регистра), содержит ли строка указанную букву. Метод принимает два параметра:

Строка
Буква для поиска
App.HasChar("Renly", 'R'); // true
App.HasChar("Renly", 'r'); // false
App.HasChar("Tommy", 'm'); // true
App.HasChar("Tommy", 'd'); // false
*/

// Первое решение

class App
{
    public static bool HasChar(string str, char ch)
    {
        // BEGIN (write your solution here)
        var i = 0;
        while (i < str.Length) {
            if (str[i] == ch) {
                return true;
            }

            i += 1;
        }

    return false;
        // END
    }
}

// Второе решение

class App
{
    public static bool HasChar(string str, char ch)
    {
        // BEGIN (write your solution here)
        var i = 0;
        while (i < str.Length)
        {
            if (str[i] == ch)
            {
                return true;
            }

            i += 1;
        }

        return false;
        // END
    }
}
