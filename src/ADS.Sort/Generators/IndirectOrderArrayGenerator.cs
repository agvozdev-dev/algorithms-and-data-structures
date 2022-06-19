namespace ADS.Sort.Generators;

/// <summary>Генератор массива с обратным порядком элементов</summary>
public class IndirectOrderArrayGenerator : IArrayGenerator
{
    public int[] Generate(int arraySize)
    {
        var array = new int[arraySize];

        var value = arraySize;
        for (var i = 0; i < arraySize; i++)
        {
            array[i] = value--;
        }
        
        return array;
    }
}