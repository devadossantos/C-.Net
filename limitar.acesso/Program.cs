using System;

namespace Teste
{
public class LimitacaoUsuario
{
    static void Main(string[] args)
{
      string usuario = "anisio.santos";     // usuario de acesso
      int senh = 12345;                       // senha de acesso
      string respuser;
      int respsenha;
        inicio:
        Console.Clear();
        Console.WriteLine("################");
        Console.WriteLine("ACESSO RESTRITO");
        Console.WriteLine("################\n");
        Console.Write("Qual seu usuario? ");
        respuser = (Console.ReadLine());
        Console.Write("Qual sua senha? ");
        respsenha = int.Parse(Console.ReadLine());
        
        while(respsenha != senh && respuser != usuario) {                 

         Console.WriteLine("ACESSO NAO AUTORIZADO");                  
        Console.ReadLine();
         goto inicio;                                              // volte ao inicio
        }
        
        Console.WriteLine("AUTORIZADO");                            
        Console.WriteLine("ACESSO AUTORIZADO");             
        Console.ReadLine();
                       
}
}
}