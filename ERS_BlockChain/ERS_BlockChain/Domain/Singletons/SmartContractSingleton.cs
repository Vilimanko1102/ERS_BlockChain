using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Singletons
{
	public class SmartContractSingleton 
	{
		private static SmartContractSingleton instance = null;

		private SmartContractSingleton()
		{
			AllClients = new List<ClientEntity>();
			AllMiners = new List<MinerEntity>();
			PendingDataToValidate = new List<Data>();
		}

		public static SmartContractSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SmartContractSingleton();
				}
				return instance;
			}
		}


		public List<ClientEntity> AllClients { get; set; }
		public List<MinerEntity> AllMiners { get; set; }
		public List<Data> PendingDataToValidate { get; set; }



	}
}
