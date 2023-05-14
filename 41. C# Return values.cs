/*
Реализуйте статический метод GetCurrentYear() в классе App, который возвращает наружу текущий год в виде числа

var year = App.GetCurrentYear();
Console.WriteLine(year); // выведет текущий год
Для выполнения этого задания, вам понадобится выполнить несколько действий:

Получить текущую дату с помощью свойства DateTime.Now. Это свойство возвращает объект даты. В реальности у даты есть свойство Year, который выполняет нашу задачу. Но здесь мы хотим потренироваться
Преобразовать дату в строку с помощью метода ToString("yyyy-MM-dd"). В параметрах нужно указать желаемый формат строки: yyyy-mm-dd, например, 2021-11-05
Извлечь из нее год с помощью метода Substring()
Преобразовать год из строки в число с помощью метода Convert.ToInt32() и вернуть наружу
*/

class App
{
    // BEGIN (write your solution here)
    public static int GetCurrentYear()
    {
        var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        var currentYearAsString = currentDate.Substring(0, 4);
        var currentYear = Convert.ToInt32(currentYearAsString);
        return currentYear;
    }
    // END
}
