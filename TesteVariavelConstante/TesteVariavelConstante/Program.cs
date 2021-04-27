using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            const string constante = "uma constante que não muda";

            if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar um número inteiro");
                return; //ela para a execuçao se for atingido 
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro); // tryparse tenta converter algo em inteiro 

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro" + argumentos[0]);
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }
    }
}
