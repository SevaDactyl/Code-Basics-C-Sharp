/*
Реализуйте статический метод Truncate(), который обрезает переданный текст до указанного количества символов, добавляет в конце троеточие и возвращает получившуюся строку. Подобная логика часто используется на сайтах, чтобы отобразить длинный текст в сокращенном виде. Метод принимает два параметра:

Строка, которую нужно обрезать
Число символов, которые нужно оставить
// Передаём текст напрямую
// Обрезаем текст, оставляя 2 символа
App.Truncate("hexlet", 2); // "he..."

// Через переменную
var text = "it works!";
// Обрезаем текст, оставляя 4 символа
var result = App.Truncate(text, 4);
Console.WriteLine(result); // => "it w..."
Реализовать этот метод можно различными способами, подскажем лишь один из них. Для решения этим способом вам понадобится взять подстроку из строки, переданной первым параметром в метод. Используйте для этого метод Substring(). Подумайте, исходя из задания, с какого индекса и какой длины вам надо извлечь подстроку?

  var word = "welcome";
  // Передавать параметры в метод можно через переменные
  var length = 3;
  word.Substring(0, length); // "wel"
С точки зрения проверочной системы не имеет значения, каким из способов будет реализован метод Truncate() внутри, главное – чтобы он выполнял поставленную задачу
*/

class App
{
    public static string Truncate(string str, int count)
    {
        // BEGIN (write your solution here)
        return $"{str.Substring(0, count)}...";
        // END
    }
}
