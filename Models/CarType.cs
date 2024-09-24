using System.Diagnostics;

namespace LogisticService.Models
{
	public class CarType
	{
		public CarType(string? bodyType, double coefficient)
		{
			BodyType = bodyType;
			Coefficient = coefficient;
		}

		public int Id { get; set; }
		public string? BodyType { get; set; }
		public double Coefficient { get; set; }

		public void ShowInfo()
		{
			Console.Write($"ID: {Id}, Body type: {BodyType}, Coefficient: {Coefficient}");
		}
	}
}
