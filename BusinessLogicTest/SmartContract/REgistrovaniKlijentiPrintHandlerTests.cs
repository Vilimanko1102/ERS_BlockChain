using ERS_BlockChain.BusinessLogic.SmartContract;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.SmartContract
{
	[TestFixture]
	public class RegistratedClientsInfoPrinterTests
	{
		[Test]
		public void PrintInfo_CorrectlyPrintsClientInfo()
		{
			
			var printer = new RegistratedClientsInfoPrinter();

	
			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);

		
				printer.PrintInfo();

				
				string expectedOutput = "Svi registrovani klijenti: \n\r\n";
				ClassicAssert.AreEqual(expectedOutput, sw.ToString());

			}
		}

		
	}
}
