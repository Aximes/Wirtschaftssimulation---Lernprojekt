using System;

namespace Wirtschaftssimulation___Lernprojekt {

	class Vector2 {

		public double x;
		public double y;

		/// <summary>
		/// Erstellt einen neuen Vector.
		/// </summary>
		/// <param name="x">x-Wert des Vectors</param>
		/// <param name="y">y-Wert des Vectors</param>

		public Vector2(double x, double y) {
			this.x = x;
			this.y = y;
		}

		// ADDIEREN

		/// <summary>
		/// Erzeugt einen neuen Vector mit den um x / y erweiterten Werten.
		/// </summary>
		/// <param name="x">Wert der zu dem x-Wert des Vectors addiert werden soll</param>
		/// <param name="y">Wert der zu dem y-Wert des Vectors addiert werden soll</param>
		/// <returns>Neuen, erweiterten Vector</returns>
		public Vector2 Add(double x, double y) {
			return new Vector2(this.x + x, this.y + y);
		}

		/// <summary>
		/// Erzeugt einen neuen Vector der um die Werte des Übergabe-Vectors erweitert wurde.
		/// </summary>
		/// <param name="vec">Vector, dessen Werte addiert werden sollen</param>
		/// <returns>Neuen, erweiterten Vector</returns>
		public Vector2 Add(Vector2 vec) {
			return Add(vec.x, vec.y);
		}

		/// <summary>
		/// Addiert x / y zu den derzeitigen Werten des Vectors.
		/// </summary>
		/// <param name="x">Wert der zu dem x-Wert des Vectors addiert werden soll</param>
		/// <param name="y">Wert der zu dem y-Wert des Vectors addiert werden soll</param>
		public void AddLocal(double x, double y) {
			this.x += x;
			this.y += y;
		}

		/// <summary>
		/// Addiert die Werte des Übergabe-Vectors zum aktuellen Vector.
		/// </summary>
		/// <param name="vec">Übergabe-Vector dessen Werte addiert werden sollen</param>
		public void AddLocal(Vector2 vec) {
			x += vec.x;
			y += vec.y;
		}

		// SUBTRAHIEREN

		/// <summary>
		/// Erzeugt einen neuen Vector dessen Werte um x / y subtrahiert wurden.
		/// </summary>
		/// <param name="x">Zu subtrahierender x-Wert</param>
		/// <param name="y">Zu subtrahierender y-Wert</param>
		/// <returns>Neuer Vector mit subtrahierten Werten</returns>
		public Vector2 Sub(double x, double y) {
			return new Vector2(this.x - x, this.y - y);
		}

		/// <summary>
		/// Erzeugt einen neuen Vector dessen Werte um die des übergebenen Vectors subtrahiert wurden.
		/// </summary>
		/// <param name="vec">Vector um dessen Wert subtrahiert werden soll</param>
		/// <returns>Neuer Vector mit subtrahierten Werten</returns>
		public Vector2 Sub(Vector2 vec) {
			return Sub(vec.x, vec.y);
		}

		/// <summary>
		/// Subtrahiert x / y von den derzeitigen Werten des Vectors.
		/// </summary>
		/// <param name="x">Wert der von dem x-Wert des Vectors subtrahiert werden soll</param>
		/// <param name="y">Wert der von dem y-Wert des Vectors subtrahiert werden soll</param>
		public Vector2 SubLocal(double x, double y) {
			this.x -= x;
			this.y -= y;
			return this;
		}

		/// <summary>
		/// Subtrahiert die Werte des Übergabe-Vectors vom aktuellen Vector.
		/// </summary>
		/// <param name="vec">Übergabe-Vector dessen Werte subtrahiert werden sollen</param>
		public Vector2 SubLocal(Vector2 vec) {
			return SubLocal(vec.x, vec.y);
		}

		// MULTIPLIZIEREN

		/// <summary>
		/// Erzeugt einen neuen Vector dessen Werte mit multi multipliziert wurden.
		/// </summary>
		/// <param name="multi">Multiplikator mit dem der Vector multipliziert werden soll</param>
		/// <returns>Neuer, multiplizierter Vector</returns>
		public Vector2 Mult(double multi) {
			return new Vector2(this.x * multi, this.y * multi);
		}

		/// <summary>
		/// Multipliziert die derzeitigen Werte des Vectors mit multi.
		/// </summary>
		/// <param name="multi">Multiplikator mit dem der Vector multipliziert werden soll</param>
		/// <returns>Multiplizierter Vector</returns>
		public Vector2 MultLocal(double multi) {
			x *= multi;
			y *= multi;
			return this;
		}

		// DIVIDIEREN

		/// <summary>
		/// Erzeugt einen neuen Vector dessen Werte mit divisor dividiert wurden.
		/// </summary>
		/// <param name="divisor">Wert mit dem der Vector dividiert werden soll</param>
		/// <returns>Neuer, dividierter Vector</returns>
		public Vector2 Div(double divisor) {
			return new Vector2(this.x / divisor, this.y / divisor);
		}

		/// <summary>
		/// Dividiert die derzeitigen Werte des Vectors mit divisor.
		/// </summary>
		/// <param name="divisor">Wert mit dem der Vector dividiert werden soll</param>
		/// <returns>Dividierter Vector</returns>
		public Vector2 DivLocal(double divisor) {
			x /= divisor;
			y /= divisor;
			return this;
		}

	}
}
