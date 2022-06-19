namespace ADS.Sort.Generators;

/// <summary>Генератор массива случайных чисел</summary>
public class RandomArrayGenerator : IArrayGenerator
{
    private static readonly Random _random = new();
    
    public int[] Generate(int arraySize)
    {
        var array = new int[arraySize];
        
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = _random.Next(arraySize);
        }

        return array;
    }
}