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
                      "[0] - Sair \n");
        string Escolha = Console.ReadLine();
        if (Escolha == "1" || Escolha == "2" || Escolha == "3" || Escolha == "4")
        {
            Console.WriteLine("O if das operações está funcionando");
        }
        else if (Escolha == "0")
        {
            Console.WriteLine("O if do sair está funcionando");
            break;
        }
        else
        {
            Console.WriteLine("Você digitou um caracter inválido, tente novamente");
        }
        
    }
  }
}
