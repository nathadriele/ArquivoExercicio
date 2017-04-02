using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercicio 01 nomes_telefones");
            TextReader reader1 = new StreamReader("nomes_telefones.txt");  //TextReader representa um leitor pode ler uma série sequencial de caracteres.
            String l1 = reader1.ReadLine();
            while (l1 != null)
            {
                Console.WriteLine(l1.Substring(l1.IndexOf('(')).Replace("(", "").Replace(")", "").Replace("-", "")); //Replace retorna uma nova seqüência. Substitui os caracteres.
                l1 = reader1.ReadLine(); //indexOf relata o índice baseado em zero da primeira ocorrência da cadeia de caracteres especificada nessa instância.
            }
            Console.WriteLine("");

            Console.WriteLine("exercicio 02 nomes_telefones");
            TextReader reader2 = new StreamReader("nomes_telefones.txt"); // StreamReader para ler as linhas de um arquivo de texto padrão.
            String l2 = reader2.ReadLine();
            while (l2 != null)
            {
                Console.WriteLine((l2.Substring(0, l2.IndexOf('(') - 1).Length > 12) ? l2.Substring(0, l2.IndexOf('(') - 1).ToUpper() : l2.Substring(0, l2.IndexOf('(') - 1));
                l2 = reader2.ReadLine(); 
            }
            Console.WriteLine("");

            Console.WriteLine("exercicio 03 datas");
            TextReader reader3 = new StreamReader("datas.txt");
            String l3 = reader3.ReadLine();
            while (l3 != null)
            {
                Console.WriteLine(l3.Substring(6, 4));
                l3 = reader3.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("exercicio 04 marcas_carros");
            TextReader reader4 = new StreamReader("marcas_carros.txt"); 
            String l4 = reader4.ReadLine();
            while (l4 != null)
            {
                Console.WriteLine(l4.Substring(0, l4.IndexOf('@')));
                l4 = reader4.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("exercicio 05 produtos_estoque");
            Console.WriteLine("");
            TextReader reader5 = new StreamReader("produtos_estoque.txt");
            l1 = reader5.ReadLine();
            int c; int b = 0; float d, e = 0; 
            while (l1 != null)
            {
                c = int.Parse(l1.Substring(l1.IndexOf('|') + 1));
                b += c;
                l1 = l1.Remove(l1.IndexOf('|'));
                d = float.Parse(l1.Substring(l1.IndexOf('$') + 1));
                l1 = l1.Remove(l1.IndexOf('$'));
                e += d * c;
                l1 = reader5.ReadLine();
            }
            Console.WriteLine("Quantidade de Produtos: " + b.ToString() + "\nValor dos Produtos: $" + e.ToString());

            Console.WriteLine("");
        }
    }
}
