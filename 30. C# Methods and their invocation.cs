/*
В коде определена переменная с именем. Используя методы ToUpper() и ToLower() у этой переменной определите две новые переменные, чтобы на экран вывелась фраза:

HODOR says: "hodor"
*/

var name = "Hodor";

// BEGIN (write your solution here)
var who = name.ToUpper();
var what = name.ToLower();
// END

Console.WriteLine($"{who} says: \"{what}\"");
