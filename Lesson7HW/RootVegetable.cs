namespace Lesson7HW
{
    public class RootVegetable : Vegetable
    {
        public string TypeOfRoot { get; private set; }

        public RootVegetable(string name, int calories, int weight, string typeOfRoot)
            : base(name, calories, weight)
        {
            TypeOfRoot = typeOfRoot;
        }

        public string GetTypeOfRoot()
        {
            return TypeOfRoot;
        }
    }
}
