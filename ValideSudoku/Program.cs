﻿namespace ValideSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static bool areCharactersValid(string[,] input)
            {
                string[] validCharaters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };

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

            static bool isRowValid(string[,] input)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    for (int j = 0; j < input.GetLength(1); j++)
                    {
                        for (int k = 0; k < input.GetLength(1); k++)
                        {
                            if (j != k && input[i, j] != "." && input[i, j] == input[i, k])
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }

            static bool isColumnValid(string[,] input)
            {
                for (int i = 0; i < input.GetLength(1); i++)
                {
                    for (int j = 0; j < input.GetLength(0); j++)
                    {
                        for (int k = 0; k < input.GetLength(0); k++)
                        {
                            if (j != k && input[j, i] != "." && input[j, i] == input[k, i])
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }

            static bool is3x3Valid(string[,] input)
            {
                for (int i = 0; i < input.GetLength(0); i = i + 3)
                {
                    for (int j = 0; j < input.GetLength(1); j = j + 3)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                for (int m = 0; m < 3; m++)
                                {
                                    for (int n = 0; n < 3; n++)
                                        if (i + k != i + m && j + l != j + n && input[i + k, j + l] != "." && input[i + k, j + l] == input[i + m, j + n])
                                        {
                                            return false;
                                        }
                                }
                            }
                        }
                    }
                }
                return true;
            }

            static bool isSudokuValid(string[,] input)
            {

                if (areCharactersValid(input) && isRowValid(input) && isColumnValid(input) && is3x3Valid(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            string[,] expectedTrue = { { "5", "3", ".", ".", "7", ".", ".", ".", "." }, { "6", ".", ".", "1", "9", "5", ".", ".", "." }, { ".", "9", "8", ".", ".", ".", ".", "6", "." }, { "8", ".", ".", ".", "6", ".", ".", ".", "3" }, { "4", ".", ".", "8", ".", "3", ".", ".", "1" }, { "7", ".", ".", ".", "2", ".", ".", ".", "6" }, { ".", "6", ".", ".", ".", ".", "2", "8", "." }, { ".", ".", ".", "4", "1", "9", ".", ".", "5" }, { ".", ".", ".", ".", "8", ".", ".", "7", "9" } };
            string[,] expectedFalse = { { "8", "3", ".", ".", "7", ".", ".", ".", "." }, { "6", ".", ".", "1", "9", "5", ".", ".", "." }, { ".", "9", "8", ".", ".", ".", ".", "6", "." }, { "8", ".", ".", ".", "6", ".", ".", ".", "3" }, { "4", ".", ".", "8", ".", "3", ".", ".", "1" }, { "7", ".", ".", ".", "2", ".", ".", ".", "6" }, { ".", "6", ".", ".", ".", ".", "2", "8", "." }, { ".", ".", ".", "4", "1", "9", ".", ".", "5" }, { ".", ".", ".", ".", "8", ".", ".", "7", "9" } };
            string[,] expectedFalse2 = { { "5", "3", ".", ".", "7", ".", ".", ".", "." }, { "6", "8", ".", "1", "9", "5", ".", ".", "." }, { ".", "9", "8", ".", ".", ".", ".", "6", "." }, { "8", ".", ".", ".", "6", ".", ".", ".", "3" }, { "4", ".", ".", "8", ".", "3", ".", ".", "1" }, { "7", ".", ".", ".", "2", ".", ".", ".", "6" }, { ".", "6", ".", ".", ".", ".", "2", "8", "." }, { ".", ".", ".", "4", "1", "9", ".", ".", "5" }, { ".", ".", ".", ".", "8", ".", ".", "7", "9" } };
            Console.WriteLine(isSudokuValid(expectedFalse2));
        }
    }
}
