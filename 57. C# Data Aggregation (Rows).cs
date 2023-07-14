/* 
Реализуйте метод JoinNumbersFromRange() в классе App, который объединяет все числа из диапазона в строку:

App.JoinNumbersFromRange(1, 1); // "1"
App.JoinNumbersFromRange(2, 3); // "23"
App.JoinNumbersFromRange(5, 10); // "5678910"
Для решения вам может понадобиться метод ToString(), чтобы превратить одиночное число в строку. Например:

var number = 1;
number.ToString(); // "1" 
*/

// Первое решение

class App
{
    public static String JoinNumbersFromRange(int start, int finish)
    {
        // BEGIN (write your solution here)
        string result = "";

        while (start <= finish) 
        {
            result += start.ToString();
            start ++;
        }
        return result;
        // END
    }
}

// Второе решение

class App
{
    public static String JoinNumbersFromRange(int start, int finish)
    {
        // BEGIN (write your solution here)
        var i = start;
        var result = "";

        while (i <= finish)
        {
            result = result + i;
            i = i + 1;
        }

        return result;
        // END
    }
}
