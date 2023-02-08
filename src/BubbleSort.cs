public class BubbleSort : ISort
{
    public int[] Sort(int[] arr)
    {
        var tam = arr.Length;
        var mudou = false;

        do
        {
            mudou = false;
            for (int i = 0; i < tam - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    mudou = true;
                    arr = Swap(arr, i, i + 1);
                }
            }
        } while (mudou);
        return arr;
    }

    int[] Swap(int[] arr, int a, int b)
    {
        var temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;

        return arr;
    }
}

