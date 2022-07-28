int iniciar_programa, opcao_menu_principal, opcao_menu_carro, opcao_garantia, voltar_menu;
            double nota_fiscal, valor_carro;
            string nome_carro;
            nota_fiscal = 0;
            opcao_menu_carro = 0;
            opcao_garantia = 0;
            nome_carro = "";
            valor_carro = 0;
            Console.WriteLine("DESEJA INICIAR O PROGRAMA? 1 - SIM 2 - NÃO");
            iniciar_programa = int.Parse(Console.ReadLine());
            while (iniciar_programa != 1 && iniciar_programa != 2)
            {
                Console.Clear();
                Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                Console.WriteLine("1 - INICIAR PROGRAMA");
                Console.WriteLine("2 - FECHAR");
                iniciar_programa = int.Parse(Console.ReadLine());
            }

            while (iniciar_programa == 1)
            {
                switch (iniciar_programa)
                {
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("BEM VINDO À CONCESSIONÁRIA CALHAMBEQUE.\n");
                        Console.WriteLine(" ESCOLHA UMA OPÇÃO:");
                        Console.WriteLine("1 - COMPRAR CARRO");
                        Console.WriteLine("2 - NOTA FISCAL");
                        opcao_menu_principal = int.Parse(Console.ReadLine());
                        
                        while (opcao_menu_principal != 1 && opcao_menu_principal != 2)
                        {
                            Console.Clear();
                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                            Console.WriteLine("1 - COMPRAR CARRO");
                            Console.WriteLine("2 - NOTA FISCAL");
                            opcao_menu_principal = int.Parse(Console.ReadLine());
                        }
                        switch (opcao_menu_principal)
                        {
                            
                            case 1:
                                Console.Clear();
                                Console.WriteLine("QUAL CARRO VOCÊ DESEJA COMPRAR?");
                                Console.WriteLine("1 - CIVIC 2020       R$ 90.000");
                                Console.WriteLine("2 - COROLLA 2020     R$ 95.000");
                                Console.WriteLine("3 - KWID             R$ 60.000");
                                Console.WriteLine("4 - PALIO FIRE       R$ 45.000");
                                opcao_menu_carro = int.Parse(Console.ReadLine());
                                
                                while (opcao_menu_carro != 1 && opcao_menu_carro != 2 && opcao_menu_carro != 3 && opcao_menu_carro != 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                    Console.WriteLine("1 - CIVIC 2020       R$ 90.000");
                                    Console.WriteLine("2 - COROLLA 2020     R$ 95.000");
                                    Console.WriteLine("3 - KWID             R$ 60.000");
                                    Console.WriteLine("4 - PALIO FIRE       R$ 45.000");
                                    opcao_menu_carro = int.Parse(Console.ReadLine());
                                }
                                switch (opcao_menu_carro)
                                {
                                    
                                    case 1:
                                        nome_carro = "Civic 2020";
                                        valor_carro = 90000;
                                        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                        opcao_garantia = int.Parse(Console.ReadLine());
                                        while (opcao_garantia != 1 && opcao_garantia != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                            opcao_garantia = int.Parse(Console.ReadLine());
                                        }
                                        switch (opcao_garantia)
                                        {
                                            case 1:
                                                nota_fiscal = nota_fiscal + 90000 + (90000 * 0.10);
                                                break;
                                            case 2:
                                                nota_fiscal = 90000;
                                                break;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
                                        iniciar_programa = int.Parse(Console.ReadLine());
                                        while (iniciar_programa != 1 && iniciar_programa != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("1 - INICIAR PROGRAMA");
                                            Console.WriteLine("2 - FECHAR");
                                            iniciar_programa = int.Parse(Console.ReadLine());
                                        }
                                        switch (iniciar_programa)
                                        {
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                                                break;
                                        }
                                        break;
                                    
                                    case 2:
                                        nome_carro = "Corolla 2020";
                                        valor_carro = 95000;
                                        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                        opcao_garantia = int.Parse(Console.ReadLine());
                                        while (opcao_garantia != 1 && opcao_garantia != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                            opcao_garantia = int.Parse(Console.ReadLine());
                                        }
                                        switch (opcao_garantia)
                                        {
                                            case 1:
                                                nota_fiscal = nota_fiscal + 95000 + (95000 * 0.10);
                                                break;
                                            case 2:
                                                nota_fiscal = 95000;
                                                break;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
                                        iniciar_programa = int.Parse(Console.ReadLine());
                                        while (iniciar_programa != 1 && iniciar_programa != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("1 - INICIAR PROGRAMA");
                                            Console.WriteLine("2 - FECHAR");
                                            iniciar_programa = int.Parse(Console.ReadLine());
                                        }
                                        switch (iniciar_programa)
                                        {
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                                                break;
                                        }
                                        break;
                                    
                                    case 3:
                                        nome_carro = "Kwid";
                                        valor_carro = 60000;
                                        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                        opcao_garantia = int.Parse(Console.ReadLine());
                                        while (opcao_garantia != 1 && opcao_garantia != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                            opcao_garantia = int.Parse(Console.ReadLine());
                                        }
                                        switch (opcao_garantia)
                                        {
                                            case 1:
                                                nota_fiscal = nota_fiscal + 60000 + (60000 * 0.10);
                                                break;
                                            case 2:
                                                nota_fiscal = 60000;
                                                break;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
                                        iniciar_programa = int.Parse(Console.ReadLine());
                                        while (iniciar_programa != 1 && iniciar_programa != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("1 - INICIAR PROGRAMA");
                                            Console.WriteLine("2 - FECHAR");
                                            iniciar_programa = int.Parse(Console.ReadLine());
                                        }
                                        switch (iniciar_programa)
                                        {
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                                                break;
                                        }
                                        break;
                                    
                                    case 4:
                                        nome_carro = "Palio Fire";
                                        valor_carro = 45000;
                                        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                        opcao_garantia = int.Parse(Console.ReadLine());
                                        while (opcao_garantia != 1 && opcao_garantia != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? 1 - SIM 2 - NÃO");
                                            opcao_garantia = int.Parse(Console.ReadLine());
                                        }
                                        switch (opcao_garantia)
                                        {
                                            case 1:
                                                nota_fiscal = nota_fiscal + 45000 + (45000 * 0.10);
                                                break;
                                            case 2:
                                                nota_fiscal = 45000;
                                                break;
                                        }
                                        break;
                                        Console.Clear();
                                        Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
                                        iniciar_programa = int.Parse(Console.ReadLine());
                                        while (iniciar_programa != 1 && iniciar_programa != 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                            Console.WriteLine("1 - INICIAR PROGRAMA");
                                            Console.WriteLine("2 - FECHAR");
                                            iniciar_programa = int.Parse(Console.ReadLine());
                                        }
                                        switch (iniciar_programa)
                                        {
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                                                break;
                                        }
                                }
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("NOTA FISCAL DE PRODUTO");
                                Console.WriteLine("O produto comprado foi : {0}", nome_carro);
                                Console.WriteLine("O valor do carro foi: R$ {0}", valor_carro);
                                switch (opcao_garantia)
                                {
                                    case 1:
                                        Console.WriteLine("Possui garantia estendida? SIM");
                                        Console.WriteLine("O valor da garantia estendida é: R$ {0}", valor_carro * 0.10);
                                        break;
                                    case 2:
                                        Console.WriteLine("Possui garantia estendida? NÃO");
                                        break;
                                }
                                Console.WriteLine("Valor total da nota: R$ {0}", nota_fiscal);
                                Console.ReadKey();
                                Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? 1 - SIM 2 - NÃO");
                                iniciar_programa = int.Parse(Console.ReadLine());
                                while (iniciar_programa != 1 && iniciar_programa != 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("CÓDIGO INVÁLIDO !!! DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                                    Console.WriteLine("1 - INICIAR PROGRAMA");
                                    Console.WriteLine("2 - FECHAR");
                                    iniciar_programa = int.Parse(Console.ReadLine());
                                }
                                switch (iniciar_programa)
                                {
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                        break;
                }

            }
            switch (iniciar_programa)
            {
                case 2:
                    Console.Clear();
                    Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE !!!!");
                    break;
            }