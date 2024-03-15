Console.WriteLine("Please start inserting arrays:\n");

Console.WriteLine("Number of arrays:");
int array_num = int.Parse(Console.ReadLine());

int[] multipliers = new int[array_num];

for(int i = 0; i < array_num; i++)
{
    Console.WriteLine($"\nLength of array {i + 1}:");
    int array_len = int.Parse(Console.ReadLine());

    int[] array = new int[array_len];

    Console.WriteLine($"\nArray elements:");
    for (int e = 0; e < array_len; e++)
    { 
        array[e] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nArray: ");
    for(int e = 0; e < array_len; e++)
    {
        Console.Write(array[e] + " ");
    }
    Console.WriteLine();

    multipliers[i] = array[i];

    Console.WriteLine("\nMultipliers: ");
    for (int j = 0; j < multipliers.Length; j++)
    {
        Console.Write(multipliers[j] + " ");
    }
    Console.WriteLine();

    int product = 1;
    foreach (int multiplier in multipliers)
    {
        product *= multiplier;
    }
    Console.WriteLine($"\nProduct: {product}");
}
