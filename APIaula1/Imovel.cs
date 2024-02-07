using System;

public class Imovel
{
    public Imovel(int id, string endereco, string tipo, decimal preco)
    {
        Id = id;
        Endereco = endereco;
        Tipo = tipo;
        Preco = preco;
    }

    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }


}
