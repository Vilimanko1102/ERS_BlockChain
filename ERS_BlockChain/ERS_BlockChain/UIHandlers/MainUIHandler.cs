using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	public class MainUIHandler : IUIHandler
	{
		private static readonly ClientUIHandler clientUIHandler = new ClientUIHandler();
		private static readonly MinerUIHandler minerUIHandler = new MinerUIHandler();
		private static readonly SmartContractUIHandler smartContractUIHandler = new SmartContractUIHandler();

		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite sa kojim delom sistema zelite da radite.");
				Console.WriteLine("1 - Rad sa Clientom");
				Console.WriteLine("2 - Rad sa MInerom");
				Console.WriteLine("3 - Rad sa Smart Contractom");
				Console.WriteLine("x - Izlazak iz aplikacije.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						clientUIHandler.HandleUI();
						break;
					case "2":
						minerUIHandler.HandleUI();
						break;
					case "3":
						smartContractUIHandler.HandleUI();
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}

		
	}
}
