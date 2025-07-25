using System;
using System.Collections.Generic;

public class MergeSorter
{
    public static List<OleoMotor> MergeSort(List<OleoMotor> lista, int nivel = 0)
    {
        Console.WriteLine($"Nível de aninhamento: {nivel}");
        foreach (var oleo in lista)
        {
            Console.WriteLine(oleo.ToString());
        }
        Console.WriteLine("----------------------");

        if (lista.Count <= 1)
            return lista;

        int meio = lista.Count / 2;
        var parte1 = MergeSort(lista.GetRange(0, meio), nivel + 1);
        var parte2 = MergeSort(lista.GetRange(meio, lista.Count - meio), nivel + 1);

        return Ordena(parte1, parte2);
    }

    private static List<OleoMotor> Ordena(List<OleoMotor> parte1, List<OleoMotor> parte2)
    {
        Console.WriteLine("**** Função Ordena ****");
        var resultado = new List<OleoMotor>();
        int i = 0, j = 0;

        while (i < parte1.Count && j < parte2.Count)
        {
            if (parte1[i].Valor < parte2[j].Valor)
            {
                resultado.Add(parte1[i]);
                i++;
            }
            else
            {
                resultado.Add(parte2[j]);
                j++;
            }
        }

        while (i < parte1.Count)
        {
            resultado.Add(parte1[i]);
            i++;
        }

        while (j < parte2.Count)
        {
            resultado.Add(parte2[j]);
            j++;
        }

        Console.WriteLine("Resultado Ordena:");
        foreach (var oleo in resultado)
        {
            Console.WriteLine(oleo.ToString());
        }
        Console.WriteLine(" ");
        return resultado;
    }
}
