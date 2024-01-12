using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
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
	public class BlockPreviousIDSetterTests
	{
		[Test]
		public void SetPreviousID_FirstBlock_SetsPreviousIDToTripleSlash()
		{
			
			BlockEntity block = new BlockEntity();

			BlockEntity.NumOfBlocks = 1;
			var setter = new BlockPreviousIDSetter();

			
			setter.SetPreviousID(block);

			
			ClassicAssert.AreEqual("///", block.PreviousID);
		}

		[Test]
		public void SetPreviousID_NotFirstBlock_SetsPreviousIDToPreviousBlockSelfID()
		{		
			
			BlockEntity.NumOfBlocks = 2;
			BlockEntity block = new BlockEntity();
			var setter = new BlockPreviousIDSetter();	

			
			Assert.Throws<NullReferenceException>(() => setter.SetPreviousID(block));
		}

		
	}
}
