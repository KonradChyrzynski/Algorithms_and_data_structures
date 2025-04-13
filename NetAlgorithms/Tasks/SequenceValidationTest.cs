using System.Collections.Generic;

namespace StackExtension
{
    public class StackCharacterValidation
    {
        /* [Fact] */
        /* public void checkIfSequenceValidationMethodWorksCorrectly() */
        /* { */
        /*     bool test1true = validateSequenceOfSpecialCharacters("([()])"); */
        /*     bool test1false = validateSequenceOfSpecialCharacters("([([)])"); */
        /*     bool test2true = validateSequenceOfSpecialCharacters("([([])])"); */
        /*     bool test2false = validateSequenceOfSpecialCharacters("((]]"); */
        /*     bool test3true = validateSequenceOfSpecialCharacters("[()]"); */
        /*     bool test3false = validateSequenceOfSpecialCharacters("[[))"); */

        /*     Assert.True(test1true); */
        /*     Assert.True(test2true); */
        /*     Assert.True(test3true); */
        /*     Assert.False(test1false); */
        /*     Assert.False(test2false); */
        /* } */

        private static bool validateSequenceOfSpecialCharacters(string sequence)
        {
            Stack<string> stack = new Stack<string>();
            Dictionary<char, string> open = new Dictionary<char, string>() { { char.Parse("("), "circular" }, { char.Parse("["), "rectangular" } };
            Dictionary<char, string> close = new Dictionary<char, string>() { { char.Parse(")"), "circular" }, { char.Parse("]"), "rectangular" } };

            foreach (char letter in sequence)
            {
                if (open.ContainsKey(letter))
                {
                    stack.Push(open[letter]);
                }
                else if (close.ContainsKey(letter) && stack.Count != 0)
                {
                    if (stack.Peek() == close[letter])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (stack.Count == 0)
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
