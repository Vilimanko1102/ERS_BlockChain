using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.BusinessLogic.Block;
using Moq;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Block
{
	[TestFixture]
	public class HashGeneratorTests
	{
		[Test]
		public void GenerateHash_CorrectlyGeneratesHash()
		{
			
			var mockDataAppender = new Mock<IDataAppender>();
			mockDataAppender.Setup(x => x.AppendAllData()).Returns("TestData123");

			var hashGenerator = new HashGenerator(mockDataAppender.Object);

			
			var result = hashGenerator.GenerateHash();

			
			StringAssert.AreEqualIgnoringCase("80a3f4165afbad8e1f1371901e219642bae69062816b67229bbd2a93cf2c5756", result);
			
		}

		
	}
}
