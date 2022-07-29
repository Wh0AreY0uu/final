string[] arr = new string[5] { "moby", "78", "hi", "try", "cry" };
string[] arr2 = new string[arr.Length];
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        arr2[index] = arr[i];
        index++;
    }
}

Console.Write("[ ");

for (int i = 0; i < arr2.Length; i++)
{
    Console.Write($"{arr2[i]} ");

}
Console.Write("]");

