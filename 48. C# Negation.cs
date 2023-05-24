/*
Реализуйте метод IsNotLannisterSoldier() в классе App, который проверяет, что солдат — не Ланнистер. Функция принимает на вход 2 аргумента:

Цвет доспехов (строка). Например, строку "red", если доспехи красные.
Изображение на щите. Например, строку "lion", если щит с изображением льва. Если щита нет, то будет передан null.
Вам доступна уже готовая функция IsLannisterSoldier(). Воспользуйтесь ей, чтобы не писать все логические условия заново.

Условия распознавания Ланнистера описаны в прошлом уроке.

Примеры вызова:

App.IsNotLannisterSoldier('red', 'lion'); // false
App.IsNotLannisterSoldier('blue', null);  // true
*/

class App
{
    public static bool IsLannisterSoldier(string color, string shield)
    {
        return (color == "red" && shield == null) || shield == "lion";
    }
    
    // BEGIN (write your solution here)
    public static bool IsNotLannisterSoldier(string color, string shield) 
    {
        return !IsLannisterSoldier(color, shield);
    }
    // END
}
App.IsNotLannisterSoldier("red", "lion");
App.IsNotLannisterSoldier("blue", null);
