using System;

namespace Atividade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            celular modelo1 = new celular();
            Console.WriteLine("Deseja ligar o celular?");
            modelo1.ligado = modelo1.traduzConsole(Console.ReadLine());
            if(modelo1.ligado == true){
                Console.WriteLine ("celular ligado");
            }
            while(modelo1.ligado == true){
                 Console.WriteLine("Enviar mensagem");
                 modelo1.mensagem = Console.ReadLine();

                 Console.WriteLine("Fazer Ligaçao para quem?");
                 modelo1.ligacao = Console.ReadLine();

                 Console.WriteLine("Deseja manter o celular ligado?");
                 modelo1.ligado = modelo1.traduzConsole(Console.ReadLine());

            }
        }
    }
}
