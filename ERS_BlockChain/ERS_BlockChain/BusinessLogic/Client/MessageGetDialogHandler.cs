using ERS_BlockChain.Application.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class MessageGetDialogHandler : IMessageGetDialogHandler
	{
		public string GetMessage()
		{
			Console.WriteLine("Unesite poruku za slanje: ");
			return Console.ReadLine();
		}
	}
}
