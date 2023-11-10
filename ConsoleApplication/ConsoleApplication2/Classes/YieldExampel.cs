using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class YieldExampel : IEnumerable<int>
    //class YieldExampel : IEnumerable
    {
        public IEnumerator Get100Enumerator()
        {
            for (int i = 1; i < 101; i++)
                yield return i ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Get100Enumerator();
        }

        public IEnumerator<int> Get10Enumerator()
        {
            for (int i = 0; i < 11; i++)
                yield return i * i;
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return Get10Enumerator();
        }
    }
}
