using System;

class Program
{
    static void Main(string[] args)
    {
        int iniciar_programa, opcao_menu_principal, opcao_menu_carro, opcao_garantia;
        double nota_fiscal = 0, valor_carro = 0;
        string nome_carro = "";

        Console.WriteLine("DESEJA INICIAR O PROGRAMA? 1 - SIM 2 - NÃO");
        iniciar_programa = LerOpcaoValida(1, 2);

        while (iniciar_programa == 1)
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO À CONCESSIONÁRIA CALHAMBEQUE.\n");
            Console.WriteLine(" ESCOLHA UMA OPÇÃO:");
            Console.WriteLine("1 - COMPRAR CARRO");
            Console.WriteLine("2 - NOTA FISCAL");
            opcao_menu_principal = LerOpcaoValida(1, 2);

            switch (opcao_menu_principal)
            {
                case 1:
                    (nome_carro, valor_carro) = ComprarCarro();
                    opcao_garantia = AdicionarGarantia();

                    if (opcao_garantia == 1)
                    {
                        nota_fiscal = valor_carro + (valor_carro * 0.10);
                    }
                    else
                    {
                        nota_fiscal = valor_carro;
                    }

                    Console.Clear();
                    Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                    break;

                case 2:
                    ExibirNotaFiscal(nome_carro, valor_carro, opcao_garantia, nota_fiscal);
                    break;
            }

            Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
            iniciar_programa = LerOpcaoValida(1, 2);
        }

        Console.Clear();
        Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
    }

    // Função para ler uma opção válida dentro de um intervalo
    static int LerOpcaoValida(int min, int max)
    {
        int opcao;
        do
        {
            opcao = int.Parse(Console.ReadLine());
            if (opcao < min || opcao > max)
            {
                Console.Clear();
                Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
            }
        } while (opcao < min || opcao > max);
        return opcao;
    }

    // Função para escolher o carro e retornar nome e valor
    static (string, double) ComprarCarro()
    {
        int opcao_menu_carro;
        Console.Clear();
        Console.WriteLine("QUAL CARRO VOCÊ DESEJA COMPRAR?");
        Console.WriteLine("1 - CIVIC 2020       R$ 90.000");
        Console.WriteLine("2 - COROLLA 2020     R$ 95.000");
        Console.WriteLine("3 - KWID             R$ 60.000");
        Console.WriteLine("4 - PALIO FIRE       R$ 45.000");

        opcao_menu_carro = LerOpcaoValida(1, 4);
        switch (opcao_menu_carro)
        {
            case 1: return ("Civic 2020", 90000);
            case 2: return ("Corolla 2020", 95000);
            case 3: return ("Kwid", 60000);
            case 4: return ("Palio Fire", 45000);
            default: return ("", 0);
        }
    }

    // Função para adicionar garantia estendida
    static int AdicionarGarantia()
    {
        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
        return LerOpcaoValida(1, 2);
    }

    // Função para exibir a nota fiscal
    static void ExibirNotaFiscal(string nome_carro, double valor_carro, int opcao_garantia, double nota_fiscal)
    {
        Console.Clear();
        Console.WriteLine("NOTA FISCAL DE PRODUTO");
        Console.WriteLine("O produto comprado foi : {0}", nome_carro);
        Console.WriteLine("O valor do carro foi: R$ {0}", valor_carro);

        if (opcao_garantia == 1)
        {
            Console.WriteLine("Possui garantia estendida? SIM");
            Console.WriteLine("O valor da garantia estendida é: R$ {0}", valor_carro * 0.10);
        }
        else
        {
            Console.WriteLine("Possui garantia estendida? NÃO");
        }

        Console.WriteLine("Valor total da nota: R$ {0}", nota_fiscal);
        Console.ReadKey();
    }
}
