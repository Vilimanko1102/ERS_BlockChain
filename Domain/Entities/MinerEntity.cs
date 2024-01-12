using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;
using ERS_BlockChain.Domain.Singletons;
using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.BusinessLogic.Miner;

namespace ERS_BlockChain.Domain.Entities
{
	public class MinerEntity : IEntity<int>
	{
		private static readonly IValidationHandler validationHandler = new ValidationHandler();

		public int MinerId { get; set; }
		public double BitcoinAmount { get; set; } 
		public Thread MinerThread { get; set; }
		public BlockChainSingleton BlockChainCopy { get; set; }

		public BlockEntity CurrentlyValidatingBlock { get; set; }

		
		public MinerEntity() { }

		public MinerEntity(int minerId)
		{
			MinerId = minerId;
			BitcoinAmount = 0.0;
			BlockChainCopy = BlockChainSingleton.Instance;
			CurrentlyValidatingBlock = new BlockEntity();
			MinerThread = new Thread(() => validationHandler.Validate(CurrentlyValidatingBlock, int.Parse(ConfigurationManager.AppSettings["ComplexityOfPOW"])));
			MinerThread.Name = "Miner " + MinerId;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append($"Miner {MinerId}:\nDo sad zaradio {BitcoinAmount}btc putem validiranja blokova.");

			return sb.ToString();
		}

		public int GetId()
		{
			return MinerId;
		}
	}
}
