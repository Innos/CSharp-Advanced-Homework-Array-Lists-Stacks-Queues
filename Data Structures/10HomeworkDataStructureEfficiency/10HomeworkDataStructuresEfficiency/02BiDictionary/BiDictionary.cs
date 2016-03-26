namespace _02BiDictionary
{
    using System.Collections.Generic;
    using System.Linq;

    public class BiDictionary<TK1, TK2, T>
    {
        private Dictionary<TK1, List<T>> valuesByFirstKey;
        private Dictionary<TK2, List<T>> valuesBySecondKey;
        private Dictionary<Pair<TK1, TK2>, List<T>> valuesByBothKeys;

        public BiDictionary()
        {
            this.valuesByBothKeys = new Dictionary<Pair<TK1, TK2>, List<T>>();
            this.valuesByFirstKey = new Dictionary<TK1, List<T>>();
            this.valuesBySecondKey = new Dictionary<TK2, List<T>>();
        } 

        public void Add(TK1 key1, TK2 key2, T value)
        {
            var pair = new Pair<TK1, TK2>(key1, key2);
            if (!this.valuesByBothKeys.ContainsKey(pair))
            {
                this.valuesByBothKeys.Add(pair, new List<T>());
            }

            this.valuesByBothKeys[pair].Add(value);

            if (!this.valuesByFirstKey.ContainsKey(key1))
            {
                this.valuesByFirstKey.Add(key1, new List<T>());
            }

            this.valuesByFirstKey[key1].Add(value);

            if (!this.valuesBySecondKey.ContainsKey(key2))
            {
                this.valuesBySecondKey.Add(key2, new List<T>());
            }

            this.valuesBySecondKey[key2].Add(value);
        }

        public IEnumerable<T> Find(TK1 key1, TK2 key2)
        {
            var pair = new Pair<TK1, TK2>(key1, key2);
            if (!this.valuesByBothKeys.ContainsKey(pair))
            {
                return Enumerable.Empty<T>();
            }

            return this.valuesByBothKeys[pair];
        }

        public IEnumerable<T> FindByKey1(TK1 key1)
        {
            if (!this.valuesByFirstKey.ContainsKey(key1))
            {
                throw new KeyNotFoundException("The specified key was not found in the dictionary!");
            }

            return this.valuesByFirstKey[key1];
        }

        public IEnumerable<T> FindByKey2(TK2 key2)
        {
            if (!this.valuesBySecondKey.ContainsKey(key2))
            {
                throw new KeyNotFoundException("The specified key was not found in the dictionary!");
            }

            return this.valuesBySecondKey[key2];
        }

        public bool Remove(TK1 key1, TK2 key2)
        {
            var pair = new Pair<TK1, TK2>(key1, key2);
            if (!this.valuesByBothKeys.ContainsKey(pair))
            {
                return false;
            }

            foreach (var entry in this.valuesByBothKeys[pair])
            {
                this.valuesByFirstKey[key1].Remove(entry);
                this.valuesBySecondKey[key2].Remove(entry);
            }

            this.valuesByBothKeys.Remove(pair);

            return true;
        }
    }

}
