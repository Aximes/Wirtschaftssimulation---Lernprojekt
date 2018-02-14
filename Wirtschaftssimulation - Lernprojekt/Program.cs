using System;
using Wirtschaftssimulation___Lernprojekt.Math;

namespace Wirtschaftssimulation___Lernprojekt {

	class Program {

		static void Main(string[] args) {

			//StockExchange stocks = new StockExchange();
			StockExchangeValues sido = new StockExchangeValues();
			StockExchangeValue val1 = new StockExchangeValue(DateTime.Now, 999999999);
			StockExchangeValue val2 = new StockExchangeValue(DateTime.Now.AddTicks(200), 56994838);
			StockExchangeValue val3 = new StockExchangeValue(DateTime.Now.AddTicks(400), 0);
			
			sido.AddValue(val1);
			sido.AddValue(val2);
			sido.AddValue(val3);

			StockExchangeValue v1 = sido.GetPrevious(val2);
			StockExchangeValue v2 = sido.GetNext(val2);
			// Liebe Grüße an Darkiii <333
		}
	} 
}
