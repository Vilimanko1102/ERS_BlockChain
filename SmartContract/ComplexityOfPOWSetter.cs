using ERS_BlockChain.Application.SmartContract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.SmartContract
{
	internal class ComplexityOfPOWSetter : IComplexityOfPOWSetter
	{
		public void SetComplexityOfPOW()
		{
			int POW;
			try
			{
				Console.WriteLine("Unesite novi ComplexityOfPOW: ");
				POW = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Nevalidan unos");
				return;
			}
			ConfigurationManager.AppSettings["ComplexityOfPOW"] = POW.ToString();
		}
	}
}
