using System;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    // Meine Klasse
    public class Vector2
    {

        public double x = 0.0;
        public double y = 0.0;

        // Mein Konstruktor
        public Vector2(double VectorX, double VectorY)
        {
            x = VectorX;
            y = VectorY;
        }

        public Vector2 Add(double x, double y)
        {
            return new Vector2(this.x + x, this.y + y);
        }
        public Vector2 AddLocal(double x, double y)
        {
            this.x += x;
            this.y += y;
            return this;
        }

        public Vector2 Add(Vector2 Other)
        {
            return new Vector2(x + Other.x, y + Other.y);
        }

        public Vector2 Subtract(Vector2 Other)
        {
            return new Vector2(x - Other.x, y - Other.y);
        }

        public Vector2 Multiply(double Other)
        {
            return new Vector2(x * Other, y * Other);
        }

        public Vector2 Divide(double Other)
        {
            return new Vector2(x / Other, y / Other);
        }

        public Vector2 AddLocal(Vector2 Other)
        {
            x += Other.x;
            y += Other.y;
            return this;
        }

        public Vector2 SubtractLocal(Vector2 Other)
        {
            x -= Other.x;
            y -= Other.y;
            return this;
        }

        public Vector2 MultiplyLocal(double Other)
        {
            x *= Other;
            y *= Other;
            return this;
        }

        public Vector2 DivideLocal(double Other)
        {
            x /= Other;
            y /= Other;
            return this;
        }

        public double getLengthSquared()
        {
            return Math.Pow(this.x, 2) + Math.Pow(this.y, 2);
        }

        public double getLength()
        {
            return Math.Sqrt(getLengthSquared());
        }

        public double getDistanceTo(Vector2 Other)
        {
            return Other.Subtract(this).getLength();
        }

        public override string ToString()
        {
            return x + ", " + y;
        }
    }
}