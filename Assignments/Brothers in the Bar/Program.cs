namespace Brothers_in_the_Bar
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] cups = new int[] { 1, 1, 2, 3, 3, 3, 2, 2, 1, 1 }; // Output should be 3
            //int[] cups = new int[] { 1, 1, 2, 1, 2, 2, 1, 1 }; // Output should be 0

            Console.WriteLine(SameCupsCounter(cups));
        }

        public static int SameCupsCounter(int[] cups)
        {
            int brothersDrunkRounds = default;
            bool areMoreSameSizeGlases = true;

            while (areMoreSameSizeGlases)
            {
                areMoreSameSizeGlases = false;

                for (int i = 0; i < cups.Length; i++)
                {
                    // Here we check for out of range && for three same cups in a row
                    if (i < cups.Length - 2 && cups[i + 1] == cups[i] && cups[i + 2] == cups[i])
                    {
                        cups = RemoveEmptyGlasses(cups, i);
                        areMoreSameSizeGlases = true;
                        brothersDrunkRounds++;
                        break;
                    }
                }
            }

            return brothersDrunkRounds;
        }

        private static int[] RemoveEmptyGlasses(int[] cups, int index)
        {
            var newArray = new int[cups.Length - 3];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = cups[i];
                }
                else
                {
                    newArray[i] = cups[i + 3];
                }
            }

            return newArray;
        }
    }
}
