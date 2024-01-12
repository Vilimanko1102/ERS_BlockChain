using ERS_BlockChain.BusinessLogic.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using Moq;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Miner
{
	[TestFixture]
	public class GetMinerIDDialogHandlerTests
	{
		[Test]
		public void GetMinerID_ValidMinerID_ReturnsID()
		{
			
			
			var handler = new GetMinerIDDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("1"));

				
				var result = handler.GetMinerID();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Unesite id minera sa kojim", sw.ToString());
			}
		}

		[Test]
		public void GetMinerID_InvalidMinerID_ReturnsMinusOne()
		{
			var handler = new GetMinerIDDialogHandler();
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("invalid"));

				var result = handler.GetMinerID();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Niste uneli validan id.", sw.ToString());
			}
		}

		[Test]
		public void GetMinerID_NonExistentMinerID_ReturnsMinusOne()
		{
			
			
			var handler = new GetMinerIDDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("1"));

				
				var result = handler.GetMinerID();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Ne postoji miner sa tim idjem", sw.ToString());
			}
		}

		
	}
}
