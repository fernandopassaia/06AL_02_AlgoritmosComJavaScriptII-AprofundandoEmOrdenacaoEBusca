using MergeSort_OleosEInteiros;

public class Program
{
    public static void Main()
    {
        var oleosMotor = new OleoMotor().ListaOleos();
        List<int> numbers = new List<int> { 16, 11, 9, 17, 12, 3, 13, 4, 20, 7, 1, 10, 15, 18, 19, 5, 8, 2, 14, 6, 0  };

        var resultadoOleosOrdenados = new MergeSortHelper().Sort(oleosMotor);
        var resultadoNumbersOrdenados = new MergeSortHelper().Sort(numbers);
        
        Console.WriteLine(" ");
        Console.WriteLine("Lista de Oleos final ordenada:");
        foreach (var oleo in resultadoOleosOrdenados)
        {
            Console.WriteLine(oleo.ToString());
        }
        
        Console.WriteLine(" ");
        Console.WriteLine("Lista de Numbers final ordenada:");
        foreach (var number in resultadoNumbersOrdenados)
        {
            Console.WriteLine(number.ToString());
        }
    }
}