public class Program
{
    public static void Main()
    {
        var oleosMotor = new List<OleoMotor>
        {
            new OleoMotor(1, "Shell", 16),
            new OleoMotor(2, "Mobil", 22),
            new OleoMotor(3, "Petrobras", 18),
            new OleoMotor(4, "Ipiranga", 15),
            new OleoMotor(5, "Texaco", 20),
            new OleoMotor(6, "Castrol", 25),
            new OleoMotor(7, "Lubrax", 20),
            new OleoMotor(8, "Valvoline", 28),
            new OleoMotor(9, "Total", 17),
            new OleoMotor(10, "Elf", 23)
        };

        var resultado = MergeSorter.MergeSort(oleosMotor);

        Console.WriteLine("Lista final ordenada:");
        foreach (var oleo in resultado)
        {
            Console.WriteLine(oleo.ToString());
        }
    }
}
