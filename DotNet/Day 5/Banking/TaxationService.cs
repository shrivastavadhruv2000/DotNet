using System.Runtime.CompilerServices;

namespace taxation;

public static class TaxationService{
    public static void PayIncomeTax(float amount){
        Console.WriteLine("Income Tax:"+ amount + "is deducted from your account");
    }

    public static void PaysalesTax(float amount){
        Console.WriteLine("Sales Tax:"+ (amount +2000)+ "is deducted from your account");
    }

    public static void PayServiceTax(float amount){
        Console.WriteLine("Service Tax:"+ (amount+1000) + "is deducted from your account");
    }

    public static void PayGSTTax(float amount){
        Console.WriteLine("GST Tax:"+ (amount+4000) + "is deducted from your account");
    }
}