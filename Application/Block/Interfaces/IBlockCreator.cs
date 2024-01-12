using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Block.Interfaces
{
	public interface IBlockCreator
	{
		BlockEntity InitializeBlock(List<Data> data);
	}
}
