namespace ValideSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static bool areCharactersValid(int[,] input)
            {
                char[] validCharaters = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

                for (int i = 0; i < input.GetLength(0); i++)
                {
                    for (int j = 0; j < input.GetLength(1); j++)
                    {
                        for (int k = 0; k < validCharaters.Length; k++)
                        {
                            if (validCharaters[k] == input[i, j])
                            {
                                break;
                            }
                            else if (k == validCharaters.Length - 1)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }

            static bool isRowValid(int[,] input)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    for (int j = 0; j < input.GetLength(1); j++)
                    {
                        for (int k = 0; k < input.GetLength(1); k++)
                        {
                            if (input[i, j] != input[i, k])
                            {

                            }
                        }
                    }
                }
            }

            static bool isSudokuValid(int[,] input)
            {

                if (areCharactersValid(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
