using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._3
{
    public class Part1
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            Poem = list.Add("Вот дом,\r\nКоторый построил Джек.");
        }
    }
}
