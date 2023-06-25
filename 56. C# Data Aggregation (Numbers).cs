/*
Реализуйте функцию multiply_numbers_from_range(), которая перемножает числа в указанном диапазоне включая границы диапазона. Пример вызова:

multiply_numbers_from_range(1, 5)  # 1 * 2 * 3 * 4 * 5 = 120
multiply_numbers_from_range(2, 3)  # 2 * 3 = 6
multiply_numbers_from_range(6, 6)  # 6
*/

// Первое решение

class App
{
    public static int MultiplyNumbersFromRange(int start, int finish)
    {
        // BEGIN (write your solution here)
        var i = start;
        var result = 1;
        while (i <= finish) 
        {
            result = result * i;
            i += 1;
        }
        return result;
        // END
    }
}

// Второе решение

class App
{
    public static int MultiplyNumbersFromRange(int start, int finish)
    {
        // BEGIN
        var i = start;
        var result = 1;

        while (i <= finish)
        {
            result = result * i;
            i = i + 1;
        }

        return result;
        // END
    }
}
