using System;
using System.Collections.Generic;

namespace FooBarGenerator
{
    public class Generator
    {
        private Dictionary<int, string> rules;

        public Generator()
        {
            rules = new Dictionary<int, string>();
        }

        public void AddRule(int input, string output)
        {
            if (!rules.ContainsKey(input))
            {
                rules.Add(input, output);
            }
            else
            {
                rules[input] = output;
            }
        }

        public void RemoveRule(int input)
        {
            if (rules.ContainsKey(input))
            {
                rules.Remove(input);
            }
        }

        public void ClearRules()
        {
            rules.Clear();
        }

        public void GenerateNumbers(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                string output = "";

                foreach (KeyValuePair<int, string> kvp in rules)
                {
                    if (x % kvp.Key == 0)
                    {
                        output += kvp.Value;
                    }
                }

                if (output == "")
                {
                    output = x.ToString();
                }

                Console.Write("{0}", output);

                if (x < n)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}