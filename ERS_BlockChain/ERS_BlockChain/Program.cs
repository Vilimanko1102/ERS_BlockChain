using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using ERS_BlockChain.Domain.Singletons;
using ERS_BlockChain.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain
{
	internal class Program
	{
		private static readonly IBlockCreator blockCreator = new BlockCreator();	
		static void Main(string[] args)
		{
			List<Data> data1 = new List<Data>();
			data1.Add(new Data(1, "message1"));
			data1.Add(new Data(2, "message2"));
			
			BlockEntity block1 = blockCreator.InitializeBlock(data1);

            Console.WriteLine(block1.SelfID);
            Console.WriteLine(ConversionUtil.HexadecimalToBinary(block1.SelfID));

            Console.ReadLine();
        }
	}
}
