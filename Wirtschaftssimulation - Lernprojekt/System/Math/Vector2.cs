using System;

namespace Wirtschaftssimulation___Lernprojekt.System.Math
{
    // Meine Klasse
    public class Vector2
    {

        public double x = 0.0;
        public double y = 0.0;
        public Double doubleResult;

        // Mein Konstruktor
        public Vector2(double VectorX, double VectorY)
        {
            x = VectorX;
            y = VectorY;
        }

        // Meine Methode zum Addieren eines fremden Vectors "Other"
        public Vector2 Add(Vector2 Other)
        {
            // Vektor2 wird addiert
            return new Vector2(x + Other.x, y + Other.y);
        }

        // Meine Methode zum Subtrahieren eines fremden Vectors "Other"
        public Vector2 Subtract(Vector2 Other)
        {
            // Vector2 wird subtrahiert
            return new Vector2(x - Other.x, y - Other.y);
        }

        public Vector2 Multiply(Double Other)
        {
            return new Vector2(x * Other, y * Other);
        }

        public Vector2 Divide(Double Other)
        {
            return new Vector2(x / Other, y / Other);
        }
    }
}