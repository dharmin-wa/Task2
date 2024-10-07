namespace BinaryStringEvaluatorApp.Helper
{
    public class BinaryStringEvaluator
    {
        public static bool IsGoodBinaryString(string binary)
        {
            int countOnes = 0, countZeros = 0;

            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    countOnes++;
                }
                else if (bit == '0')
                {
                    countZeros++;
                }
                else
                {
                    return false;
                }

                if (countZeros > countOnes)
                {
                    return false;
                }
            }

            return countOnes == countZeros;
        }
    }
}
