string[] FindLenght(string[] input)
{
    string[] output = new string[CountArray(input)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= 3)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountArray(string[] input)
{
    int count = 0;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] Array()
{
    Console.Write("Введите значения через запятую: ");
    return Console.ReadLine().Split(",");
}

string[] array = Array();
string[] result = FindLenght(array);
Console.WriteLine($"[{string.Join(", ", array)}] ---> [{string.Join(", ", result)}]");