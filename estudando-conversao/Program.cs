namespace Program
{
  public class Program
  {

        // public static void ImplicitError()
    // {
    // {        
    //     long someLongNumber = 516144066604654;
    //     int intNumber = someLongNumber;
    //     Console.WriteLine(intNumber);
    // }  
    // }

    public static void Implicit()
    {
      {        
        int someIntNumber = 51;
        long longlNumberCast = someIntNumber;
        Console.WriteLine($" implicit {longlNumberCast}. Ocorre quando a conversão é viável. Pelo tipo (numero para número) e pela quantidade de bits (um long não pode ser imlicitamente convertido a um int, mesmo que seja um 'long' contendo um número pequeno");
        Console.WriteLine($" --------------------------------------------------------------------");
      }  
    }

    // public static void Implicit()
    // {
    //   {        
    //     long someIntNumber = 51;
    //     int longlNumberCast = someIntNumber;
    //     Console.WriteLine($" implicit {longlNumberCast}. Ocorre quando a conversão é viável. Pelo tipo e pela quantidade de bits");
    //   }  
    // }
    public static void ExplictNoWarning()
    {
      long someLongNumber = 516144564564654;
      int intNumber = (int) someLongNumber;

      Console.WriteLine($"(int) {intNumber}, perde os dados na conversão sem aviso. ????? O corte é feito na cadeia de bits ou como ???????");
      Console.WriteLine($" --------------------------------------------------------------------");
    }

    public static void ExplictWarningFail()
    {
      try
      {
        long someLongNumber = 516144564564654;
        int intNumber = Convert.ToInt32(someLongNumber);
  
        Console.WriteLine($"Conver.ToInt32 {intNumber}. Gera um erro e quebra o programa");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
      catch (System.Exception e)
      {
        Console.WriteLine($"Lança o erro: {e.Message}");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
    }

    public static void ExplictWarningSucess()
    {
      try
      {
        long someLongNumber = 5164;
        int intNumber = Convert.ToInt32(someLongNumber);
  
        Console.WriteLine($"Conver.ToInt32 {intNumber}. sucesso se a conversão não gerar perda de dados");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
      catch (System.Exception e)
      {
        Console.WriteLine($"Lança o erro: {e.Message}");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
    }

    
    public static void FloatInt()
    {
      float someFloatNumber = 2.55f;
      int intNumber = (int) 2.55;
      bool isGreater = someFloatNumber > intNumber;

      Console.WriteLine($"{someFloatNumber}");
      Console.WriteLine($"{intNumber}");
      Console.WriteLine($"{isGreater}");
      Console.WriteLine($" --------------------------------------------------------------------");
    }

        public static void StringToNumber()
    {
      try
      {
        string someStringNumber = "5164.d";
        int intNumber = Convert.ToInt32(someStringNumber); // a conversão não remove caracteres não numéricos. // Mesmo uma conversão para um double não permitiria a letra 'd' ao final do número (já que ela trabalha mais como um marcador para o copilados que como um caracter do numero double marcado).
  
        Console.WriteLine($"String: {someStringNumber}");
        Console.WriteLine($"Conver.ToInt32 {intNumber}. sucesso se a conversão não gerar perda de dados");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Lança o erro: {e.Message}");
        Console.WriteLine($" --------------------------------------------------------------------");
      }
    }

    public static void Main()
    {        
        Implicit();
        ExplictNoWarning();
        ExplictWarningFail();
        ExplictWarningSucess();
        FloatInt();
        StringToNumber();
    }            
  }
}
