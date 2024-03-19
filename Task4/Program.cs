// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

string str = "Lorem ipsum dolor sit amet";
string trimmedStr = str.Trim();
int count = 0; 
int k = 0;

for(int i = 0; i < trimmedStr.Length; i++)
{
    if(trimmedStr[i] == ' ')
    {
        count += 1;
    }
}

int[] arrOfIndexes = new int[count];
string[] newArr = new string[count + 1];
string word = "";
bool ifEndStr = false;

for(int i = 0; i < trimmedStr.Length; i++)
{
    for(int j = 0; j < arrOfIndexes.Length; j++)
    {
        if(trimmedStr[i] == ' ')
        {
            arrOfIndexes[j] = i;
        }
    }
}

for(int i = 0; i < trimmedStr.Length; i++)
{
    word += trimmedStr[i];
    for(int j = 0; j < arrOfIndexes.Length; j++)
    {
        if(i == arrOfIndexes[j])
        { 
            ifEndStr = true;
        }

        if(ifEndStr)
        {
            newArr[k] = word;
            k++;
                        i++;

            break;
        }

}

for(int i = newArr.Length - 1; i >= 0; i--)
{
    Console.Write($"{newArr[i]} ");
}

 