/*
На электронной карте Вестероса, которую реализовал Сэм, союзники Старков отображены зеленым кружком, враги — красным, а нейтральные семьи — серым.

Напишите для Сэма метод WhoIsThisHouseToStarks(), который принимает на вход фамилию семьи и возвращает одно из трех значений: "friend", "enemy", "neutral".

Правила определения:

Друзья ("friend"): "Karstark", "Tally"
Враги ("enemy"): "Lannister", "Frey"
Любые другие семьи считаются нейтральными
Примеры вызова:

App.WhoIsThisHouseToStarks("Karstark"); // "friend"
App.WhoIsThisHouseToStarks("Frey");     // "enemy"
App.WhoIsThisHouseToStarks("Joar");     // "neutral"
App.WhoIsThisHouseToStarks("Ivanov");   // "neutral"
*/

// Первое решение

class App
{
    // BEGIN (write your solution here)
    public static string WhoIsThisHouseToStarks(string houseName) 
    {
        if (houseName == "Karstark" || houseName == "Tally")
        {
            return "friend";
        }
        else if (houseName == "Lannister" || houseName == "Frey") 
        {
            return "enemy";
        }
        return "neutral";
    }
    // END
}

// Второе решение

class App
{
    // BEGIN (write your solution here)
    public static string WhoIsThisHouseToStarks(string houseName)
    {
        if (houseName == "Karstark" || houseName == "Tally")
        {
            return "friend";
        }
        else if (houseName == "Lannister" || houseName == "Frey")
        {
            return "enemy";
        }

        return "neutral";
    }
    // END
}
