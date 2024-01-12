using ERS_BlockChain.Application.Client;
using ERS_BlockChain.BusinessLogic.Client;
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
using ERS_BlockChain.Domain.Entities;

namespace ERS_BlockChain.BusinessLogicTest.Client
{
	[TestFixture]
	public class ClientRegisterHandlerTests
	{
	

		[Test]
		public void Handle_InvalidClientID_DoesNotAddClientToAllClientsList()
		{

			var mockDialogHandler = new Mock<IClientRegisterDialogHandler>();
			mockDialogHandler.Setup(x => x.Handle()).Returns(-1);

			var mockSingleton = new Mock<SmartContractSingleton>();
			var handler = new ClientRegisterHandler(mockDialogHandler.Object);


			handler.Handle();


			ClassicAssert.AreEqual(0, mockSingleton.Object.AllClients.Count);
			StringAssert.DoesNotContain("Novi klijent", GetConsoleOutput());
		}


		private string GetConsoleOutput()
		{
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);
				return sw.ToString().Trim();
			}
		}
	}
}
