namespace ADS.Sort.Services;

/// <summary>Сервис подсчета количества серий</summary>
public class SeriesCountService
{
    public int GetSeriesCount(int[] array)
    {
        var seriesCounter = 1;
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] <= array[i + 1])
            {
                continue;
            }

            seriesCounter++;
        }

        return seriesCounter;
    }
}