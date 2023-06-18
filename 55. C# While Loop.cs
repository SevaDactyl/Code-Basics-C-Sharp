/*
Модифицируйте метод PrintNumbers() так, чтобы она выводила числа в обратном порядке. Для этого нужно идти от верхней границы к нижней. То есть счётчик должен быть инициализирован максимальным значением, а в теле цикла его нужно уменьшать до нижней границы.

Пример вызова и вывода:

App.PrintNumbers(4);
  4
3
2
1
finished!
*/

class App
{
    // BEGIN (write your solution here)
    public static void PrintNumbers(int firstNumber)
    {
        var i = firstNumber;
        while (i >= 1)
        {
            Console.WriteLine(i);
            i = i - 1;
        }
        Console.WriteLine("finished!");
    }
    // END
}