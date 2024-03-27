namespace ATV4_CJ3021921x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, op, n2;

            Console.WriteLine("Digite  o primeiro numero qualquer: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero qualquer: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opcão de operacão: 1 - Adição, 2 - Subtração, 3 - divisão e 4 - Multiplicação. ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Adição{0}", n1 + n2);
                    break;

                case 2:
                    Console.WriteLine("Subtração{0}", n1 - n2);
                    break;

                case 3:
                    Console.WriteLine("Divisão{0}", n1 / n2);
                    break;

                case 4:
                    Console.WriteLine("Multiplicação{0}", n1 * n2);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }

            //Exercicio 1 da lista 4 

            int dia;

            Console.WriteLine("Digite o numero correspondente ao dia da semana, de 1 a 7: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;

                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;


            }

            //Exercício 2 da lista 4

            float v;

            Console.WriteLine("Digite o valor total da compra: ");
            v = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a forma de pagamento: Dinheiro, PIX, cartão de crédito ou de cartão de débito");

            switch (v)
            {
                case 1:
                    Console.WriteLine("Dinheiro", 15 / 100);
                    break;

                case 2:
                    Console.WriteLine("PIX", 10 / 100);
                    break;

                case 3:
                    Console.WriteLine("Cartão de Débito", 100 + 5 / 100);
                    break;

                case 4:
                    Console.WriteLine("Cartão de Crédito", 100 + 10 / 100);
                    break;

                default:
                    Console.WriteLine("Forma de pagamento não aceita");
                    break;

            }

            //Exercício 3 da lista 4

            int mes;

            Console.WriteLine("Digite o mes que voce nasceu: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("JANEIRO - 31 DIAS");
                    break;

                case 2:
                    Console.WriteLine("O ano é bissexto? (1 - Sim, 2- Não)");
                    dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("FEVEREIRO - 29 DIAS");
                            break;
                        case 2:
                            Console.WriteLine("FEVEREIRO - 28 DIAS");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("MARÇO - 31 DIAS");
                    break;

                case 4:
                    Console.WriteLine("ABRIL - 30 DIAS");
                    break;

                case 5:
                    Console.WriteLine("MAIO - 31 DIAS");
                    break;

                case 6:
                    Console.WriteLine("JUNHO - 30 DIAS");
                    break;

                case 7:
                    Console.WriteLine("JULHO - 31 DIAS");
                    break;

                case 8:
                    Console.WriteLine("AGOSTO - 31 DIAS");
                    break;

                case 9:
                    Console.WriteLine("SETEMBRO - 30 DIAS");
                    break;

                case 10:
                    Console.WriteLine("OUTUBRO - 31 DIAS");
                    break;

                case 11:
                    Console.WriteLine("NOVEMBRO - 30 DIAS");
                    break;

                case 12:
                    Console.WriteLine("DESEMBRO - 31 DIAS");
                    break;

                detault: Console.WriteLine("Opção invalida");
                    break;
            }

            //Exercício 4 da lista 4

            int ope;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja: 1- +,2- -,3- *,4- /,5- ^ ");
            ope = int.Parse(Console.ReadLine());

            switch (ope)
            {
                case 1:
                    Console.WriteLine("Adição");
                    break;

                case 2:
                    Console.WriteLine("Subtração");
                    break;

                case 3:
                    Console.WriteLine("Multiplicação");
                    break;
            }

            //Exercício 5 da lista 4

            float salario, cargo;

            Console.WriteLine("Digite o seu salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu cargo(1- professor, 2- secretário, 3- publicitário, 4- Jornalista, 5- Mecanico, 6- estagiário, 7- Técnico de TI: ");
            cargo = float.Parse(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    Console.WriteLine("Novo salário= {0} salário antigo= {1} diferença= {2} Diferença= {2}" , salario + ((7.6 / 100) * salario)), salario, salario, salario + ((7.5 / 100) * salario) - salario);
                    break;

                case 2:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença= {2} Diferença= {2}", salario + ((9.7 / 100) * salario)), salario, salario, salario + ((9.7 / 100) * salario) - salario));
                    break;

                case 3:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença= {2} Diferença= {2}", salario + ((11.7 / 100) * salario)), salario, salario, salario + ((11.7 / 100) * salario) - salario));
                    break;

                case 4:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença= {2} Diferença= {2}", salario + ((8.9 / 100) * salario)), salario, salario, salario + ((8.9 / 100) * salario) - salario));
                    break;
                case 5:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença: {2} Diferença= {2}", salario + ((13.24) / 100) * salario)), salario, salario, salario + ((13.24 / 100) * salario) - salario));
                    break;
                case 6:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença: {2} Diferença= {2}", salario + ((10.4 / 100) * salario)), salario, salario, salario + ((10.4 / 100) * salario) - salario));
                    break;
                case 7:
                    Console.WriteLine("Novo salario= {0} salário antigo= {1} diferença: {2} Diferença= {2}", salario + ((14.6 / 100) * salario)), salario, salario, salario + ((14.6 / 100) * salario) - salario));
                    break;
                default:
                    Console.WriteLine("Novo sálario= {0} salário antigo= {1} Diferença= {2}", salario + ((43.5 / 100) * salario)), salario = ((43.5 / 100) * salario) - salario));
                    break;

            }

            //Exercício 6 da lista 4

            float sm;

            Console.WriteLine("Digite seu slário mensal: ");
            sm = float.Parse(Console.ReadLine());

            if (sm <= 1903.98)
            {
                Console.WriteLine("Insento de impostos, salário líquido= {0}" sm);
            }
            if (sm <= 2826.65 && sm > 1903.99) ;
            {
                Console.WriteLine("Imposto = {0}, ", 7.5 / 100 * sm, "Salário líquido = {1}", sm - (7.5 / 10 * sm));
            }
            if (sm <= 2826.65 && sm <= 3751.05) ;
            {
                Console.WriteLine("Imposto = {0}, ", 15 / 100 * sm, "Salário líquido = {1}", sm - (15 / 100 * sm));
            }
            if (sm <= 3751.05 && sm 4664.68)
            {
                Console.WriteLine("Imposto = {0}, ", 22.5 / 100 * sm, "Salário líquido = {1}", sm - (22.5 / 100 * sm));
            }
            else
            {
                Console.WriteLine("Imposto= {0}, ", 27.5 / 100 * sm, "salário líquido = {1}", sm - (27.5 / 100 * sm));
            }



















        }
    }
}
