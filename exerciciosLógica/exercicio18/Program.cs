using System;

namespace exercicio18
{
    class Program
    {
        static void Main(string[] args)
 {

		/*
		 * Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem
		 * que diga se ela poderá ou não votar este ano (não é necessário considerar o
		 * mês em que a pessoa nasceu).
		 */

		int anoAtual;
		int anoNascimento;
		int idadeEmAnos;


		Console.WriteLine("Qual é o ano atual ? ");
		anoAtual = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Qual é o ano do seu nascimento ? ");
		anoNascimento = Convert.ToInt32(Console.ReadLine());

		idadeEmAnos = anoAtual - anoNascimento;

		if (idadeEmAnos >= 18) {
			Console.WriteLine("Você pode votar este ano!");
		} else {
			Console.WriteLine("Você tem " + idadeEmAnos + " anos , não pode votar este ano!");
		}

	}
    }
}
