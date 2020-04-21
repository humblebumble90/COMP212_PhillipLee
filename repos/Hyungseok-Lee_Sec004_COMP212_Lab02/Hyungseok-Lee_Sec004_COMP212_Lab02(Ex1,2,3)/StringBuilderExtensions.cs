using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyungseok_Lee_Sec004_COMP212_Lab02
{
    class StringBuilderExtensions
    {
        public int Count(StringBuilder sb)
        {
            int count = 0;
            count = sb.ToString().Count();
            return count;
        }
    }
}
