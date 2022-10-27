public abstract class Maquina
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Click { get; set; }
    public int Quantidade { get; set; }
    public virtual void BuyMachine(Game jogo)
    {
        if(IsAvaliable(jogo.Dinheiro))
        {
            this.Quantidade += 1;
            jogo.Dinheiro -= this.Preco;
            this.Preco += this.Preco/2.0;
            jogo.QuantidadeMaquinas += 1;
            jogo.Click += this.Click * this.Quantidade;
            Console.WriteLine($"VOCÊ COMPROU A MÁQUINA {this.Nome}!");
        }
        else Console.WriteLine($"VOCÊ NÃO TEM DINHEIRO SUFICIENTE PARA COMPRAR A MÁQUINA {this.Nome}");
    }
    public virtual bool IsAvaliable(double dinheiro)
    {
        return dinheiro >= this.Preco;
    }
}

public class Prensa : Maquina
{
    public Prensa()
    {
        this.Nome = "Prensa";
        this.Preco = 50;
        this.Click = 2;
        this.Quantidade = 0; 
    }
    
}
public class Escavadeira : Maquina
{
    public Escavadeira()
    {
        this.Nome = "Escavadeira";
        this.Preco = 200;
        this.Click = 6;
        this.Quantidade = 0;
    }
}
public class Perfuradora : Maquina
{
    public Perfuradora()
    {
        this.Nome = "Perfuradora";
        this.Preco = 600;
        this.Click = 10;
        this.Quantidade = 0;
    }
}