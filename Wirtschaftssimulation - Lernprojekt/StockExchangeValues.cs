using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtschaftssimulation___Lernprojekt {

	class StockExchangeValues {

		public SortedDictionary<DateTime, StockExchangeValue> values;

		public StockExchangeValues() {
			values = new SortedDictionary<DateTime, StockExchangeValue>();
		}

		public StockExchangeValues AddValue(StockExchangeValue v) {
			values.Add(v.date, v);
			return this;
		}

		public StockExchangeValue GetPrevious(StockExchangeValue v) {
			int index = getIndex(v);
			if (index <= 0) {
				return null;
			}
			return values.ElementAt(index - 1).Value;
		}

		public StockExchangeValue GetNext(StockExchangeValue v) {
			int index = getIndex(v);
			if (index >= values.Count-1) {
				return null;
			}
			return values.ElementAt(index + 1).Value;
		}

		private int getIndex(StockExchangeValue v) {
			if (!values.ContainsValue(v)) {
				throw new StockExchangeValueNotFoundException();
			}
			int index = -1;
			foreach (KeyValuePair<DateTime, StockExchangeValue> entry in values) {
				index++;
				if (entry.Value == v) {
					break;
				}
			}
			return index;
		}

	}
}
