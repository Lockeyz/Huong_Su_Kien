using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh2_0902_22
{
    internal class CustomListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
