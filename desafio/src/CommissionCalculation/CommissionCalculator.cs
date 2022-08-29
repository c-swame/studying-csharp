using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
    static readonly decimal CommissionPerCarSold = 250;
    static readonly decimal ProfitSharingPercentage = 0.03M;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }
    public decimal ProfitSharingAmount { get; set; }

    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue) 
    {
        this.FixedSalary = fixedSalary;
        this.AmountCarsSold = amountCarsSold;
        this.TotalSalesValue = totalSalesValue;
        this.ProfitSharingAmount = (this.TotalSalesValue * ProfitSharingPercentage);
        this.FinalSalary = (FixedSalary + (AmountCarsSold * CommissionPerCarSold) + this.ProfitSharingAmount);
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
        string paymentData = (
            $"O colaborador {contributorName} neste mês de {month} obteve o salário final de R${this.FinalSalary:N2} referente à: " +
            $"SALARIO FIXO: R${this.FixedSalary:N2} " +
            $"TOTAL DE CARROS VENDIDOS: {this.AmountCarsSold} " +
            $"VALOR TOTAL DE VENDAS NO MES: R${this.TotalSalesValue:N2} " +
            $"COMISSÃO POR CARROS VENDIDOS: R${(this.AmountCarsSold * CommissionPerCarSold):N2} " +
            $"COMISSÃO DE 3% DO TOTAL DE VENDAS: R${this.ProfitSharingAmount:N2}"
        );

        Console.WriteLine(paymentData);

        // return paymentData;
    }
}
