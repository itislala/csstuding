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
                      "[6} - Potenciação"
                      "[0] - Sair");
        string Escolha = Console.ReadLine();
        
        if (Escolha == "1" || Escolha == "2" || Escolha == "3" || Escolha == "4" || Escolha == "5" || Escolha == "6")
        {
            // ----- Coletando os números ----- //
            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            string Num1_String = Console.ReadLine();
            
            Console.WriteLine("\nDigite o segundo número inteiro: ");
            string Num2_String = Console.ReadLine();
            
            // ----- Convertendo em inteiro ----- //
            int Num1 = int.Parse(Num1_String);
            int Num2 = int.Parse(Num2_String);
            
            switch(Escolha)
            {
                case "1":
                    int Soma = Num1 + Num2;
                    Console.WriteLine($"\n{Num1}+{Num2}={Soma}");
                    break;
                
                case "2":
                    int Subtração = Num1 - Num2;
                    Console.WriteLine($"\n{Num1}-{Num2}={Subtração}");
                    break;
                    
                case "3":
                    int Multiplicação = Num1 * Num2;
                    Console.WriteLine($"\n{Num1}*{Num2}={Multiplicação}");
                    break;
                
                case "4":
                    if (Num1 == 0 || Num2 == 0)
                    {
                        Console.WriteLine("\nNão é possível dividir por 0");  
                    }
                    else
                    {
                        int Divisão = Num1 / Num2;
                        Console.WriteLine($"\n{Num1}/{Num2}={Divisão}");
                    }
                    break;
                case "5":
                    if (Num1 == 0 || Num2 == 0)
                    {
                        Console.WriteLine("\nNão é possível dividir por 0");  
                    }
                    else
                    {
                        int Resto = Num1 % Num2;
                        Console.WriteLine($"\n{Num1}%{Num2}={Resto}");
                    }
                    break;
                case "6":
                    //pensando
                    break;
            }
        }
        
        else if (Escolha == "0")
        {
            Console.WriteLine("Tchau tchau :)");
            break;
        }
        
        else
        {
            Console.WriteLine("Você digitou um caracter inválido, tente novamente\n");
        }
        
    }
  }
}
