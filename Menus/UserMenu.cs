using LogisticService.LogisticService;

namespace LogisticService.Menus
{
	public class UserMenu
	{
		public static LogisticModel GetLogisticModelFromUser() 
		{
            Console.Write("Logistic Service \n _____________________________________\n");
            Console.Write("Enter starting point: ");
			string startingPoint = Console.ReadLine()!.ToLower();
			Console.Write("Enter destination: ");
			string destination = Console.ReadLine()!.ToLower();
			Console.Write("Enter car body type: ");
			string bodyType = Console.ReadLine()!.ToLower();
			Console.Write("Enter container type(0 - closed, 1 - open): ");
			bool isOpen = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
			Console.Write("Is the car broken(1 - yes, 0 - no)");
			bool isCrashed = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

			return new LogisticModel(bodyType, isOpen, isCrashed, startingPoint, destination);
		}
	}
}
