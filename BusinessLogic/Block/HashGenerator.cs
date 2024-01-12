using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Block
{
	public class HashGenerator : IHashGenerator
	{
		public IDataAppender DataAppender { get; set; }

		public HashGenerator(IDataAppender dataAppender)
		{
			this.DataAppender = dataAppender;
		}

		public string GenerateHash()
		{
			var crypt = new SHA256Managed();
			string hash = String.Empty;
			byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(DataAppender.AppendAllData()));
			foreach (byte theByte in crypto)
			{
				hash += theByte.ToString("x2");
			}
			return hash;
		}
	}
}
