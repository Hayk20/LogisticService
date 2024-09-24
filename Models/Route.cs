namespace LogisticService.Models
{
	public class Route
	{
		public Route(string startingPoint, string destination, double price, int distance) 
			: this(startingPoint, destination, price)
		{
			Distance = distance;
		}

		public Route(string startingPoint, string destination, double price)
		{
			StartingPoint = startingPoint;
			Destination = destination;
			Price = price;
		}

		public int Id { get; set; }
		public string StartingPoint { get; set; }
		public string Destination { get; set; }
		public double Price { get; set; }
		public int Distance { get; set; }
		public int PricePerKilometerId { get; set; }
		public PricePerKilometer PricePerKilometer { get; set; }

		public void ShowInfo()
		{
			Console.Write($"ID: {Id}, Starting point: {StartingPoint}, Destination: {Destination}, Price: {Price}");
		}
	}
}
