namespace Lesson7HW
{
    public class Vegetable
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }
        public int Weight { get; private set; }

        public Vegetable(string name, int calories, int weight)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
        }

        public int GetCalories()
        {
            return Calories;
        }

        public int GetWeight()
        {
            return Weight;
        }
    }
}
