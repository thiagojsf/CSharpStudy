using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Collections
{
    public class IEnumerables
    {
        IEnumerable<int> IEnumerableInteiros;

        public IEnumerables()
        {
            IEnumerableInteiros = new List<int>();
            IEnumerableInteiros.Sum(y => y);
        }

    }
}
