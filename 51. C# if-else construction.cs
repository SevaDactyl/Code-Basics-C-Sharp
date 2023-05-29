/*
Реализуйте метод NormalizeUrl(), который выполняет так называемую нормализацию данных. Он принимает адрес сайта и возвращает его с https:// в начале.

Метод принимает адреса в виде АДРЕС или https://АДРЕС, но всегда возвращает адрес в виде https://АДРЕС

Можно использовать метод StartsWith() чтобы проверить начинается ли строка с префикса https://. А потом на основе этого добавлять или не добавлять https://.

App.NormalizeUrl("google.com"); // "https://google.com"
App.NormalizeUrl("https://ai.fi"); // "https://ai.fi"
*/

class App
{
    // BEGIN (write your solution here)
    public static string NormalizeUrl(string url) 
    {
        if (url.StartsWith("https://")) 
        {
            return url;
        } else 
        {
            return ("https://" + url);
        }
    }
    // END
}
