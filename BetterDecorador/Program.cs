using System;
using System.Net;

namespace BetterDecorador
{
    /// <summary>
    /// Recebe um string que depois irá ser alterado por um método, sendo 
    /// inserido no inicio e fim do string um específico caracter, um número 
    /// específico de vezes.String, caracter e número de vezes a adicionar 
    /// indicados na linha de código.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Imprimir o string obtido pelo método Decor, com este a receber os 
        /// seus argumentos da linha de comandos.
        /// </summary>
        /// <param name="args">Argumentos da linha de código</param>
        private static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
               Console.WriteLine(Decor(args[0],char.Parse(args[1]), 
            int.Parse(args[2]))); 
            }
        }
        /// <summary>
        /// Recebe um string e altera-o inserindo um carater no inicio e fim da 
        /// frase consuante o número inserido. String e carateres separados por 
        /// um espaço
        /// </summary>
        /// <param name="s">String da frase a imprimir</param>
        /// <param name="dec">Carater a imprimir no inicio e fim</param>
        /// <param name="input_num">Número de vezes em que será inserido 
        /// o carater</param>
        /// <returns>String com o caracter</returns>
        private static string Decor(string s, char dec, int input_num)
        {
            int num = 0;
            s = " " + s + " ";
            while(num != input_num)
            {
                s = dec + s + dec;
                ++num;
            }
            return s;
        }
        /// <summary>
        /// No caso do utilizador não dar argumentos na consola, método dá
        /// argumentos para imprimir mensagem a avisar.
        /// </summary>
        /// <returns>String com o caracter</returns>
        private static string Decor()
        {
            string s_noinput = "User did not specify args!";
            char dec_input = '=';
            int num_noinput = 3;
            string response_noinput = Decor(s_noinput, dec_input, num_noinput);

            return response_noinput;
        }
    }
}
