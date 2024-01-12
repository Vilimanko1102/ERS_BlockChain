using ERS_BlockChain.BusinessLogic.Miner;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogicTest.Miner
{
	[TestFixture]
	public class TargetStringBuilderTests
	{
		[Test]
		public void GetTargetString_CorrectlyBuildsTargetString()
		{
			
			var targetStringBuilder = new TargetStringBuilder();

			
			var result = targetStringBuilder.GetTargetString(5);

			
			ClassicAssert.AreEqual("00000", result);
			
		}

		[Test]
		public void GetTargetString_ZeroPOWComplexity_ReturnsEmptyString()
		{
			
			var targetStringBuilder = new TargetStringBuilder();

			
			var result = targetStringBuilder.GetTargetString(0);

			
			ClassicAssert.AreEqual(string.Empty, result);
			
		}

		
	}
}
