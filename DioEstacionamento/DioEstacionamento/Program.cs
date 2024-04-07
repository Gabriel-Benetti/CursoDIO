using System.Linq.Expressions;

namespace DioEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> placaEstacionado = new List<string>();
            string? placaDigitada;
            float valorDevido = 0.00F;
            bool condicao = true;

            Console.WriteLine("Digite o valor inicial cobrado");
            int valorInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da Hora");
            int valorHora = Convert.ToInt32(Console.ReadLine());

            while (condicao)
            {
                Console.WriteLine("MENU DE OPÇOES:");
                Console.WriteLine("1 - Cadastro de Veiculo");
                Console.WriteLine("2 - Remover Veiculo");
                Console.WriteLine("3 - Listar Veiculos");
                Console.WriteLine("4 - Encerrar");

                int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());


                switch (opcaoEscolhida)
                {

                    case 1:
                        Console.WriteLine("Digite a placa do veiculo");
                        placaDigitada = Console.ReadLine();
                        placaEstacionado.Add(placaDigitada);
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        Console.WriteLine("Digite a placa do veiculo a ser inserido");
                        placaDigitada = Console.ReadLine();
                        if (placaEstacionado.Contains(placaDigitada))
                        {

                            Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado");
                            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
                            valorDevido = valorInicial + (valorHora * horasEstacionado);
                            Console.WriteLine($"Valor para pagamento = R${valorDevido}");
                            Console.WriteLine("Veiculo removido com Sucesso");
                            placaEstacionado.Remove(placaDigitada);
                            

                        }
                        else
                        {
                            Console.WriteLine("Veiculo nao encontrado");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:

                        Console.WriteLine("Veiculos Estacionados:");
                        for (int i = 0; i < placaEstacionado.Count; i++)
                        {
                            Console.WriteLine($"{placaEstacionado[i]}");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:

                        Console.WriteLine("Programa encerrado");
                        condicao = false;

                        break;




                }

            }
        }
    }
}
