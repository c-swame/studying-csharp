using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory(DisplayName = "Testa se o retorno da função \"Message.PrintMsg\" é a mesma string recebida como argumento")]
    [InlineData("Batata", "Batata")]
    [InlineData("Beterraba", "Beterraba")]
    [InlineData("Banana", "Banana")]
    [InlineData("Bola", "Bola")]
    [InlineData("Bolota", "Bolota")]

    public void TestPrintMsgSucess(string Send, string Expected)
    {
        using (var NewOutput = new StringWriter())
        {   
            Console.SetOut(NewOutput);

            Message.PrintMsg(Send);

            string result = NewOutput.ToString().Trim();
            
            result.Should().Be(Expected);      
        }
    }
}