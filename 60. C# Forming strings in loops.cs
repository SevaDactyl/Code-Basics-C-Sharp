/* 
Реализуйте такой же метод Reverse(), но выполняющий обход строки не с первого элемента по последний, а наоборот, от последнего к первому. Общая структура функции при этом останется такой же. Изменится начальный индекс, условие окончания цикла, сборка новой строки и формирование нового индекса в цикле.
*/

// Первое решение

class App
{
    public static string Reverse(string str)
    {
        // BEGIN (write your solution here)
        var i = 0;
        var result = "";
        while(i < str.Length) 
        {
            result = str[i] + result;
            i += 1;
        }
        return result;
        // END
    }
}

// Второе решение

class App
{
    public static string Reverse(string str)
    {
        // BEGIN (write your solution here)
        var i = str.Length - 1;
        var result = "";
        while (i >= 0)
        {
            result = result + str[i];
            i = i - 1;
        }

        return result;
        // END
    }
}
