using ERS_BlockChain.Application.Client;
using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	public class SmartContractUIHandler : IUIHandler
	{
		
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite funkciju rada sa smart contract-om.");
				Console.WriteLine("1 - Registruj");
				Console.WriteLine("2 - Smart Contract method 2");
				Console.WriteLine("3 - Smart Contract method 3");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						//TODO: SC method 1
						break;
					case "2":
						//TODO: SC method 2
						break;
					case "3":
						//TODO: SC method 3...
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}
	}
}
