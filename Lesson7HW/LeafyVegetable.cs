namespace Lesson7HW
{
    public class LeafyVegetable : Vegetable
    {
        public string NutrientContent { get; private set; }

        public LeafyVegetable(string name, int calories, int weight, string nutrientContent)
            : base(name, calories, weight)
        {
            NutrientContent = nutrientContent;
        }

        public string GetNutrientContent()
        {
            return NutrientContent;
        }
    }
}
