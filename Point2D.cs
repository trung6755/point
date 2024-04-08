using System;

namespace point
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Method to calculate the distance between two points
        public double CalculateDistance(Point2D otherPoint)
        {
            double dx = X - otherPoint.X;
            double dy = Y - otherPoint.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Method to move the point by specified offsets
        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        // Override ToString() method for better representation
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Point3D : Point2D
    {
        private float Z;

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.Z = z;
        }

        public float GetZ()
        {
            return Z;
        }

        public void SetZ(float z)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
