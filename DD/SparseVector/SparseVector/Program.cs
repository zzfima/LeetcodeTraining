namespace SparseVector
{
    using System;
    using System.Collections.Generic;

    public class SparseVector
    {
        private readonly Dictionary<int, double> _values;
        public int Dimension { get; }

        // Constructor
        public SparseVector(int dimension)
        {
            if (dimension <= 0)
                throw new ArgumentException("Dimension must be greater than 0.");

            Dimension = dimension;
            _values = new Dictionary<int, double>();
        }

        // Add or update a value at a specific index
        public void SetValue(int index, double value)
        {
            if (index < 0 || index >= Dimension)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            if (value == 0)
            {
                _values.Remove(index); // Remove zero values to keep sparsity
            }
            else
            {
                _values[index] = value;
            }
        }

        // Get a value at a specific index
        public double GetValue(int index)
        {
            if (index < 0 || index >= Dimension)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            return _values.TryGetValue(index, out var value) ? value : 0.0;
        }

        // Calculate dot product with another sparse vector
        public double DotProduct(SparseVector other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (Dimension != other.Dimension)
                throw new ArgumentException("Vectors must have the same dimension.");

            double dotProduct = 0.0;

            // Iterate over the smaller dictionary to optimize the computation
            var smaller = _values.Count <= other._values.Count ? _values : other._values;
            var larger = smaller == _values ? other._values : _values;

            foreach (var pair in smaller)
            {
                if (larger.TryGetValue(pair.Key, out var value))
                {
                    dotProduct += pair.Value * value;
                }
            }

            return dotProduct;
        }

        // Override ToString for visualization
        public override string ToString()
        {
            var elements = new List<string>();
            foreach (var pair in _values)
            {
                elements.Add($"({pair.Key}: {pair.Value})");
            }
            return $"SparseVector: {string.Join(", ", elements)}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new SparseVector(5);
            vector1.SetValue(0, 1.5);
            vector1.SetValue(3, 2.0);

            var vector2 = new SparseVector(5);
            vector2.SetValue(1, 3.0);
            vector2.SetValue(3, 4.0);

            Console.WriteLine(vector1);
            Console.WriteLine(vector2);

            double dotProduct = vector1.DotProduct(vector2);
            Console.WriteLine($"Dot Product: {dotProduct}");
            Console.Read();
        }
    }
}
