namespace MergeSort_OleosEInteiros;

public class MergeSortHelper
{
    public List<OleoMotor> Sort(List<OleoMotor> list)
    {
        if (list.Count <= 1)
            return list;
        
        // quebro a lista no meio
        int meio = list.Count / 2;
        // uso recursão para o método se chamar até que a lista tenha só 2 elementos e seja ordenada
        var lista1 = list.GetRange(0, meio);
        var lista2 = list.GetRange(meio, list.Count - meio);
        
        var parte1Ordenada = OrdenaListas(lista1, lista2);
        return parte1Ordenada;
    }

    public List<int> Sort(List<int> list)
    {
        //verifico se a LIST já não tem um único valor, retorno ela
        if (list.Count <= 1)
            return list;
        
        // senão, quebro a lista no meio
        int meio = list.Count / 2;
        // uso recursão para o método se chamar até que a lista tenha só 2 elementos e seja ordenada
        var lista1 = Sort(list.GetRange(0, meio));
        var lista2 = Sort(list.GetRange(meio, list.Count - meio));
        
        var parte1Ordenada = OrdenaListas(lista1, lista2);
        return parte1Ordenada;
    }

    private List<OleoMotor> OrdenaListas(List<OleoMotor> list1, List<OleoMotor> list2)
    {
        var resultado = new List<OleoMotor>();
        int i1 = 0, i2 = 0;
        
        // percorro a lista 1 e 2 comparando valores e adicionando na ordem
        while (i1 < list1.Count && i2 < list2.Count)
        {
            if (list1[i1].Valor < list2[i2].Valor)
            {
                resultado.Add(list1[i1]);
                i1++;
            }
            else
            {
                resultado.Add(list2[i2]);
                i2++;
            }
        }

        // adiciono as sobras
        while (i1 < list1.Count)
        {
            resultado.Add(list1[i1]);
            i1++;
        }

        while (i2 < list2.Count)
        {
            resultado.Add(list2[i2]);
            i2++;
        }
        
        return resultado;
    }

    private List<int> OrdenaListas(List<int> list1, List<int> list2)
    {   
        var resultado = new List<int>();
        int i1 = 0, i2 = 0;

        while (i1 < list1.Count && i2 < list2.Count)
        {
            if (list1[i1] < list2[i2])
            {
                resultado.Add(list1[i1]);
                i1++;
            }
            else
            {
                resultado.Add(list2[i2]);
                i2++;
            }
        }

        while (i1 < list1.Count)
        {
            resultado.Add(list1[i1]);
            i1++;
        }

        while (i2 < list2.Count)
        {
            resultado.Add(list2[i2]);
            i2++;
        }

        return resultado;
    }
}