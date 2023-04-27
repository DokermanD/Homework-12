using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._3
{
    internal class Part4
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            Poem = list.Add("Вот кот,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
        }
    }
}
