using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Block.Interfaces
{
	public interface IDataAppender
	{
		BlockEntity Block { get; set; }
		string AppendAllData();
	}
}
