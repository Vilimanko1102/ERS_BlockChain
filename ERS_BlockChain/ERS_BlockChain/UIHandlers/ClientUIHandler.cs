using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	public class ClientUIHandler : IUIHandler
	{
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite funkciju rada sa klijentima.");
				Console.WriteLine("1 - Client method 1");
				Console.WriteLine("2 - Client method 2");
				Console.WriteLine("3 - Client method 3");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						//TODO: Client method 1
						break;
					case "2":
						//TODO: Client method 2
						break;
					case "3":
						//TODO: Client method 3...
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}
	}
}
