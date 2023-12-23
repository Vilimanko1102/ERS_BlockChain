using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Entities
{
	public class MinerEntity : IEntity<int>
	{
		public int MinerId { get; set; }
		public double BitcoinAmount { get; set; }

		public MinerEntity() { }

		public MinerEntity(int minerId)
		{
			MinerId = minerId;
			BitcoinAmount = 0.0;
		}

		public int GetId()
		{
			return MinerId;
		}
	}
}
