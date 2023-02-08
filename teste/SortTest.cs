using Xunit;

namespace teste;

public class SortTest
{
    [Fact]
    public void Selection()
    {
        var arr = new int[]{3, 5, 2, 8, 1, 9, 4};
        var selection = new SelectionSort();
        arr = selection.Sort(arr);
        for(int i = 0; i < arr.Length - 1; i++)
        {
            Assert.True(arr[i] < arr[i+1]);
        }        
    }
}