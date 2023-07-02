using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4Odev5
{
    internal class MyDictionary<Tkey, TValue>
    {
        private List<Tkey> keys;
        private List<TValue> values;

        public MyDictionary()
        {
            keys= new List<Tkey>();
            values= new List<TValue>();
        }

        public void Add(Tkey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public TValue GetValue(Tkey key)
    }
}
