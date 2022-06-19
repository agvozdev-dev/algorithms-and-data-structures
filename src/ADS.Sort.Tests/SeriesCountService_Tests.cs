using ADS.Sort.Generators;
using ADS.Sort.Services;

namespace ADS.Sort.Tests;

public class SeriesCountService_Tests
{
    [Fact]
    public void SeriesCountService_GetSeriesCount_Should_OneSeries_When_DirectOrderArray()
    {
        var seriesCountService = new SeriesCountService();
        var array              = new DirectOrderArrayGenerator().Generate(arraySize: 50);

        //---

        var seriesCount = seriesCountService.GetSeriesCount(array);

        //---

        Assert.Equal(1, seriesCount);
    }

    [Fact]
    public void SeriesCountService_GetSeriesCount_Should_NSeries_When_IndirectOrderArray()
    {
        var seriesCountService = new SeriesCountService();
        var array              = new IndirectOrderArrayGenerator().Generate(arraySize: 50);

        //---

        var seriesCount = seriesCountService.GetSeriesCount(array);

        //---

        Assert.Equal(array.Length, seriesCount);
    }

    [Fact]
    public void SeriesCountService_GetSeriesCount_Should_OneSeries_When_AllItemsAreEqual()
    {
        var seriesCountService = new SeriesCountService();

        //---

        var seriesCount = seriesCountService.GetSeriesCount(new[] { 1, 1, 1 });

        //---

        Assert.Equal(1, seriesCount);
    }
}