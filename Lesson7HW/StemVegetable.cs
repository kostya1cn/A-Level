namespace Lesson7HW
{
    public class StemVegetable : Vegetable
    {
        public int StemLength { get; private set; }

        public StemVegetable(string name, int calories, int weight, int stemLength)
            : base(name, calories, weight)
        {
            StemLength = stemLength;
        }

        public int GetStemLength()
        {
            return StemLength;
        }
    }
}
