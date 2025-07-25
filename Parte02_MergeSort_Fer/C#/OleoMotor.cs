public class OleoMotor
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public decimal Valor { get; set; }

    public OleoMotor(int id, string marca, decimal valor)
    {
        Id = id;
        Marca = marca;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"{Marca} - R${Valor}";
    }
}
