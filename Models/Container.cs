namespace LogisticService.Models
{
	public class Container
	{
		public int Id { get; set; }
		public bool IsOpen { get; set; }

		public Container(bool isOpen)
		{
			IsOpen = isOpen;
		}
	}
}
