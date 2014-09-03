using System;

    class ABCheck
    {
        static bool AbCheck(string input)
        {
            bool answer = false; 
            for (int i = 0; i < input.Length - 4; i++)
            {
                if (input[i] == 'a' && input[i + 4] == 'b')
                {
                    answer = true;
                }
            }
            return answer;
        }
        static void Main()
        {
            string input = Console.ReadLine();

            bool finalAnswer = AbCheck(input);
            Console.WriteLine(finalAnswer);
        }
    }

