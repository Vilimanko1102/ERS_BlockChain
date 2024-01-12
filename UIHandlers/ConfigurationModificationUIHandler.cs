using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.BusinessLogic.SmartContract;
using ERS_BlockChain.UIHandlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.UIHandlers
{
	internal class ConfigurationModificationUIHandler : IUIHandler
	{
		private static readonly IValueOfOneBlockSetter valueOfOneBlockSetter = new ValueOfOneBlockSetter();
		private static readonly IComplexityOfPOWSetter complexityOfPOWSetter = new ComplexityOfPOWSetter();
		private static readonly IMaxBlockSizeSetter maxBlockSizeSetter = new MaxBlockSizeSetter();	
		public void HandleUI()
		{
			string answer;

			do
			{
				Console.WriteLine("\nIzaberite parametar koji zelite da modifikujete.");
				Console.WriteLine("1 - MaxBlockSize (trenutno: " + ConfigurationManager.AppSettings["MaxBlockSize"] + " )");
				Console.WriteLine("2 - ComplexityOfPOW (trenutno: " + ConfigurationManager.AppSettings["ComplexityOfPOW"] + " )");
				Console.WriteLine("3 - ValueOfOneBlock (trenutno: " + ConfigurationManager.AppSettings["ValueOfOneBlock"] + " )");
				Console.WriteLine("x - Povratak na smart contract meni.");
				Console.WriteLine();

				answer = Console.ReadLine();

				Console.WriteLine();

				switch (answer)
				{
					case "1":
						maxBlockSizeSetter.SetMaxBlockSize();
						break;
					case "2":
						complexityOfPOWSetter.SetComplexityOfPOW();
						break;
					case "3":
						valueOfOneBlockSetter.SetValueOfOneBlock();
						break;
					

					default:
						break;

				}

			} while (!answer.ToUpper().Equals("X"));
		}
	}
}
