using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtschaftssimulation___Lernprojekt {

	interface IPredictable {

		double Predict(StockExchangeValues values, StockExchangeValue latestValue);

	}

}
