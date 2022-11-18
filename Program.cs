internal class Program
{
    private static void Main(string[] args)
    {
        double numero1;
        double numero2;
        string op;
        double numero3;
        Console.WriteLine("Insira o valor double para a primeira variavel");
        //Convertendo para um valor double
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o valor double para a segunda variavel");
        numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("insira a operação desejada +|-|X ou *|/");
        op = Console.ReadLine();
        if (op == "+")
        {
            numero3 = (numero1 + numero2);
            Console.WriteLine("A soma dos dois valores é igual a: " + numero3, 2f);
        }
        else if (op == "-")
        {
            numero3 = (numero1 - numero2);
            Console.WriteLine("A subtração dos dois valores é igual a: " + numero3, 2f);
        }
        else if (op == "x" || op == "*")
        {
            numero3 = (numero1 * numero2);
            Console.WriteLine("A multiplucação dos dois valores é igual a: " + numero3, 2f);
        }
        else if (op == "/" || op == "%")
        {
            numero3 = (numero1 / numero2);
            Console.WriteLine("A divisão dos dois valores é igual a: " + numero3, 2f);
        }
        else if (op == "%")
        {
            numero3 = (numero1 % numero2);
            Console.WriteLine("A divisão dos dois valores é igual a: " + numero3, 2f);
        }
       
        Console.ReadKey();
    }
}
    