using System;
using System.Threading;

namespace ContadorNumeros
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("     CONTADOR DE NÚMEROS");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("[0] - Para Sair do Programa");
            Console.WriteLine("[1] - Para Contar de Um em Um");
            Console.WriteLine("[2] - Para Contar de Cinco em Cinco");
            Console.WriteLine("[3] - Para Contar de Dez em Dez");
            Console.WriteLine(new string('-', 60));

            string continuar;

            do
            {
                int opcao = 0;

                bool validarEscolha = false;

                while (!validarEscolha)
                {
                    Console.Write("Escolha Uma das Opções Acima: ");
                    string valorDigitado = Console.ReadLine();
                    Console.WriteLine(new string('-', 60));

                    if (int.TryParse(valorDigitado, out opcao))
                    {
                        validarEscolha = true;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Digite Apenas Números!");
                        Console.WriteLine(new string('-', 60));
                    }
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Encerrando Programa...");
                        Environment.Exit(0);
                        break;

                    case 1:
                        ContarUmEmUm();
                        break;

                    case 2:
                        ContarCincoEmCinco();
                        break;

                    case 3:
                        ContarDezEmDez();
                        break;

                    default:
                        Console.WriteLine("Escolha uma das Opções Destacadas...");
                        Console.WriteLine(new string('-', 60));
                        break;
                }

                Console.WriteLine(new string('-', 60));

                do
                {
                    Console.Write("Deseja Contar Novamente? S/N: ");
                    continuar = Console.ReadLine().ToUpper();
                    Console.WriteLine(new string('-', 60));
                    if (continuar != "S" && continuar != "N")
                    {
                        Console.WriteLine("Valor Inválido, Digite S ou N");
                    }
                }
                while (continuar != "S" && continuar != "N");
            }
            while (continuar == "S");

            Console.WriteLine("Encerrando Programa...");
            Console.ReadKey();
        }

        static int PedirNumero()
        {
            int numeroContar = 0;

            bool validarNumero = false;

            while (!validarNumero)
            {
                Console.Write("Digite Um Número Para Realizar a Contagem: ");
                string numeroDigitado = Console.ReadLine();
                Console.WriteLine(new string('-', 60));

                if (int.TryParse(numeroDigitado, out numeroContar))
                {
                    validarNumero = true;
                }
                else
                {
                    Console.WriteLine("Valor Inválido, Digite Apenas Números!");
                    Console.WriteLine(new string('-', 60));
                }
            }
            return numeroContar;
        }

        static void ContarUmEmUm()
        {
            int numeroFinal = PedirNumero();

            for (int i = 0; i <= numeroFinal; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void ContarCincoEmCinco()
        {
            int numeroFinal = PedirNumero();

            for (int i = 0; i <= numeroFinal; i += 5)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void ContarDezEmDez()
        {
            int numeroFinal = PedirNumero();

            for (int i = 0; i <= numeroFinal; i += 10)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}