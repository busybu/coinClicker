public class Game
{   
    public double Dinheiro { get; set; }
    public int Click { get; set; }
    public int QuantidadeMaquinas { get; set; }
    public List<Maquina> Maquinas {get; set;} 
    public Game()
    {
        Maquinas = new List<Maquina>();
        Maquinas.Add(new Prensa());
        Maquinas.Add(new Escavadeira());
        Maquinas.Add(new Perfuradora());
        Dinheiro = 0;
        Click = 1;
        QuantidadeMaquinas = 0;
    }
    public void PrintGame()
    {
        Console.WriteLine("-------JOGO CLICKER-------");
        Console.WriteLine("0 = PRODUZIR -------------");
        Console.WriteLine("1 = COMPRAR MÁQUINA ------");
        Console.WriteLine("\nTOTAL DE MOEDAS:"+ this.Dinheiro);
    }
    public virtual void GetClick()
    {
        Console.WriteLine("Digite a opção escolhida:");
        if (Console.ReadKey(true).Key == ConsoleKey.D0){
            AddClick();
        }
        else if(Console.ReadKey(true).Key == ConsoleKey.D1){
            Console.WriteLine("**********MÁQUINAS**********");
            Console.WriteLine($"-----VOCÊ TEM {this.QuantidadeMaquinas} MÁQUINAS-----\n");
            for (int i = 0; i < Maquinas.Count ; i++)
            Console.WriteLine($"{i} - {this.Maquinas[i].Nome} {this.Maquinas[i].Preco} CLICKS\nQUANTIDADE: {this.Maquinas[i].Quantidade}\n");
            Console.WriteLine("\n TOTAL DE MOEDAS:"+ this.Dinheiro);
            Console.WriteLine($"DESEJA COMPRAR?(S/N):");
            if(Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.WriteLine($"INSIRA O NÚMERO DA MÁQUINA QUE DESEJA COMPRAR:");
                int compra = int.Parse(Console.ReadLine());
                Maquinas[compra].BuyMachine(this);
            }
        }
    }
    public void AddClick()
    {
        this.Dinheiro += this.Click;
    }
}