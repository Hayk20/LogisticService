﻿namespace LogisticService.Models
{
	public class CrushedCar
	{
		public CrushedCar(bool isCrushed, double crushRate)
		{
			IsCrushed = isCrushed;
			CrushRate = crushRate;
		}

		public int Id { get; set; }
		public bool IsCrushed { get; set; }
		public double CrushRate { get; set; }

		public void ShowInfo() 
		{
            Console.Write($"ID: {Id}, Is Crashed: {IsCrushed}, Crash rate: {CrushRate}");
		}
	}
}
