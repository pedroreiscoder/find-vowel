using System;
using System.IO;
using System.Text;

namespace FindVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de caracteres:");
            string data = Console.ReadLine();
            FindVowelReader findVowelReader = new FindVowelReader(new MemoryStream(Encoding.UTF8.GetBytes(data)));
            char? firstChar = FindVowel.FirstChar(findVowelReader);

            if (firstChar != null)
                Console.WriteLine($"A primeira vogal após uma consoante que não se repete no resto da stream é: {firstChar}");
            else
                Console.WriteLine("Não existe uma vogal após uma consoante que não se repete no resto da stream");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
