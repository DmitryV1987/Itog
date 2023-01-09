string[] input = { "1234", "1567", "-2", "computer science" };
string[] output = new string[input.Length];
int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[count] = input[i];
        count++;
    }
}

string[] result = new string[count];
Array.Copy(output, result, count);
Console.WriteLine(result);
