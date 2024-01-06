using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class BitcoinAssigner : IBitcoinAssigner
	{
		public void Award(MinerEntity miner)
		{
			miner.BitcoinAmount += double.Parse(ConfigurationManager.AppSettings["ValueOfOneBlock"]);
		}
	}
}
