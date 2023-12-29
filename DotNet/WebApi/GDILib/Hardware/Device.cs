namespace Hardware;

public class HPPrinter:IPrinter,IScanner{
    public void Print(){
        Console.WriteLine("Printer Started...dac19");
    }
    public void Scan(){
        Console.WriteLine("Scanning is Started...dac19");
    }
}