using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            const string constante = "uma constante que não muda";

            if(argumentos.Length == 0) //se o tamanho do argumentos for igual a 0 quer dizer q a pessoa nao informou nada
            {
                Console.WriteLine("Favor informar um número inteiro");
                return; //esse return serve para parar a execuçao caso caia nesse if  
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro); //tryparse tenta converter algo em inteiro / [0]pegar a primeira posiçao dos meus argumentos 

            if (teste == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro" + argumentos[0]);
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }
    }
}
