namespace DesafioPOO.Models
{
	// Herança feita!
	public class Iphone : Smartphone
	{
		public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

		// Método "InstalarAplicativo" sobrescrito!
		public override void InstalarAplicativo(string nomeApp) => Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone");
	}
}