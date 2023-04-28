/*
Вам даны три переменные с фамилиями разных людей. Составьте и выведите на экран слово из символов в таком порядке:

третий символ из первой строки;
второй символ из второй строки;
четвертый символ из третьей строки;
пятый символ из второй строки;
третий символ из второй строки.
Вывод результата должен быть примерно в таком виде:

a b c d e
*/

var one = "Naharis";
var two = "Mormont";
var three = "Sand";

// BEGIN (write your solution here)
var char1 = one[2];
var char2 = two[1];
var char3 = three[3];
var char4 = two[4];
var char5 = two[2];

Console.WriteLine($"{char1} {char2} {char3} {char4} {char5}");
// END
