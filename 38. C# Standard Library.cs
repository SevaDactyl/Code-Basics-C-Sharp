/*
В названии войны в Семи Королевствах вкралась опечатка: пропущено слово "Five". Попробуйте самостоятельно найти в документации к языку нужный метод, которым можно вставить одну строку в другую. Результат должен получится таким:

War of the Five Kings
*/

var war = "War of the Kings";
var missingWord = "Five ";

// BEGIN (write your solution here)
var kingWordIndex = war.IndexOf('K');
Console.WriteLine(war.Insert(kingWordIndex, missingWord));
// END
