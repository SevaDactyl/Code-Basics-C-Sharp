/*
Реализуйте метод IsPensioner(), который принимает один параметр — возраст человека, и проверяет, является ли он пенсионным. Пенсионером считается человек, достигший возраста 60 лет и больше.

Примеры вызова:

App.IsPensioner(75); // true
App.IsPensioner(18); // false
*/

public class App
{
    // BEGIN (write your solution here)
    public static bool IsPensioner(int age) 
    {
        return age >= 60;
    }
    // END
}
Console.WriteLine(App.IsPensioner(21));
Console.WriteLine(App.IsPensioner(62));
Console.WriteLine(App.IsPensioner(67));
Console.WriteLine(App.IsPensioner(12));
