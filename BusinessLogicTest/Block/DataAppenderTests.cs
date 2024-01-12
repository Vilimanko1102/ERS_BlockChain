using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Block
{
	[TestFixture]
	public class DataAppenderTests
	{
		[Test]
		public void AppendAllData_Empty()
		{

			BlockEntity blockEntity = new BlockEntity(new List<Data>());

			var dataAppender = new DataAppender(blockEntity);


			var result = dataAppender.AppendAllData();

	
			ClassicAssert.AreEqual("0", result);
		
		}

		[Test]
		public void AppendAllData_NormalFunctioning()
		{
			
			BlockEntity blockEntity = new BlockEntity(new List<Data>() { new Data(1, "p1", DateTime.MinValue)});

			var dataAppender = new DataAppender(blockEntity);

			
			var result = dataAppender.AppendAllData();
			
			
			ClassicAssert.AreEqual("Client 1 sent \"p1\" at 1/1/0001 12:00:00 AM\n0", result);
			
		}

		
	}
}
