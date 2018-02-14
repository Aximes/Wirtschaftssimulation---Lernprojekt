using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtschaftssimulation___Lernprojekt {

	class StockExchange {

		public Dictionary<String, StockExchangeValues> stockMap;

		public StockExchange() {
			stockMap = new Dictionary<string, StockExchangeValues>();
		}

	}
}
