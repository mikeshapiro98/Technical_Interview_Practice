using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatGroups
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Groups.Check("()"));
            Console.WriteLine(Groups.Check("(){"));
            Console.ReadLine();

        }
    }
    public static class Groups
    {
        private static readonly Dictionary<char, char> ClosingToOpeningBrace;
        private static readonly char[] OpeningBraces;
        private static readonly char[] ClosingBraces;

        static Groups()
        {
            ClosingToOpeningBrace = new Dictionary<char, char>
        {
          { ')', '(' },
          { ']', '[' },
          { '}', '{' }
        };
            OpeningBraces = ClosingToOpeningBrace.Values.ToArray();
            ClosingBraces = ClosingToOpeningBrace.Keys.ToArray();
        }

        public static bool Check(string input)
        {
            var stack = new Stack<char>();
            foreach (char c in input.ToCharArray())
            {
                if (OpeningBraces.Contains(c))
                {
                    stack.Push(c);
                }
                else if (ClosingBraces.Contains(c))
                {
                    bool hasOpeningBrace = stack.Count != 0 && stack.Pop() == ClosingToOpeningBrace[c];
                    if (!hasOpeningBrace) return false;
                }
            }

            return stack.Count == 0;
        }
    }

}


//In English and programming, groups can be made using symbols such as () and { }
//that change meaning.However, these groups must be closed in the correct order to maintain correct syntax.

//Your job in this will be to make a program that checks a string for correct grouping. For instance, the following groups are done correctly:


//({})
//[[] ()]
//[{()}]

//The next are done incorrectly:

//{(})
//([]
//[])

//A correct string cannot close groups in the wrong order, open a group but fail to close it, or close a group before it is opened.

//Your function will take an input string that may contain any of the symbols(), {} or[] to create groups.

//It should return True if the string is empty or otherwise grouped correctly, or False if it is grouped incorrectly.
