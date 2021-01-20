﻿using System;
using System.Globalization;


namespace Capitulo2
{
    class Program
    {
        static void Main(string[] args)

        {
            /*
            Triangulo x;
            x = new Triangulo();

            Console.WriteLine("Programa para calcular a area do Triangulo X com duas casas decimais:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com as medida do primeiro lado");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do segundo lado");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do terceiro lado");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("A área do triangulo informado é " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            

            //----------------------------------------------------------------------------------------//

            
            Produto p = new Produto();

            Console.WriteLine("Programa para adicionar ou remover produtos de um Estoque: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            //----------------------------------------------------------------------------------------//

            Console.WriteLine("Programa para ler os valores da largura e altura de um retângulo: ");
            Console.WriteLine("------------------------------");
            
            Retangulo r1 = new Retangulo(); 

            Console.WriteLine("Digite a largura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Digite a altura do retângulo: ");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
