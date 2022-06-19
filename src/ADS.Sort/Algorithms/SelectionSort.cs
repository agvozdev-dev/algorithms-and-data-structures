namespace ADS.Sort.Algorithms;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var minIndex = i;
            
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[minIndex] > array[j])
                {
                    minIndex = j;
                }
            }

            Swap(array, i, minIndex);
        }
    }

    private static void Swap(int[] array, int currentIndex, int minIndex)
    {
        (array[currentIndex], array[minIndex]) = (array[minIndex], array[currentIndex]);
    }
}