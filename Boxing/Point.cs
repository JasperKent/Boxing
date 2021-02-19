namespace Boxing
{
    public struct Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"{X}, {Y}";
    }
}
