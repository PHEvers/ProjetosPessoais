// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int menuPrincipal;
int menuSecundario;
string str;
do
{
    Console.WriteLine("Sistema de dados");
    Console.WriteLine(" 1 - Nova soma");
    Console.WriteLine(" 0 - Para sair");
    str = Console.ReadLine();
    Int32.TryParse(str, out menuPrincipal);
} while (menuPrincipal != 0); 


