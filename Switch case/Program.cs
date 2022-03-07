using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variavel inteira
            int numero;
            //imprimindo na tela uma mensagem para o usuário
            Console.WriteLine("Digite um numero de 1 a 3: ");
            //Passando valor a variavel numero e convertendo esse valor em inteiro
            numero = Convert.ToInt32(Console.ReadLine());

            //Abrindo switch e passando a variavel numero
            switch (numero)
            {
                //cada case é uma opção de ação diferente
                case 1:
                    Console.WriteLine("Escolheu a opção 1 - Exemplo for - Tabuada 1");
                    /*Laço for tem uma variavel de controle de laço nesse exemplo 
                    é a variavel x, depois tem uma condição de controle de laço e o incremento (x++)
                    que altera o valor da variavel de controle de laço (X)
                    */
                    for(int x = 0; x <= 10; x++){
                        Console.WriteLine("1 = x {0} = {1}" ,x, 1*x);

                    }
                    //O break sai do switch assim que a ação é executada
                    break;
                case 2:
                    Console.WriteLine("Escolheu a opção 2 - Exemplo While - Tabuada 2");
                    //Laço while é mais simples e necessita da criação da variavel de controle fora dele
                    int i = 0;
                    while (i <= 10)
                    {
                        Console.WriteLine("2 = x {0} = {1}", i, 2 * i);
                        //Incremento da variavel de controle do while
                        i++;
                    }
                    break;
                case 3:
                    Console.WriteLine("Escolheu a opção 3 - Exemplo do while - Tabuada 3 ");
                    //O laço while executa pelo menos uma vez o comando e depois testa a condição
                    int c = 0;
                    do
                    {
                        Console.WriteLine("3 = x {0} = {1}", c, 3 * c);
                        c++;
                    } while (c <= 10);
                    break;
                    //Default executação ação se caso a variavel não atender a nenhum case
                default:
                    Console.WriteLine("Opção invalida! ");
                    break;
            }

            Console.ReadKey();
        }
    }
}
