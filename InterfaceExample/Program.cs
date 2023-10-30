Console.WriteLine("Interface!");

SamsungPrinter samsungPrinter = new();
samsungPrinter.PrintPage();

HpPrinter hpPrinter = new();
hpPrinter.PrintPage();


interface IPrinter
{
    void PrintPage();
}

class SamsungPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("Print in Black and White");
    }
}

class HpPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("Printing in Color");
    }
}

