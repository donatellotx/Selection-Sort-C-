namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stuff = new int[] { 8, 6, 7, 5, 3, 0, 9 };
            var stuffCount = stuff.Length;
            int temp;
            int smalls;

            for(int p = 0; p < stuffCount; p++)
            {
                smalls = p;
                for(int i = p + 1; i < stuffCount; i++)
                {
                    var currentComparisonValue = stuff[i];
                    var currentItemValue = stuff[smalls];
                    if (currentComparisonValue < currentItemValue)
                    {
                        smalls = i;
                    }
                }
                if (smalls != p)
                {
                    temp = stuff[smalls];
                    stuff[smalls] = stuff[p];
                    stuff[p] = temp;
                }
            }
            Console.WriteLine();
        }
    }
}