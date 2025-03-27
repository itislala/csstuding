using System;
class Calculadora 
{
  static void Main() 
  {
    Console.WriteLine("Bem-vindo à calculadora!");
    while(true)
    {
        Console.WriteLine("Selecione o número correspondente ao que você deseja fazer: \n" +
                          "[1] - Somar \n" +
                          "[2] - Substrair \n" +
                          "[3] - Multiplicar \n" +
                          "[4] - Dividir \n" +
                          "[5] - Restante \n" +
                          "[6} - Potenciação\n" +
                          "[0] - Sair");
        string Escolha = Console.ReadLine();
        
        if (Escolha == "1" || Escolha == "2" || Escolha == "3" || Escolha == "4" || Escolha == "5" || Escolha == "6")
        {
            Console.Clear();
            // ----- Coletando os números ----- //
            Console.Write("Digite o primeiro número: ");
            double Num1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            double Num2 = double.Parse(Console.ReadLine());
            switch(Escolha)
            {
                case "1":
                    double Soma = Num1 + Num2;
                    Console.WriteLine($"{Num1}+{Num2}={Soma}\n");
                    break;
                
                case "2":
                    double Subtração = Num1 - Num2;
                    Console.WriteLine($"{Num1}-{Num2}={Subtração}\n");
                    break;
                    
                case "3":
                    double Multiplicação = Num1 * Num2;
                    Console.WriteLine($"{Num1}*{Num2}={Multiplicação}\n");
                    break;
                
                case "4":
                    if (Num1 == 0 || Num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0\n");
                    }
                    else
                    {
                        double Divisão = Num1 / Num2;
                        Console.WriteLine($"{Num1}/{Num2}={Divisão}\n");
                    }
                    break;
                case "5":
                    if (Num1 == 0 || Num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0\n");  
                    }
                    else
                    {
                        double Resto = Num1 % Num2;
                        Console.WriteLine($"{Num1}%{Num2}={Resto}\n");
                    }
                    break;
                case "6":
                    double numAux = 1; 
                    for (double pot = 1; pot <= Num2; pot++ )
                    {
                        numAux *= Num1;
                    }
                    Console.WriteLine($"{Num1}^{Num2}={numAux}\n");
                    break;
                default:
                    Console.WriteLine("Aconteceu algum erro, isso não era pra aparecer\n");
                    break;
            }
        }
        else if (Escolha == "0")
        {
            Console.Clear();
            Console.WriteLine("Tchau tchau :)");
            break;
        }
        
        else
        {
            Console.Clear();
            Console.WriteLine("Você digitou um caracter inválido, tente novamente\n");
        }
        
    }
  }
}
    }
  }
}
