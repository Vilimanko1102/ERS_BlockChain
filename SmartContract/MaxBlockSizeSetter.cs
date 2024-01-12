using ERS_BlockChain.Application.SmartContract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.SmartContract
{
	internal class MaxBlockSizeSetter : IMaxBlockSizeSetter
	{
		public void SetMaxBlockSize()
		{
			int maxBlockSize;
			try
			{
                Console.WriteLine("Unesite novi MaxBlockSize: ");
				maxBlockSize = int.Parse(Console.ReadLine());
            }
			catch
			{
                Console.WriteLine("Nevalidan unos");
				return;
            }
			ConfigurationManager.AppSettings["MaxBlockSize"] = maxBlockSize.ToString();
		}
	}
}
