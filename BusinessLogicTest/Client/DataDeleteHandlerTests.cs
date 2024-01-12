using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
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
	public class DataDeleteHandlerTests
	{
		[Test]
		public void Delete_RemovesDataFromClient()
		{
			
			var dataToDelete = new List<Data>
			{
				new Data(1, "Message1", DateTime.MinValue),
				new Data(2, "Message2", DateTime.MinValue),
            
			};

			var client = new ClientEntity
			{
				DataToSend = new List<Data>
				{
					new Data(1, "Message1", DateTime.MinValue),
					new Data(2, "Message2", DateTime.MinValue),
					new Data(3, "Message3", DateTime.MinValue),
                
				}
			};

			var handler = new DataDeleteHandler();
			handler.DataToDelete = new List<Data>(dataToDelete);

			
			handler.Delete(client);

			
			ClassicAssert.AreEqual(3, client.DataToSend.Count);
			ClassicAssert.IsFalse(client.DataToSend.Contains(dataToDelete[0]));
			ClassicAssert.IsFalse(client.DataToSend.Contains(dataToDelete[1]));
			
		}

		[Test]
		public void Delete_EmptyDataToDeleteList_NoChangeInClientData()
		{
			
			var client = new ClientEntity
			{
				DataToSend = new List<Data>
			{
				new Data(1, "Message1"),
				new Data(2, "Message2"),
               
            }
			};

			var handler = new DataDeleteHandler();

			
			handler.Delete(client);

			
			ClassicAssert.AreEqual(2, client.DataToSend.Count);
			
		}

		
	}
}
