//Задача 1
void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxIndex]) maxIndex = j;
        }
        int temp = arr[maxIndex];
        arr[maxIndex] = arr[i];
        arr[i] = temp;
    }
}
int[] arr = new int[10];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(1, 1000);
SelectionSort(arr);
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
Console.WriteLine();
//Задача 2
    EvenSort(arr);
    Console.WriteLine("Массив после сортировки четных чисел в начале:");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    Console.WriteLine();
static void EvenSort(int[] arr)
{
    int n = arr.Length;
    int evenIndex = 0; 
    for (int i = 0; i < n; i++)
    {
        if (arr[i] % 2 == 0)
        {
            int temp = arr[i];
            arr[i] = arr[evenIndex];
            arr[evenIndex] = temp;
            evenIndex++;
        }
    }
}

