namespace HouseRobberProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = { 2, 7, 9, 3, 1 };
            Console.WriteLine(Solve(houses));
        }
        static int Solve(int[] houses)
        {
            int n = houses.Length;
            int r1; int r2; int prof;
            r1 = r2 = prof = 0;
            for (int i = 0; i < n; i++)
            {
                prof = Math.Max(r1, r2 + houses[i]);
                r1 = r2;
                r2 = prof;
            }
            return r2;
        }
    }
}
