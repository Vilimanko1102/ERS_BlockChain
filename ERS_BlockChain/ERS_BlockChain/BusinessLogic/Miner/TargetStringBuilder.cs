using ERS_BlockChain.Application.Miner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class TargetStringBuilder : ITargetStringBuilder
	{
		public string GetTargetString(int POWComplexity)
		{
			StringBuilder sb = new StringBuilder();

			for(int i = 0; i < POWComplexity; i++)
			{
				sb.Append('0');
			}

			return sb.ToString();
		}
	}
}
