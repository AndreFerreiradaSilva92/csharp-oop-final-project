using System;

namespace FinalProject
{
    class Colab //definição da classe Colaborador
    {
        private int codColab; //código de colaborador
        private string nomColab; // nome do colaborador
        private double vencColab; // vencimento do colaborador
        private double plafondAlimColab; // plafond de alimentação
        private string segSaudeColab; // seguro de saúde? (s/n)

        public Colab() { plafondAlimColab = 140; }
        
        //atribuição de codigo
        public void SetCod(int newCodColab) { codColab = newCodColab; }
        
        //atribuição do nome
        public void SetNome(string newNome) { nomColab = newNome; }
        
        //atribuição do vencimento
        public void SetVencimento(double newVencimento) { vencColab = newVencimento; }
        
        //atribuição do aumento do Plafond
        public void SetPlafond(double newPlafond) { plafondAlimColab = newPlafond; }

        public void setseguro(string newseguro) { segSaudeColab = newseguro; }

        //metodos get()
        public int GetCod()
        {
            return codColab;
        }
        public string GetNome()
        {
            return nomColab;
        }
        public double GetVencimento()
        {
            return vencColab;
        }
        public string GetSeguro()
        {
            return segSaudeColab;
        }
        public double GetPlafond()
        {
            return plafondAlimColab;
        }
    }
    class Program
    {
        public static int fMenu()
        {
            Console.WriteLine("GESTÃO DE COLABORADORES");
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Inserir Colaborador");
            Console.WriteLine("2 - Listar Colaboradores");
            Console.WriteLine("3 - Consultar registo de um Colaborador");
            Console.WriteLine("4 - Consultar subsidio de alimentação de um Colaborador");
            Console.WriteLine("5 - Usar Cartão da Alimentação");
            Console.WriteLine("6 - Carregar o Plafond do subsídio de Alimentação de um Colaborador");
            Console.WriteLine("7 - Carregar o Plafond do subsídio de Alimentação de todos os Colaboradores");
            Console.WriteLine("8 - Calcular a média dos vencimentos dos colaboradores");
            Console.WriteLine("9 - Colaborador com o melhor vencimento");
            Console.WriteLine("10 - Colaborador com o menor vencimento");
            Console.WriteLine("11 -  Listagem dos Inscritos no Seguro de Saúde");
            Console.WriteLine("0 - Sair");
            return Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Colab[] objColab = new Colab[0];
            int opcao = 0;
            do
            {
                opcao = fMenu();
                switch (opcao)
                {
                    case 1://inserir colaboradores
                            // Array.Resize(ref objColab, objColab.Length + 1);
                            // int indice = objColab.Length - 1;
                            // Console.WriteLine(indice);
                            //objColab[indice] = new Colab();
                            bool case1 = false;
                            int codTemp = 0;
                            Console.WriteLine("Insira o codigo do colaborador:");
                            codTemp = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < objColab.Length; i++)
                            {
                                if (objColab[i].GetCod() == codTemp)
                                {
                                    Console.WriteLine("Codigo ja existe!");
                                    case1 = true;
                                };
                            };
                            if(!case1)
                            {
                                Array.Resize(ref objColab, objColab.Length + 1);
                                objColab[objColab.Length - 1] = new Colab();

                                objColab[objColab.Length - 1].SetCod(codTemp);
                                Console.WriteLine("Insira o nome do colaborador:");
                                objColab[objColab.Length - 1].SetNome(Console.ReadLine());
                                Console.WriteLine("Insira o vencimento do colaborador:");
                                objColab[objColab.Length - 1].SetVencimento(Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("Seguro de trabalho: S/N");
                                objColab[objColab.Length - 1].setseguro(Console.ReadLine());

                                Console.WriteLine("Colaborador inserido!");
                            }
                        /*do 
                            
                        {
                            Console.Clear();
                            Console.WriteLine("Que tipo de colaborador deseja inserir?");
                            Console.WriteLine("1 - Operador de loja");
                            Console.WriteLine("2 - Chefe de Departamento");
                            Console.WriteLine("3 - Administrativo");
                            Console.WriteLine("4 - Voltar ao Menu Inicial");
                            opcao = Convert.ToInt32(Console.ReadLine());
                            switch (opcao)
                            { 
                                case 1:break;

                                case 2:break;

                                case 3:break;

                            
                        }
                        while (opcao != 4);*/
                        break;

                    case 2://listar os colaboradores
                        for (int i = 0; i < objColab.Length; i++)
                        {
                            Console.WriteLine($"Colaborador  nº{i + 1} - Nome: {objColab[i].GetNome()} - Codigo: {objColab[i].GetCod()} - Vencimento: {objColab[i].GetVencimento()} - Plafond Alimentação: {objColab[i].GetPlafond()} - Seguro de Trabalho: {objColab[i].GetSeguro()}");
                        };
                        break;

                    case 3://consultar registo de um colaborador
                        Console.WriteLine("Insira o codigo que quer vizualizar");
                        int numcolab = Convert.ToInt32(Console.ReadLine());
                        bool case3 = false;
                        for (int i = 0; i < objColab.Length ; i++)
                        {
                            if (objColab[i].GetCod() == numcolab)
                            {
                                Console.WriteLine($"Colaborador  nº{i + 1} - Nome: {objColab[i].GetNome()} - Codigo: {objColab[i].GetCod()} - Vencimento: {objColab[i].GetVencimento()} - Plafond Alimentação: {objColab[i].GetPlafond()}");
                                case3 = true;                            
                            }
                        }
                        if (case3 == false)
                        {
                            Console.WriteLine("Código nao existe!");
                        }
                            
                        break;

                    case 4://consultar plafond de alimentação de um colaborador
                        Console.WriteLine("Insira o codigo do colaborador que deseja ver o planfo");
                        int versub = Convert.ToInt32(Console.ReadLine());
                        bool case4 = false;
                        for (int i = 0; i < objColab.Length; i++)
                        {
                            if (objColab[i].GetCod() == versub)
                            {
                                Console.WriteLine($"Plafond Alimentação: {objColab[i].GetPlafond()}");
                                case4 = true;
                            };
                        }
                        if (case4 == false)
                        {
                            Console.WriteLine("Código nao existe!");
                        };
                        break;

                    case 5://usar o cartão de alimentação
                        Console.WriteLine("Insira o codigo do colaborador que deseja usar o cartão de refeição");
                        int cartao = Convert.ToInt32(Console.ReadLine());
                        bool case5 = false;
                        for (int i = 0; i < objColab.Length; i++)
                        {
                            if (objColab[i].GetCod() == cartao)
                            {
                                Console.WriteLine("Quanto é que deseja gastar");
                                double gastar = Convert.ToDouble(Console.ReadLine());
                                if (gastar <= objColab[i].GetPlafond())
                                {
                                    objColab[i].SetPlafond(objColab[i].GetPlafond() - gastar);
                                    Console.WriteLine($"Planfond é de: {objColab[i].GetPlafond()} euros!");
                                    case5 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Subsidio nao é suficiente!");
                                    Console.WriteLine($"Planfond é de: {objColab[i].GetPlafond()} euros!");
                                    case5 = true;
                                }
                            }
                        }
                        if (case5 == false)
                        {
                            Console.WriteLine("Código nao existe!");
                        };
                        break;

                    case 6://Carregar o Plafond do subsídio de Alimentação de um Colaborador
                        Console.WriteLine("Insira o codigo do colaborador que deseja carregar");
                        int carregarcartao = Convert.ToInt32(Console.ReadLine());
                        bool case6 = false;
                        for (int i = 0; i < objColab.Length; i++)
                        {
                            if (objColab[i].GetCod() == carregarcartao)
                            {
                                Console.WriteLine("Em quanto é que deseja aumentar o subsidio?");
                                double aumentar = Convert.ToDouble(Console.ReadLine());
                                objColab[i].SetPlafond(objColab[i].GetPlafond() + aumentar);
                                case6 = true;
                            }
                        }
                        if (case6 == false)
                        {
                            Console.WriteLine("Código nao existe!");
                        };
                        break;

                    case 7://Carregar o Plafond do subsídio de Alimentação de todos os Colaboradores
                        Console.WriteLine("Em quanto é que deseja aumentar o subsidio?");
                        double aumentartodos = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < objColab.Length; i++)
                        {
                            objColab[i].SetPlafond(objColab[i].GetPlafond() + aumentartodos);
                        }
                        break;

                    case 8:
                        if (objColab.Length > 0)
                        {
                            double soma = 0;
                            for (int i = 0; i < objColab.Length; i++)
                            {
                                soma += objColab[i].GetVencimento();
                            }
                            double media = soma / objColab.Length;
                            Console.WriteLine($"A media dos vencimentos é de {media} euros.");
                        }
                            else
                        {
                            Console.WriteLine("Não existem colaboradores registados.");
                        }
                        break;

                    case 9:// O nome do colaborador com o melhor vencimento
                        string nomemaiorvencimento = "";
                        double nummaiorvencimento = 0;
                        if (objColab.Length > 0)
                        {
                            nomemaiorvencimento = objColab[0].GetNome();
                            nummaiorvencimento = objColab[0].GetVencimento();
                        }
                        for (int i = 0; i< objColab.Length;i++)
                            if(objColab[i].GetVencimento()> nummaiorvencimento)
                            {
                                nummaiorvencimento = objColab[i].GetVencimento();
                                nomemaiorvencimento = objColab[i].GetNome();
                            }
                        Console.WriteLine($"O colaborador com maior vencimento é {nomemaiorvencimento} com um vencimento de {nummaiorvencimento} euros.");
                        break;

                    case 10://O nome do colaborador com o menor vencimento
                        string nomemenorvencimento = "";
                        double nummenorvencimento = 0;
                        if (objColab.Length > 0)
                        {
                            nomemenorvencimento = objColab[0].GetNome();
                            nummenorvencimento = objColab[0].GetVencimento();
                        }
                        for (int i = 0; i < objColab.Length; i++)
                            if (objColab[i].GetVencimento() < nummenorvencimento)
                            {
                                nummenorvencimento = objColab[i].GetVencimento();
                                nomemenorvencimento = objColab[i].GetNome();
                            }
                        Console.WriteLine($"O colaborador com o menor vencimento é {nomemenorvencimento} com um vencimento de {nummenorvencimento} euros.");
                        break;

                    case 11://Listagem dos Inscritos no Seguro de Saúde
                        for (int i = 0; i < objColab.Length; i++)
                            if(objColab[i].GetSeguro() == "s" || objColab[i].GetSeguro() == "S")
                            {
                                Console.WriteLine($"Colaborador  nº{i+1} - Nome: {objColab[i].GetNome()}");
                            }
                            break;
                }
                Console.WriteLine("Prima qualquer tecla para continuar...");
                Console.ReadLine();
            }
            while (opcao != 0);
        }
    }
}

