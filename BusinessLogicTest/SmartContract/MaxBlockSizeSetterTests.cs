using ERS_BlockChain.BusinessLogic.SmartContract;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.SmartContract
{
	[TestFixture]
	public class MaxBlockSizeSetterTests
	{
		[Test]
		public void SetMaxBlockSize_ValidInput_SetsMaxBlockSize()
		{
			
			var setter = new MaxBlockSizeSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("50"));

				
				setter.SetMaxBlockSize();

				
				ClassicAssert.AreEqual("50", ConfigurationManager.AppSettings["MaxBlockSize"]);
				StringAssert.Contains("Unesite novi MaxBlockSize:", sw.ToString());
			}
		}

		[Test]
		public void SetMaxBlockSize_InvalidInput_DoesNotSetMaxBlockSize()
		{
			
			var setter = new MaxBlockSizeSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("invalid"));

				
				setter.SetMaxBlockSize();

				
				
				StringAssert.Contains("Nevalidan unos", sw.ToString());
			}
		}

		
	}
}
