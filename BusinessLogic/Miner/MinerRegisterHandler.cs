using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class MinerRegisterHandler : IMinerRegisterHandler
	{
		private static readonly IMinerRegisterDialogHandler minerRegisterDialogHandler = new MinerRegisterDialogHandler();

		public void Register()
		{
			int id = minerRegisterDialogHandler.Handle();
			if (id < 0) { return; }
			SmartContractSingleton.Instance.AllMiners.Add(new MinerEntity(id));
			Console.WriteLine("Novi miner sa idjem " + id + " uspesno registrovan.");
		}
	}
}
