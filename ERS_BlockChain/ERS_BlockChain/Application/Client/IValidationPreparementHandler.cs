using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Client
{
	internal interface IValidationPreparementHandler
	{
		BlockEntity PrepareForValidation();
	}
}
