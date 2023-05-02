/*
Напишите код, который берет данные из переменной name и выполняет капитализацию, в программировании так называют операцию, которая делает заглавной первую букву в слове, а все остальные переводит в нижний регистр. Например: heXlet => Hexlet.

Для извлечения частей слова, воспользуйтесь методом Substring():

// 1 параметр – индекс, 2 – длина извлекаемой подстроки
"hexlet".Substring(0, 1); // "h"
// По умолчанию до конца строки
"hexlet".Substring(1); // "exlet"
*/

var name = "hexlet";

// BEGIN (write your solution here)
var capitalized = name.Substring(0, 1).ToUpper()
    + name.Substring(1).ToLower();
Console.WriteLine(capitalized);
// END
