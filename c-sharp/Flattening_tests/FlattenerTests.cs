using Flattening;

namespace Flattening_tests;

public class FlattenerTests
{
    
    private readonly Flattener _flattener = new();

    [Fact]
    public void TestWithProvidedExample()
    {
        object[] nested1 =
        [
            new object[] { "one", "Two", new object[] { "Three" }, },
            "Four"
        ];
            
        var flat = Flattener.Flatten(nested1);
        Assert.Equal("one, Two, Three, Four", string.Join(", ", flat));
    }
    
    [Fact]
    public void TestWithComplexNestedArray()
    {
        object[] nested1 =
        [
            new object[] { "one", "Two", new object[] { "Three", new object[] { "Four", "Five" } }, },
            "Six"
        ];
            
        var flat = Flattener.Flatten(nested1);
        Assert.Equal("one, Two, Three, Four, Five, Six", string.Join(", ", flat));
    }
    
    [Fact]
    public void TestWithEmptyArray()
    {
        object[] nested1 = new object[] { };
            
        var flat = Flattener.Flatten(nested1);
        Assert.Equal("", string.Join(", ", flat));
    }
    
    [Fact]
    public void TestWithEmptyNestedArray()
    {
        object[] nested1 = new object[] { new object[] { } };
            
        var flat = Flattener.Flatten(nested1);
        Assert.Equal("", string.Join(", ", flat));
    }

}