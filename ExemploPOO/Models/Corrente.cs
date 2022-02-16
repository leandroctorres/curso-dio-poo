namespace ExemploPOO.Models
{
	public class Corrente : Conta
	{
		public override void Creditar(double valor)
		{
			base.saldo = valor; //base significa que esse atributo ertence a classe pai.
		}
	}
}
