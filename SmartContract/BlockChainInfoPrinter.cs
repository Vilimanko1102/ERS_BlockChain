using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.SmartContract
{
	internal class BlockChainInfoPrinter : IBlockChainInfoPrinter
	{
		public void PrintInfo()
		{
			try
			{
				Console.WriteLine(SmartContractSingleton.Instance.AllMiners[0].BlockChainCopy);
            }
			catch(ArgumentOutOfRangeException e)
			{
                Console.WriteLine("Nema majnera u sistemu, samim tim nema ni BlockChaina koji bi se mogao ispisati.");
            }
			
        }
	}
}
