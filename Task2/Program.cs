// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string str = "KoNsTaNtIn ThE GrEaT";
string newStr = "";

for(int i = 0; i < str.Length; i++)
{
    newStr += char.ToLower(str[i]);
}

Console.WriteLine(newStr);