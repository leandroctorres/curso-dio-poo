using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
			//OBS.: Não é possível fazer sobrecarga do método apresentar, porque o mesmo é selado.
			/*
			public override void Apresentar()
			{
				Console.WriteLine($"Diretor");
			}
			*/

    }
}
