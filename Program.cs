using System;

namespace exercicio_25_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2020;
            int anoNascimento = 2000;
            int retornoDafuncao = Idade(anoAtual,anoNascimento);
            ExibirMensagem(50);
            if(retornoDafuncao>=18){
                Console.WriteLine("Adulto");
            }else{
                Console.WriteLine("Infantil");
            }

             int Idade(int atual, int nascimento){
                 int idade = atual - nascimento;
                 Console.WriteLine($"A idade é de {idade}");
                return idade;
            }
             void ExibirMensagem(int idade){
                Console.WriteLine($"A idade é de {idade}");
            }
        }
    }
}
