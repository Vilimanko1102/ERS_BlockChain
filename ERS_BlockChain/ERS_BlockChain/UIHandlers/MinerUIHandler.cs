using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	public class MinerUIHandler : IUIHandler
	{
		private static int i = 0;
		public List<Thread> MinerThreads { get; set; } = new List<Thread>();
		public List<MinerEntity> MinerEntities { get; set; } = new List<MinerEntity>();
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite funkciju rada sa minerima.");
				Console.WriteLine("1 - Kreiranje jednog minera.");
				Console.WriteLine("2 - Miner method 2");
				Console.WriteLine("3 - Miner method 3");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
	
						break;
					case "2":
						//TODO: Miner method 2
						break;
					case "3":
						//TODO: Miner method 3...
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}

	
	}
}
