double EntradaInvestidor = 0;
double Implementacao;
int Meses;
int R = 0;
while (true) {
    try
    {
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
            break;
        }
    }
    catch
    {
        Console.WriteLine("O valor inserido não é um número, escreva novamente");
    }
}
Implementacao = EntradaInvestidor * (Math.Pow((1 + 0.07), Meses/12));

Console.WriteLine($"O valor de retiro é de R${Implementacao.ToString("N2")}");
Console.WriteLine($"E o juros acumulado foi de R${(Implementacao - EntradaInvestidor).ToString("N2")}");
