List<string> Clientes = new List<string>();
double EntradaInvestidor, Implementacao = 0;
string nome = "";
int qtdInvest = 100;
int Meses, Q, idade = 0;
while (Q != qtdInvest) {
    try
    {
        int R = 0;
        if (Q == 0)
        {
            Console.WriteLine("Adicione a quantidade de investidores");
            qtdInvest = Convert.ToInt32(Console.ReadLine());
        }

        while (true)
        {
            if (R == 0)
            {
                Console.WriteLine("Escreva seu nome:");
                nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Qual sua idade?");
                idade = Convert.ToInt32(Console.ReadLine());
            }

            if (R == 0)
            {
                Console.WriteLine("Insira o valor");
                EntradaInvestidor = Convert.ToDouble(Console.ReadLine());
                R++;
            }
            else
            {
                Console.WriteLine("Insira a quantidade de meses");
                Meses = Convert.ToInt32(Console.ReadLine());
                Implementacao = EntradaInvestidor * (Math.Pow((1 + 0.07), Meses / 12));
                Clientes.Add($"O Cliente {nome} que possui {idade} recebeu R${Implementacao} em Juros");
                break;
            }
        }
        Q++;
    }
    catch
    {
        Console.WriteLine("O valor inserido não é um número, escreva novamente");
    }
}

Clientes.ToList().ForEach(x => Console.WriteLine(x));

