int[] arr= new int[20];
arr[0] = 0;
arr[1] = 1;
for (int i = 1; i < arr.Length-1; i++)
{
    arr[i+1] = arr[i] + arr[i-1];
}
foreach (int i in arr)
{
    Console.Write( i );
    Console.Write(" ");
}