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

		public bool Validated { get; set; }

		public static int NumOfBlocks = 0;

	

		public BlockEntity() { }

		public BlockEntity(BlockEntity block)
		{
			SelfID = block.SelfID;
			PreviousID = block.PreviousID;
			BlockData = block.BlockData;
			Nonce = block.Nonce;
			Validated = block.Validated;
		}

		public BlockEntity(List<Data> blockData)
		{
			BlockData = blockData;
			NumOfBlocks++;
			Nonce = 0;
			Validated = false;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Block Info:\n");
			sb.Append("SelfID: " + SelfID + "\n");
			sb.Append("PreviousID: " + PreviousID + "\n");
			foreach (Data data in BlockData)
			{
				sb.Append(data);
			}

			return sb.ToString();
		}

		public string GetId()
		{
			return SelfID;
		}
	}
}
