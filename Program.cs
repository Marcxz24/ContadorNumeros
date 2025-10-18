using System;

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
                Console.Write("Deseja Contar Novamente? S/N: ");
                continuar = Console.ReadLine().ToUpper();
                Console.WriteLine(new string('-', 60));

                do
                {

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

        static void ContarUmEmUm()
        {
            int numeroContar1 = 0;

            int numeroUm = 0;

            bool validarNumeroUm = false;

            while (!validarNumeroUm)
            {
                Console.Write("Digite Um Número Para Realizar uma Cotagem de 1 em 1: ");
                string numero1Digitado = Console.ReadLine();

                if (int.TryParse(numero1Digitado, out numeroContar1))
                {
                    for (numeroUm = 0; numeroUm <= numeroContar1; numeroUm++)
                    {
                        Console.WriteLine(numeroUm);
                        Thread.Sleep(1000);
                    }
                    validarNumeroUm = true;
                }
                else
                {
                    Console.WriteLine("Valor Inválido, Digite Apenas Números!");
                }
            }
        }

        static void ContarCincoEmCinco()
        {
            int numeroContar5 = 0;

            int numeroCinco = 0;

            bool validarNumeroCinco = false;

            while (!validarNumeroCinco)
            {
                Console.Write("Digite Um Número Para Realizar uma Cotagem de 5 em 5: ");
                string numero10Digitado = Console.ReadLine();

                if (int.TryParse(numero10Digitado, out numeroContar5))
                {
                    for (numeroCinco = 0; numeroCinco <= numeroContar5; numeroCinco += 5)
                    {
                        Console.WriteLine(numeroCinco);
                        Thread.Sleep(1000);
                    }
                    validarNumeroCinco = true;
                }
                else
                {
                    Console.WriteLine("Valor Inválido, Digite Apenas Números!");
                }
            }
        }

        static void ContarDezEmDez()
        {
            int numeroContar10 = 0;

            int numeroDez = 0;

            bool validarNumeroDez = false;

            while (!validarNumeroDez)
            {
                Console.Write("Digite Um Número Para Realizar uma Cotagem de 10 em 10: ");
                string numero10Digitado = Console.ReadLine();

                if (int.TryParse(numero10Digitado, out numeroContar10))
                {
                    for (numeroDez = 0; numeroDez <= numeroContar10; numeroDez += 10)
                    {
                        Console.WriteLine(numeroDez);
                        Thread.Sleep(1000);
                    }
                    validarNumeroDez = true;
                }
                else
                {
                    Console.WriteLine("Valor Inválido, Digite Apenas Números!");
                }
            }
        }
    }
}