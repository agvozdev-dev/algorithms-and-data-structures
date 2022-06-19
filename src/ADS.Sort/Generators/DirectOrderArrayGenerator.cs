namespace ADS.Sort.Generators;

/// <summary>Генератор массива с прямым порядком элементов</summary>
public class DirectOrderArrayGenerator : IArrayGenerator
{
    public int[] Generate(int arraySize)
    {
        var array = new int[arraySize];

        for (var i = 0; i < arraySize; i++)
        {
            array[i] = i;
        }
        
        return array;
    }
}