using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Utility
{
	public static class ConversionUtil
	{
		public static string HexadecimalToBinary(string hexString)
		{
			StringBuilder sb = new StringBuilder();

			foreach (char c in hexString)
			{
				switch (c)
				{
					case '0':
						sb.Append("0000");
						break;
					case '1':
						sb.Append("0001");
						break;
					case '2':
						sb.Append("0010");
						break;
					case '3':
						sb.Append("0011");
						break;
					case '4':
						sb.Append("0100");
						break;
					case '5':
						sb.Append("0101");
						break;
					case '6':
						sb.Append("0110");
						break;
					case '7':
						sb.Append("0111");
						break;
					case '8':
						sb.Append("1000");
						break;
					case '9':
						sb.Append("1001");
						break;
					case 'a':
						sb.Append("1010");
						break;
					case 'b':
						sb.Append("1011");
						break;
					case 'c':
						sb.Append("1100");
						break;
					case 'd':
						sb.Append("1101");
						break;
					case 'e':
						sb.Append("1110");
						break;
					case 'f':
						sb.Append("1111");
						break;

				}

			}
			return sb.ToString();
		}
	}
}
