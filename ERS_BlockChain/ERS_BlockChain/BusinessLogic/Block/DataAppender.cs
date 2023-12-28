using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Block
{
	public class DataAppender : IDataAppender
	{
		public BlockEntity Block { get; set; }

		public DataAppender(BlockEntity block) 
		{
			this.Block = block;
		}
		public string AppendAllData()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(Block.SelfID);
			sb.Append(Block.PreviousID);
			foreach(Data d in Block.BlockData)
			{
				sb.Append(d);
			}
			sb.Append(Block.Nonce);

			return sb.ToString();
		}
	}
}
