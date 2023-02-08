public class SelectionSort
{
    public int[] Sort(int[] arr)
    {  
        var n = arr.Length;
        var i = 0;

        for( ; i < n-1; i++)
        {
            var min_index = i;
            var j = i + 1;

            for(  ; j < n; j++)
            {
                if(arr[j] < arr[min_index])
                {
                    min_index = j;
                }
            }

            arr = Swap(arr, min_index, i);

        }
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