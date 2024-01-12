using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Singletons
{
	public class SmartContractSingleton 
	{
		private static IBlockCreator blockCreator = new BlockCreator();

		private static SmartContractSingleton instance = null;

		public SmartContractSingleton()
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
			set { instance = value; }
		}


		public List<ClientEntity> AllClients { get; set; }
		public List<MinerEntity> AllMiners { get; set; }
		public List<Data> PendingDataToValidate { get; set; }


		public IBlockCreator BlockCreator { get { return blockCreator; } }



	}
}
