﻿using System;
using Secao17.Services;

namespace Secao17
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationMulticast(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //O objeto OP passa ser uma referência à função CalculationService.Sum
            BinaryNumericOperation op = CalculationService.Sum;

            //Sintaxe alternativa (mais verboso)
            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Sum);


            double result = op(a, b);
            //Sintaxe alternativa:
            double result2 = op2.Invoke(a, b);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            //Lembrando que o Delegate é uma assinatura com type safety.
            //Ou seja, caso atribua CalculationService.Square ele não vai aceitar, pois está disposto que ele recebe 2 números double e retorna um double


            //Multicast - Nesse momento o op3 aponta para duas funções
            BinaryNumericOperationMulticast op3 = CalculationServiceMulticast.ShowSum;
            op3 += CalculationServiceMulticast.ShowMax;

            //Primeiro mostra a soma, depois mostra o max
            op3.Invoke(a, b);
            //ou sintaxe alternativa:
            op3(a, b);
        }
    }
}