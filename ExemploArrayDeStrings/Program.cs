using System;

namespace ExemploArrayDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "abracadabra", "allottee", "assessee", "kelless", "keenness"};

            // Length quantidade registros do array
            for (int i = 0; i < palavras.Length; i++) 
            {
                Console.WriteLine(RemoverDuplicados(palavras[i]));
            }
        }

        // recebe que está correndo no for
        static string RemoverDuplicados(string nome) 
        {
            // Armazena as letras, somente um caractere
            char antes = ' ';

            // armazena o resultado
            string resultado = "";

            // Percorre cada caractere do nome
            foreach (char letra in nome)
            {
                if (antes != letra)
                {
                    antes = letra;
                    resultado += letra;
                }
            }

            return resultado;
        }
    }

}
