namespace projeto2.Test;

public class UnitTest1
{
    // public static int Sum(int number1, int number2) 

    // {

    //     var result = number1 + number2;

    //     return result;

    // }
    [Fact]
    public void Test1()
    {
        var entryPoint = typeof(Program).Assembly.EntryPoint!;
        entryPoint.Invoke(null, new object[] { Array.Empty<string>() }); 
        // var result = Sum(77, 33);

        // result.Should().Be(110);
    }
}