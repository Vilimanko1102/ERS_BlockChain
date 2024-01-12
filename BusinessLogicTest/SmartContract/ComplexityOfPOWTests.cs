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
	public class ComplexityOfPOWSetterTests
	{
		[Test]
		public void SetComplexityOfPOW_ValidInput_SetsComplexityOfPOW()
		{
			
			var setter = new ComplexityOfPOWSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("5"));

				
				setter.SetComplexityOfPOW();

				
				ClassicAssert.AreEqual("5", ConfigurationManager.AppSettings["ComplexityOfPOW"]);
				StringAssert.Contains("Unesite novi ComplexityOfPOW:", sw.ToString());
			}
		}

		[Test]
		public void SetComplexityOfPOW_InvalidInput_DoesNotSetComplexityOfPOW()
		{
			
			var setter = new ComplexityOfPOWSetter();

			
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				Console.SetIn(new StringReader("invalid"));

				
				setter.SetComplexityOfPOW();

				
				
				StringAssert.Contains("Nevalidan unos", sw.ToString());
			}
		}

		
	}
}
