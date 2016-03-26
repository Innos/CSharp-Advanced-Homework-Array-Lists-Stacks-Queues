namespace _02BiDictionary
{
    public class Pair<T1, T2>
    {
        public Pair(T1 key1, T2 key2)
        {
            this.Key1 = key1;
            this.Key2 = key2;
        }

        public T1 Key1 { get; private set; }

        public T2 Key2 { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as Pair<T1, T2>;
            if (this.Key1.Equals(other.Key1) && this.Key2.Equals(other.Key2))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Key1.GetHashCode() + this.Key2.GetHashCode();
        }
    }
}
