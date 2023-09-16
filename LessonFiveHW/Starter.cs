public static class Starter
{
    public static void Run(int n)
    {
        for (int i = 0; i < n; i++)
        {
            int actionIndex = new Random().Next(3);
            switch (actionIndex)
            {
                case 0:
                    Actions.InfoAction();
                    break;
                case 1:
                    Actions.WarningAction();
                    break;
                case 2:
                    Actions.ErrorAction();
                    break;
            }
        }
    }
}
