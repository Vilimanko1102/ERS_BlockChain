using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Client
{
	internal interface IDataDeleteHandler
	{
		List<Data> DataToDelete { get; set; }
		void Delete(ClientEntity client);
	}
}
