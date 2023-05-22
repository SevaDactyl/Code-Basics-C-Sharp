/*
Реализуйте метод IsInternationalPhone(), который проверяет формат указанного телефона. Если телефон начинается с +, значит это международный формат.

App.IsInternationalPhone("89602223423"); // false
App.IsInternationalPhone("+79602223423"); // true
*/

// Первое решение

class App
{
    // BEGIN (write your solution here)
    public static bool IsInternationalPhone(string number) 
    {
        var firstSymbol = number.Substring(0, 1);
        return firstSymbol == "+";
    }
    // END
}

// Второе решение

class App
{
    // BEGIN (write your solution here)
    public static bool IsInternationalPhone(string phone)
    {
        return phone[0] == '+';
    }
    // END
}
