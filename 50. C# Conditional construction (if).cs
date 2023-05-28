/*
Реализуйте метод GetSentenceTone(), который принимает строку и определяет тон предложения. Если все символы в верхнем регистре, то это вопль — scream. В ином случае — нормальное предложение — normal.

Примеры вызова:

App.GetSentenceTone("Hello"); // "normal"
App.GetSentenceTone("WOW");  // "scream"
Алгоритм:

Сгенерируйте строку в верхнем регистре на основе строки-аргумента с помощью метода ToUpper().
Сравните её с исходной строкой:
Если строки равны, значит, строка-аргумент в верхнем регистре
В ином случае — строка-аргумент не в верхнем регистре
*/

class App
{
    // BEGIN (write your solution here)
    public static string GetSentenceTone(string tone) 
    {
        if (tone != tone.ToUpper()) 
        {
            return "normal";
        }
        return "scream";
    }
    // END
}
