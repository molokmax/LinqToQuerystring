namespace LinqToQueryString.Tests
{
    using System;
    using System.Collections.Generic;

    public class ConcreteTimeClass : IComparable<ConcreteTimeClass>
    {
        public ConcreteTimeClass()
        {
            Date = DateTime.UtcNow;
            Time = DateTime.UtcNow.TimeOfDay;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public bool Complete { get; set; }

        public int Age { get; set; }

        public List<EdgeCaseClass> Children { get; set; }

        public IEnumerable<string> StringCollection { get; set; }

        public long Population { get; set; }

        public double Value { get; set; }

        public float Cost { get; set; }

        public byte Code { get; set; }

        public Guid Guid { get; set; }

        public decimal Score { get; set; }

        public int CompareTo(ConcreteTimeClass other)
        {
            return String.CompareOrdinal(this.Name, other.Name);
        }
    }
}
