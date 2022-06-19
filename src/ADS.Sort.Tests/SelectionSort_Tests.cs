using ADS.Sort.Algorithms;
using ADS.Sort.Generators;
using ADS.Sort.Services;

namespace ADS.Sort.Tests;

public class SelectionSort_Tests
{
    [Fact]
    public void SelectionSort_Sort_Should_Sorted_When_DirectOrderArray()
    {
        var array = new DirectOrderArrayGenerator().Generate(arraySize: 50);
        
        //---
        
        SelectionSort.Sort(array);
        var seriesCount = new SeriesCountService().GetSeriesCount(array);
        
        //---
        
        Assert.Equal(1, seriesCount);
    }
    
    [Fact]
    public void SelectionSort_Sort_Should_Sorted_When_IndirectOrderArray()
    {
        var array = new IndirectOrderArrayGenerator().Generate(arraySize: 50);
        
        //---
        
        SelectionSort.Sort(array);
        var seriesCount = new SeriesCountService().GetSeriesCount(array);
        
        //---
        
        Assert.Equal(1, seriesCount);
    }
    
    [Fact]
    public void SelectionSort_Sort_Should_Sorted_When_RandomArray()
    {
        var array = new RandomArrayGenerator().Generate(arraySize: 50);
        
        //---
        
        SelectionSort.Sort(array);
        var seriesCount = new SeriesCountService().GetSeriesCount(array);
        
        //---
        
        Assert.Equal(1, seriesCount);
    }
}