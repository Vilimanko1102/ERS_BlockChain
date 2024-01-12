using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.Domain.Entities;
using Moq;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERS_BlockChain.Domain.Singletons;

namespace ERS_BlockChain.BusinessLogicTest.Client
{
	[TestFixture]
	public class ClientRegisterDialogHandlerTests
	{
		[Test]
		public void Handle_ValidClientID_ReturnsClientID()
		{
			
			

			ClientRegisterDialogHandler handler = new ClientRegisterDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("1"));
				Console.SetOut(sw);

				
				int result = handler.Handle();

				
				ClassicAssert.AreEqual(1, result);
				StringAssert.Contains("Unesite ID klijenta:", sw.ToString());
			}
		}

		[Test]
		public void Handle_ExistingClientID_ReturnsNegativeOne()
		{
			
		

			ClientRegisterDialogHandler handler = new ClientRegisterDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("1"));
				Console.SetOut(sw);

				
				int result = handler.Handle();

				
				ClassicAssert.AreEqual(1, result);
				
			}
		}

		[Test]
		public void Handle_InvalidClientID_ReturnsNegativeOne()
		{
			
			

			ClientRegisterDialogHandler handler = new ClientRegisterDialogHandler();

			
			using (var sw = new StringWriter())
			{
				Console.SetIn(new StringReader("invalid_input"));
				Console.SetOut(sw);

				
				int result = handler.Handle();

				
				ClassicAssert.AreEqual(-1, result);
				StringAssert.Contains("Niste uneli validan ID. (morate uneti broj)", sw.ToString());
			}
		}

		
	}
}
