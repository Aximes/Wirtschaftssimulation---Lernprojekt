
namespace Wirtschaftssimulation___Lernprojekt {

	class SimpleDerivatePredicter : AbstractDerivativePredicter {

		public override double Predict(StockExchangeValues values, StockExchangeValue latestValue) {
			return (getDerivative(values.GetPrevious(latestValue), latestValue)/30.0);
			
		}

	}
}
