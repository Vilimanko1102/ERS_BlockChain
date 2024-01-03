using ERS_BlockChain.Application.Client;
using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.Domain.Other;
using ERS_BlockChain.Domain.Singletons;
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
		private static readonly IClientRegisterHandler clientRegisterHandler = new ClientRegisterHandler();
		private static readonly IClientDataBufferHandler clientDataBufferHandler = new ClientDataBufferHandler();
		

		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("Izaberite funkciju rada sa klijentima.");
				Console.WriteLine("1 - Registruj novog klijenta");
				Console.WriteLine("2 - Unesi poruku za slanje u bafer klijenta");
				Console.WriteLine("3 - ");
				Console.WriteLine("x - Povratak na main menu.");
                Console.WriteLine();

                answer = Console.ReadLine();

                Console.WriteLine();

                switch (answer)
				{
					case "1":
						clientRegisterHandler.Handle();
						break;
					case "2":
						clientDataBufferHandler.SendToClientDataBuffer();
						break;
					case "3":
						//TODO
						break;
					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}
	}
}
