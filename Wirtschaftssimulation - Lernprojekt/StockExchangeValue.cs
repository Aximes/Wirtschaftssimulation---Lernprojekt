using System;
using System.Numerics;

namespace Wirtschaftssimulation___Lernprojekt {

	class StockExchangeValue {

		public DateTime date;
		public BigInteger stockvalue;

		public StockExchangeValue(DateTime date, BigInteger stockvalue) {
			this.date = date;
			this.stockvalue = stockvalue;
		}
	}
}
