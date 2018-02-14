using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtschaftssimulation___Lernprojekt {

	abstract class AbstractDerivativePredicter : IPredictable {

		public abstract double Predict(StockExchangeValues values, StockExchangeValue latestValue);

		protected double getDerivative(StockExchangeValue from, StockExchangeValue to) {

			return (double)(to.stockvalue - from.stockvalue) / (to.date.Millisecond - from.date.Millisecond);
		}

	}
}
