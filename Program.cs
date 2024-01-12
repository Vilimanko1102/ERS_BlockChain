using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using ERS_BlockChain.Domain.Singletons;
using ERS_BlockChain.UIHandlers;
using ERS_BlockChain.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain
{
	internal class Program
	{
		private static readonly MainUIHandler mainUIHandler = new MainUIHandler();	
		static void Main(string[] args)
		{
            mainUIHandler.HandleUI();
        }
	}
}
