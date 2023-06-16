/*
Реализуйте метод GetNumberExplanation(), который принимает на вход число и возвращает объяснение этого числа. Если для числа нет объяснения, то возвращается null:

App.GetNumberExplanation(8);   // null

// Объяснения есть только для указанных ниже чисел
App.GetNumberExplanation(666); // "devil number"
App.GetNumberExplanation(42);  // "answer for everything"
App.GetNumberExplanation(7);   // "prime number"
*/

class App
{
    // BEGIN (write your solution here)
    public static string GetNumberExplanation(int number) 
    {
        switch (number)
    {
    case 666:
        return "devil number";
    case 42:
        return "answer for everything";
    case 7:
        return "prime number";
    }
    return null;
    }
    // END
}
