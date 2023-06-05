/*
Реализуйте метод ConvertString(), который принимает на вход строку и, если первая буква не заглавная, возвращает перевернутый вариант исходной строки. Если первая буква заглавная, то строка возвращается без изменений. Если на вход передана пустая строка, метод должен вернуть пустую строку.

App.ConvertString("Hello"); // "Hello"
App.ConvertString("hello"); // "olleh"

// Не забудьте учесть пустую строку!
App.ConvertString(""); // ""
Functions.StringReverse() – переворот строки
char.IsUpper() – проверка символа на верхний регистр
Попробуйте написать два варианта функции: с обычным if-else, и с тернарным оператором.
*/

// Первое решение

class App
{
    // BEGIN (write your solution here)
    public static string ConvertString(string text)
    {   
        if (text == "")
        {
            return "";
        }

        else if (char.IsUpper(text[0]))
        {
            return text;
        }

        return Functions.StringReverse(text);
    }
    // END
}

// Второе решение

class App
{
    // BEGIN (write your solution here)
    public static string ConvertString(string str)
    {
        if (str == "") {
            return "";
        }

        return char.IsUpper(str[0]) ? str : Functions.StringReverse(str);
    }
    // END
}
