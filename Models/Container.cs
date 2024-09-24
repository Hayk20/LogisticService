namespace LogisticService.Models
{
	public class Container
	{
		public int Id { get; set; }
		public bool IsOpen { get; set; }
        public double Coefficient { get; set; }

        public Container(bool isOpen, double coefficient)
		{
			IsOpen = isOpen;
			Coefficient = coefficient;
		}

		public void ShowInfo()
		{
			Console.Write($"ID: {Id}, Is Open: {IsOpen}, Coefficient: {Coefficient}");
		}
	}
}
