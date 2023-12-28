using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Entities
{
	public class BlockEntity : IEntity<string>
	{
		public string SelfID { get; set; }
		public string PreviousID { get; set; }
		public List<Data> BlockData { get; set; }

		public int Nonce { get; set; }

		private static int numOfBlocks = 0;

		//Dilema: Da li je nonce polje klase Block ili ima veze sa Minerom?

		public BlockEntity() { }

		public BlockEntity(List<Data> blockData)
		{
			BlockData = blockData;

			if(numOfBlocks == 0)
			{
				PreviousID = "///";
			}
			else
			{
				//TODO
			}
			numOfBlocks++;
			Nonce = 0;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SelfID: " + SelfID + "\n");
			sb.Append("PreviousID: " + PreviousID + "\n");
			foreach (Data data in BlockData)
			{
				sb.Append(data + "\n");
			}

			return sb.ToString();
		}

		public string GetId()
		{
			return SelfID;
		}
	}
}
