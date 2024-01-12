using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.Domain.Entities;
using Moq;
using NUnit.Framework;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Client
{
	[TestFixture]
	public class GetClientIDDialogHandlerTests
	{
		[Test]
		public void GetClientID_ValidClientID_ReturnsClientID()
		{
			
			

			GetClientIDDialogHandler handler = new GetClientIDDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("2"));
				Console.SetOut(sw);

				
				int result = handler.GetClientID();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Unesite id klijenta", sw.ToString());
			}
		}

		[Test]
		public void GetClientID_InvalidClientID_ReturnsNegativeOne()
		{
			
			

			GetClientIDDialogHandler handler = new GetClientIDDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("invalid_input"));
				Console.SetOut(sw);

			
				int result = handler.GetClientID();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Niste uneli validan id.", sw.ToString());
				
			}
		}

		
	}
}
