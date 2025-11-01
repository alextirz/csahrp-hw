using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstruments.MusicalInstruments
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; }
        public string Description { get; }
        public string HistoryInfo { get; }

        protected MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            HistoryInfo = history;
        }

        public virtual void Show() => Console.WriteLine($"Name of the instrument: {Name}");
        public virtual void Desc() => Console.WriteLine($"Description: {Description}");
        public virtual void History() => Console.WriteLine($"History: {HistoryInfo}");
    }
}
}
