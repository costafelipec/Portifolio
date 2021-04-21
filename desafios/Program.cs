using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        double salario, reajuste, novoSalario, percentual;
        while(true){
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("------------------------");
        Console.WriteLine("informe o salario");        
        if (double.TryParse(Console.ReadLine(), out double sal))
        {
            salario = Math.Round(sal, 2);
            Console.WriteLine("salario: " + salario);


            if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                if (salario != 0)
                {
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
                }
                else
                {
                    Console.WriteLine("Em percentual: {0} %", 15);

                }
            }
            else if (salario >= 400.01 && salario <= 800.00)
                {
                    reajuste = salario * 0.12;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
                }
                else if (salario >= 800.01 && salario <= 1200.00)
                {
                    reajuste = salario * 0.10;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
                }
                else if (salario >= 1200.01 && salario <= 2000.00)
                {
                    reajuste = salario * 0.07;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
                }
                else if (salario > 2000.00)
                {
                    reajuste = salario * 0.04;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
                }
                else
                {
                    Console.WriteLine("Novo salario: {0:0.00}", 0);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", 0);
                    Console.WriteLine("Em percentual: {0} %", 0);
                }


            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
        }
    }