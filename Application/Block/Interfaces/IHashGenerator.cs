﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Block.Interfaces
{
	public interface IHashGenerator
	{
		IDataAppender DataAppender { get; set; }
		string GenerateHash();
	}
}
