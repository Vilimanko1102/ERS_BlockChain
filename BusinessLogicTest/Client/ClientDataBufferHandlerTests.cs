using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.BusinessLogic.Client;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Client
{
	[TestFixture]
	public class ClientDataBufferHandlerTests
	{
		[Test]
		public void SendToClientDataBuffer_ClientIDLessThanZero_NoDataAdded()
		{
			
			Mock<IGetClientIDDialogHandler> mockGetClientIDDialogHandler = new Mock<IGetClientIDDialogHandler>();
			mockGetClientIDDialogHandler.Setup(x => x.GetClientID()).Returns(-1);

			Mock<IFindClientByID> mockFindClientByIDQuery = new Mock<IFindClientByID>();
			mockFindClientByIDQuery.Setup(x => x.Find(-1)).Returns(new Domain.Entities.ClientEntity());

			Mock<IMessageGetDialogHandler> mockMessageGetDialogHandler = new Mock<IMessageGetDialogHandler>();
			mockMessageGetDialogHandler.Setup(x => x.GetMessage()).Returns(string.Empty);

			ClientDataBufferHandler clientDataBufferHandler = new ClientDataBufferHandler(
				mockFindClientByIDQuery.Object,
				mockGetClientIDDialogHandler.Object,
				mockMessageGetDialogHandler.Object
			);

			
			clientDataBufferHandler.SendToClientDataBuffer();

			
			mockFindClientByIDQuery.Verify(x => x.Find(It.IsAny<int>()), Times.Never);

		
			
		}

		
	}
}
