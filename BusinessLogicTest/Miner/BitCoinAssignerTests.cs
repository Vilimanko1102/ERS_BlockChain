using ERS_BlockChain.BusinessLogic.Miner;
using ERS_BlockChain.Domain.Entities;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Miner
{
	[TestFixture]
	public class BitcoinAssignerTests
	{
		[Test]
		public void Award_CorrectlyUpdatesBitcoinAmount()
		{
			
			var mockMiner = new Mock<MinerEntity>();
			mockMiner.SetupAllProperties();

			var bitcoinAssigner = new BitcoinAssigner();

		
			ConfigurationManager.AppSettings["ValueOfOneBlock"] = "10.0";

		
			bitcoinAssigner.Award(mockMiner.Object);

			
			ClassicAssert.AreEqual(10.0, mockMiner.Object.BitcoinAmount);
			
		}

		
	}
}
