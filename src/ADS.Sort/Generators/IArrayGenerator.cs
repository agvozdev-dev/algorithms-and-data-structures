namespace ADS.Sort.Generators;

/// <summary>Генератор массива</summary>
public interface IArrayGenerator
{
    /// <summary>Сгенерировать массив</summary>
    /// <param name="arraySize">Размер массива</param>
    /// <returns>Сгенерированный массив</returns>
    int[] Generate(int arraySize);
}