using System.Globalization;
using System.Net.WebSockets;

namespace MetodoFuncoes;

class Program
{

    
    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite o exercicio");
       int op = Convert.ToInt32(Console.ReadLine());
              Console.Clear(); 

              switch (op)
              {
            case 1:
            {
                   Tabuada();
            }
                break;

                //###################EX 2

                 case 2:
            {
                Sinal();                            
            }
                break;

            }
    }  

    //############   Função   ################
     
     static  void Tabuada()
     {
 System.Console.WriteLine("DIGITE O NUMERO QUE DESEJA FAZER A TUBUADA:");
        int num = Convert.ToInt32(Console.ReadLine()); 


    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(num + " X " +i+ " = " + (num * i));
    }    
    }

//################ Verificar Sinal ################endregion

    public static int Sinal()
    {

        while (true){

        System.Console.WriteLine("Digite o numero:");
       int num = Convert.ToInt32(Console.ReadLine());       

        if (num < 0) 
        {
       System.Console.WriteLine( "NUMERO NEGATIVO");
       return 0;
      
        }else if (num > 0)
        {
            System.Console.WriteLine("NUNERO POSITIVO");
            return 0;
        
        }else
        {
            System.Console.WriteLine("NULO");
            return 0;
        }
        
        }
       

    }


    }
    
