// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

namespace testando_conversao_e_input;

public class Program
{ 
  static string ProcessNumericEntry(string entry)
  {
    string entryWithNoComma = (entry.Replace(',', '.')).Replace(" ", "");
    string regexPattern = "[^0-9.]";
    return Regex.Replace(entryWithNoComma, regexPattern, "");
  }

  public static void Main()
  {
    Console.WriteLine("coloca um numero com uma letra aí, cara");
    decimal numDecimal = decimal.Parse(ProcessNumericEntry(Console.ReadLine()));
    Console.WriteLine($"tá aí, moral {numDecimal}");
  }
};