using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Application.Miner.Interfaces;
using ERS_BlockChain.BusinessLogic.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	public class MinerUIHandler : IUIHandler
	{
		private static readonly IMinerRegisterHandler minerRegisterHandler = new MinerRegisterHandler();
		private static readonly ICompleteMinerRemovalHandler completeMinerRemovalHandler = new CompleteMinerRemovalHandler();
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("\nIzaberite funkciju rada sa minerima.");
				Console.WriteLine($"1 - Kreiranje jednog minera.");
				Console.WriteLine("2 - Uklanjanje jednog minera iz sistema.");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						minerRegisterHandler.Register();
						break;
					case "2":
						completeMinerRemovalHandler.Handle();
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}

	
	}
}
