/*
Напишите метод IsMister(), которая принимает строку и проверяет, является ли она словом "Mister".

Примеры вызова:

App.IsMister("Mister"); // true
App.IsMister("Miss");   // false
*/

public class App
{
    // BEGIN (write your solution here)
    public static bool IsMister(string right) 
    {
        return right == "Mister";
    }
    // END
}
App.IsMister("Mister");
App.IsMister("Miss");
