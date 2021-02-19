namespace Boxing
{
    public sealed class Box<T> where T : struct
    {
        private T _val;

        public Box(T val) =>_val = val;
 
        public static explicit operator T(Box<T> box) => box._val;
        public static implicit operator Box<T>(T val) => new Box<T>(val);

        public override string ToString() =>_val.ToString();
        public override int GetHashCode() => _val.GetHashCode();
        public override bool Equals(object val) => _val.Equals(val);
    }
}
