using Newtonsoft.Json;
using Serializacao.Models;

namespace Serializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendas v1 = new Vendas(1,"Carteira", 150.00M);
            Vendas v2 = new Vendas(2,"Monitor", 1759.10M);
            Vendas v3 = new Vendas(3,"Farofa", 6.98M);

            List<Vendas> lista = new List<Vendas>();

            lista.Add(v1);
            lista.Add(v2);
            lista.Add(v3);



            string transformarJson = JsonConvert.SerializeObject(lista, Formatting.Indented);

            Console.WriteLine(transformarJson);

            File.WriteAllText("Teste.json", transformarJson);
        }
    }
}
