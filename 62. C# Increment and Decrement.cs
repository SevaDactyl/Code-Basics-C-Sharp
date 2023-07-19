/* 
Реализуйте статический метод MakeItFunny() в классе App, который принимает на вход строку и возвращает её копию, у которой каждый n-ный элемент переведен в верхний регистр. n – задается на входе в функцию. Для определения каждого n-ного элемента понадобится остаток от деления %. Подумайте, как его можно использовать.

var text = "I never look back";
// Каждый третий элемент
App.MakeItFunny(text, 3); // "I NevEr LooK bAck"
*/

// Первое решение

class App
{
    public static string MakeItFunny(string str, int n)
    {
        // BEGIN (write your solution here)
        string result = "";
        int i = 0;
        while (i < str.Length)
        {
            if((i + 1) % n == 0 )
            {
                result += Char.ToUpper(str[i]);
                i++;
            }
            result += str[i];
            i++;
        }
        i++;
    
        return result;
        // END
    }
}
