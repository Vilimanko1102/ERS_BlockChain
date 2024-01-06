using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Exceptions
{
	public class NoMinersToValidateException : Exception
	{
		public NoMinersToValidateException()
		{
		}

		public NoMinersToValidateException(string message)
			: base(message)
		{
		}

		public NoMinersToValidateException(string message, Exception inner)
			: base(message, inner)
		{
		}

	}
}
