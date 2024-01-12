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
	public class ValueOfOneBlockSetterTests
	{
		[Test]
		public void SetValueOfOneBlock_ValidInput_SetsValueOfOneBlock()
		{
			
			var setter = new ValueOfOneBlockSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("10.5"));

				
				setter.SetValueOfOneBlock();

				
				ClassicAssert.AreEqual("10.5", ConfigurationManager.AppSettings["ValueOfOneBlock"]);
				StringAssert.Contains("Unesite novi ValueOfOneBlock:", sw.ToString());
			}
		}

		[Test]
		public void SetValueOfOneBlock_InvalidInput_DoesNotSetValueOfOneBlock()
		{
			
			var setter = new ValueOfOneBlockSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("invalid"));

				
				setter.SetValueOfOneBlock();

			
				
				StringAssert.Contains("Nevalidan unos", sw.ToString());
			}
		}

		
	}
}
