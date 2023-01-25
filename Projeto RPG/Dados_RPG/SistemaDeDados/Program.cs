using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDados
{
    public class Program
    {
        static void Main(string[] args)
        {

            int menuPrincipal;
            string str;
            List<Dados> ListaDeDados = new List<Dados>();
            do
            {
                Console.WriteLine("Sistema de dados");
                Console.WriteLine(" 1 - Nova soma");
                Console.WriteLine(" 2 - Somas anteriores");
                Console.WriteLine(" 0 - Para sair");
                str = Console.ReadLine();
                Int32.TryParse(str, out menuPrincipal);
                switch (menuPrincipal)
                {

                    case 1:
                        ListaDeDados.Add(NovosDados());
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
                } while (menuPrincipal != 0);


        }
        public static  Dados NovosDados()
        {
            Random randNum = new Random();
            int menuSecundario;
            int numeroSorteado;
            string str;

            Dados dados = new Dados();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("     Opcoes de dados");
                Console.WriteLine("   2 - Dado de   2 Faces");
                Console.WriteLine("   4 - Dado de   4 Faces");
                Console.WriteLine("   6 - Dado de   6 Faces");
                Console.WriteLine("   8 - Dado de   8 Faces");
                Console.WriteLine("  10 - Dado de  10 Faces");
                Console.WriteLine("  12 - Dado de  12 Faces");
                Console.WriteLine("  20 - Dado de  20 Faces");
                Console.WriteLine(" 100 - Dado de 100 Faces");
                Console.WriteLine("   0 - Para sair");
                str = Console.ReadLine();
                Int32.TryParse(str, out menuSecundario);
                switch (menuSecundario)
                {

                    case 2:
                        numeroSorteado= randNum.Next(menuSecundario) + 1 ;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 4:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 6:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 8:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 10:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 12:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 20:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    case 100:
                        numeroSorteado = randNum.Next(menuSecundario) + 1;
                        dados.Soma = dados.Soma + numeroSorteado;
                        dados.ListaDeDados.Add(numeroSorteado);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine("\nSoma total = " + dados.Soma + "\n");
                Console.Write("Os dados sorteados foram = " );
                foreach (var elemento in dados.ListaDeDados) Console.Write(elemento + ", ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
            } while(menuSecundario != 0);
            
            

            return dados;
        } 
    }
}
