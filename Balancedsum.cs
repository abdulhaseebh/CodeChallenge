using System;
namespace CodeChallenge
{
    public class Balancedsum
    {
        public static string balancedSum(int[] number)
        {
            string num = number.ToString();
            string firsthalf = num.Substring(0, num.Length / 2);
            string secondhalf = num.Substring(num.Length / 2);

            int fsum = 0;
            int ssum = 0;

            for (int i = 0; i < firsthalf.Length; i++)
            {
                fsum = firsthalf[i];
                ssum = secondhalf[i];
            }
            if (fsum == ssum)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }

        }
    }
}