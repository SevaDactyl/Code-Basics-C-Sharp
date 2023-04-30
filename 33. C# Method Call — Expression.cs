/*
Выведите на экран первую и последнюю буквы предложения, записанного в переменную text, в следующем формате:

First: N
Last: t
Ваша задача извлечь эти символы из строки и вставить в Console.WriteLine(), не используя промежуточные переменные.
*/

var text = "Never forget what you are, for surely the world will not";

// BEGIN (write your solution here)
var result = $"First: {text[0]}\nLast: {text[text.Length - 1]}";

Console.WriteLine(result);
// END
