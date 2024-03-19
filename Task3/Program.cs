// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
string str = "А роза упала на лапу Азора";
string stringWithoutSpaces = str.Replace(" ", "");
string newStr = "";
string backStr = "";

for(int i = 0; i < stringWithoutSpaces.Length; i++)
{
    newStr += char.ToLower(stringWithoutSpaces[i]);
}

for(int i = stringWithoutSpaces.Length - 1; i >= 0; i--)
{
    backStr += char.ToLower(stringWithoutSpaces[i]);
}

if(newStr == backStr)
{
    Console.WriteLine("Да! Этот текст полиндром!");
}
else 
{
    Console.WriteLine("Нет! Этот текст не полиндром!");
}

