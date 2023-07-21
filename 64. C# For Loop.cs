/* 
Сэмвелл обнаружил, что его сообщения перехватываются в замке «Близнецы» и там читаются. Из-за этого их атаки перестали быть внезапными. Немного подумав, он разработал программу, которая бы шифровала сообщения по следующему алгоритму. Она бы брала текст и переставляла в нем каждые два подряд идущих символа.

Encrypt("move"); // "omev"
Encrypt("attack"); // "taatkc"
// Если число символов нечётное
// то последний символ остается на своем месте
Encrypt("go!"); // "og!"
Реализуйте статический метод Encrypt() в классе App, который принимает на вход исходное сообщение и возвращает зашифрованное.
*/

// Первое решение

class App
{
    public static string Encrypt(string str)
    {
        // BEGIN (write your solution here)
        var result = "";
        for (int i = 0; i < str.Length - 1; i += 2)
        {
            result = result + str[i + 1] + str[i];
        }

        if (str.Length % 2 != 0)
        {
            result = result + str[str.Length - 1];
        }
    return result;
        // END
    }
}

// Второе решение

class App
{
    public static string Encrypt(string str)
    {
        // BEGIN (write your solution here)
        var result = "";
        for (var i = 0; i < str.Length; i += 2)
        {
            if (i == str.Length - 1)
            {
                result += str[i];
            }
            else
            {
                var firstChar = str[i];
                var secondChar = str[i + 1];
                result = result + secondChar +  firstChar;
            }
        }

        return result;
        // END
    }
}
