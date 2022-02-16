using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
					//Exemplo 1) Abstração: Classe Pessoa
					Pessoa p = new Pessoa();
					p.Nome = "Bob";
					p.Idade = 22;
					p.Apresentar();

					//Exemplo 2) Encapsulamento: Classe Retangulo
					Retangulo r = new Retangulo();
					r.DefinirMedidas(30, 30);
					System.Console.WriteLine($"Área: {r.ObterArea()}");

					Retangulo r2 = new Retangulo();
					r2.DefinirMedidas(0, 0);
					System.Console.WriteLine($"Área: {r2.ObterArea()}");


					//Exemplo 3) Herança: Classes Aluno e Professor Herdam atributos de Pessoa.
					Aluno a1 = new Aluno();
					a1.Nome = "Davi";
					a1.Idade = 20;
					a1.Nota = 10;

					//Exemplo 4) Polimorfismo em tempo de execução : O método Apresentar da Classe Aluno tem um
					//comportamento diferente do método da Apresentar da classe Pessoa.
					a1.Apresentar();

					Professor prof = new Professor();
					prof.Nome = "Leo";
					prof.Idade = 30;
					prof.Salario = 3000;
					prof.Apresentar();

					//Exemplo 5) Polimorfismo em tempo de compilação: O método outra assinatura, com mais parametros.
					Calculadora calc = new Calculadora();
					System.Console.WriteLine("Resultado da primeira soma:" + calc.Somar(10,10));
					System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(10,10,10));

					//Exemplo 6) Classes Abstratas: A Classe Conta é abstrata, e tem o método abstrato Creditar.
					// Classes abstratas não podem ser instanciadas. São moldes para que outras classes herdem e sobreescrevam.
					// A classe Corrente herda de Conta, e sobreescreve o método Creditar. Como é uma classe filha da classe conta,
					// pode acessar o atributo protected saldo.
					Corrente c = new Corrente();
					c.Creditar(100);
					c.ExibirSaldo();

					//Exemplo 7) Métodos selados
					// Classes seladas não podem ter classes filhas.
					// Métodos selados não podem ter sobrecarga.
					// O método Apresentar da Classe Professor é selada. A classe Diretor é filha da Classe Professor,
					// mas não é possivel sobreescrever o método Apresentar.

					//Exemplo 8) Classe Object
					// A Classe object é mãe de todas as classes.
					Computador comp = new Computador();
					System.Console.WriteLine(comp.ToString());

					// Exemplo 9) Interfaces
					// Uma Interface é muito parecida com uma classe abstrata. Não pode ser instanciada.
					// Não existe herança multípla. Uma classe só pode herdar de uma única classe.
					// Mas é possível "herdar"/ implementar mais de uma interfaces.
					// A Interface funciona como um contrato. Faz com que a classe filha seja obrigada
					// a implementar todos os seus métodos.

					ICalculadora calc2 = new Calculadora();
					System.Console.WriteLine(calc2.Somar(10,20));
					System.Console.WriteLine(calc2.Dividir(50,10));
					System.Console.WriteLine(calc2.Multiplicar(9,7));

					// Exemplo 10) Manipulando Arquivos - Listar diretórios
					var caminho = "C:\\TrabalhandoComArquivos";
					FileHelper helper = new FileHelper();
					helper.ListarDiretorios(caminho);
					helper.ListarDiretoriosComSubPastas(caminho);

					// Exemplo 11) Listar Arquivos:
					helper.ListarArquivosDiretorios(caminho);
					helper.ListarArquivosDiretoriosComSubPastas(caminho);
					helper.ListarArquivosTxtDiretoriosComSubPastas(caminho);

					// Exemplo 12) Criar Diretório:
					helper.CriarDiretorio(Path.Combine(caminho, "Pasta teste 3", "SubPastaTeste3"));

					// Exemplo 13) Apagar Diretório
					var caminho2 = "C:\\TrabalhandoComArquivos\\Pasta Teste 4";
					helper.ApagarDiretorio(caminho2, true);

					// Exemplo 14) Criar arquivo Texto
					var caminhoArquivo = Path.Combine(caminho, "Arquivo-teste.txt");
					helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");

					// Exemplo 15) Criar arquivo de texto stream
					var caminhoArquivo2 = Path.Combine(caminho, "Arquivo-teste-stream.txt");
					var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
					helper.CriarArquivoTextoStream(caminhoArquivo2, listaString);

					// Exemplo 16) Adicionar linhas ao arquivo de Texto
					var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
					helper.AdicionarTextoStream(caminhoArquivo2, listaStringContinuacao);

					// Exemplo 17) Lendo Arquivos
					helper.LerArquivoStream(caminhoArquivo2);

					// Exemplo 18) Movendo Arquivo
					var novoCaminhoArquivo2 = Path.Combine(caminho, "Pasta Teste 2", "Arquivo-teste-stream.txt");
					helper.MoverArquivo(caminhoArquivo2, novoCaminhoArquivo2, false);

					//Exemplo 19) Copiando Arquivo
					var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo-teste.txt");
					var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo-teste-bkp.txt");
					helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

					// Exemplo 20) Deletando Arquivo
					helper.DeletarArquivo(caminhoArquivoTesteCopia);








				}
    }
}
