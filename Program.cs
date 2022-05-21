int length = 5;
int[] array = new int[length];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < length; i++) 
{
    array[i] = rnd.Next(1, 100);
    if (i % 2 != 0) 
        sum += array[i];
        Console.Write(array[i] + "  ");
        
}
Console.WriteLine(sum);
