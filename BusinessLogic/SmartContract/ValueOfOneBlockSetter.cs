using ERS_BlockChain.Application.SmartContract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.SmartContract
{
	internal class ValueOfOneBlockSetter : IValueOfOneBlockSetter
	{
		public void SetValueOfOneBlock()
		{
			double val;
			try
			{
				Console.WriteLine("Unesite novi ValueOfOneBlock: ");
				val = double.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Nevalidan unos");
				return;
			}
			ConfigurationManager.AppSettings["ValueOfOneBlock"] = val.ToString();
		}
	}
}
