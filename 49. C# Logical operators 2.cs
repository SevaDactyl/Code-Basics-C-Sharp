/*
Напишите метод IsNeutralSoldier(), который принимает на вход два аргумента:

Цвет доспехов (строка). Возможные варианты: red, yellow, black.
Цвет щита (строка). Возможные варианты: red, yellow, black.
Функция возвращает true, если цвет доспехов не красный и цвет щита чёрный. В остальных случаях возвращает false.

Примеры вызова:

App.IsNeutralSoldier("yellow", "black"); // true
App.IsNeutralSoldier("red", "black");    // false
App.IsNeutralSoldier("red", "red");      // false
*/

// Первое решение

class App
{
    // BEGIN (write your solution here)
    public static bool IsNeutralSoldier(string color, string shield) 
    {
        if (color != "red" && shield == "black") 
        {
            return true;
        } else 
        {
            return false;
        }
    }
    // END
}

// Второе решение

class App
{
    // BEGIN (write your solution here)
    public static bool IsNeutralSoldier(string armorColor, string shieldColor)
    {
        return armorColor != "red" && shieldColor == "black";
    }
    // END
}

// Третье решение

class App
{
// BEGIN (write your solution here)
	public static bool IsNeutralSoldier(string equipmentsColor, string shieldColor)
	{
		return equipmentsColor != "red" && shieldColor == "black";
	}
// END
}
