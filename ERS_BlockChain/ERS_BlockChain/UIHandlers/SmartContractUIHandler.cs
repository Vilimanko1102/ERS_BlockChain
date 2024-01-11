using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.BusinessLogic.SmartContract;
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
		private static readonly IRegistratedClientsInfoPrinter registratedClientsInfoPrinter = new RegistratedClientsInfoPrinter();
		private static readonly IRegistratedMinersInfoPrinter registratedMinersInfoPrinter = new RegistratedMinersInfoPrinter();
		private static readonly IBlockChainInfoPrinter blockChainInfoPrinter = new BlockChainInfoPrinter();
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite funkciju rada sa smart contract-om.");
				Console.WriteLine("1 - Ispisi informacije o klinetima");
				Console.WriteLine("2 - Ispisi informacije o minerima");
				Console.WriteLine("3 - ispisi informacije o BLockChainu");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						registratedClientsInfoPrinter.PrintInfo();
						break;
					case "2":
						registratedMinersInfoPrinter.PrintInfo();
						break;
					case "3":
						blockChainInfoPrinter.PrintInfo();
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}
	}
}
