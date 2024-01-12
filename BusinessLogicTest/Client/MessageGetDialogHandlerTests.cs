using ERS_BlockChain.BusinessLogic.Client;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Client
{
	[TestFixture]
	public class MessageGetDialogHandlerTests
	{
		[Test]
		public void GetMessage_ReturnsUserInput()
		{
			
			MessageGetDialogHandler handler = new MessageGetDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("Test Message"));
				Console.SetOut(sw);

				
				string result = handler.GetMessage();

				
				ClassicAssert.AreEqual("Test Message", result);
				StringAssert.Contains("Unesite poruku za slanje:", sw.ToString());
			}
		}

		
	}
}
