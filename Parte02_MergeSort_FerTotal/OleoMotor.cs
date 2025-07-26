namespace MergeSort_OleosEInteiros;

public class OleoMotor
{
    public int Id { get; set; } = 0;
    public string Descricao { get; set; } = String.Empty;
    public int Valor { get; set; } = 0;

    public OleoMotor(int id, string descricao, int valor)
    {
        Id = id;
        Descricao = descricao;
        Valor = valor;
    }
    
    public OleoMotor(){}
    
    public List<OleoMotor> ListaOleos()
    {
      var listaOleos = new List<OleoMotor>();
      listaOleos.Add(new OleoMotor(1, "Shell", 16));
      listaOleos.Add(new OleoMotor(2, "Petrobras", 18));
      listaOleos.Add(new OleoMotor(3, "Ipiranga", 20));
      listaOleos.Add(new OleoMotor(4, "Total", 22));
      listaOleos.Add(new OleoMotor(5, "Texaco", 24));
      listaOleos.Add(new OleoMotor(6, "Lubrax", 24));
      listaOleos.Add(new OleoMotor(7, "Mobil", 26));
      listaOleos.Add(new OleoMotor(8, "Havoline", 28));
      listaOleos.Add(new OleoMotor(9, "Elf", 28));
      listaOleos.Add(new OleoMotor(10, "Castrol", 30));
      listaOleos.Add(new OleoMotor(11, "Valvoline", 32));
      listaOleos.Add(new OleoMotor(12, "Elaion", 34));
      listaOleos.Add(new OleoMotor(13, "ACDelco", 36));
      listaOleos.Add(new OleoMotor(14, "Selenia", 38));
      listaOleos.Add(new OleoMotor(15, "Petronas", 40));
      return listaOleos;
    }
    
    public override string ToString()
    {
        return $"{Descricao} - R${Valor}";
    }
}