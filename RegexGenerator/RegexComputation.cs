using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexGenerator
{
    class RegexComputation
    {
        /// <summary>
        /// Use this method to check if the regex works
        /// </summary>
        /// <param name="regularExpression"></param>
        /// <param name="textToCheck"></param>
        /// <returns></returns>
        public static Boolean checkRegexWorks(String regularExpression, String textToCheck)
        {
            Console.WriteLine(regularExpression + textToCheck);
            Regex re = new Regex(@"^" + regularExpression + "$");
            if (re.IsMatch(textToCheck))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * Negative lookahead cannot start with ?!
         * negative lookbehind cannot end with ?<!
         * positive lookahead must start with ?=
         * positive lookbehind must end with ?<=
         * Single Character []
         * Characters except a, b or c [^abc]
         * characters in the range of [a-z] [a-zA-Z]
         * character not in the range of [^a-z]
         * Match any character .
         * whitespace \s
         * non-whitespace \S
         * digit \d
         * non-digit \D
         * word \w
         * non-word \W
         * capture everything/group together ()
         * Match either a or b (a|b)
         * zero or one of a a?
         * zero or more of a a*
         * one or more of a a+
         * exactly match a 3 times a{3}
         * 3 or more of a a{3,}
         * between 3 and 6 times of a a{3,6}
        */
        /// <summary>
        /// DONE
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<String> generateExplicitRegex(String input)
        {
            List<String> potentialRegex = new List<String>();
            String re = "";
            foreach (Char n in input)
            {
                re += "[" + n + "]";
                Console.WriteLine(n);
            }
            potentialRegex.Add(re);
            return potentialRegex;
        }

        //PENDING
        public static List<String> generatePatternRegex (String input)
        {
            List<String> potentialRegex = new List<String>();

            String constructregex = "";

            String[] conditions = input.Split('|');
            for(int i=0; i<conditions.Length; i++)
            {
                if(conditions[i].Split(':').Length > 1)
                {
                    Console.WriteLine("Went into num " + conditions[i]);
                    String[] numberOfTimesToMatch = conditions[i].Split(':');
                    if(conditions[i].Contains("num") || conditions[i].Contains("loweralpha") || conditions[i].Contains("upperalpha"))
                    {
                        if(conditions[i].Contains("num"))
                        {
                            if (numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] == "+")
                            {
                                constructregex += "[0-9]" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1];
                            }
                            else
                            {
                                constructregex += "[0-9]{" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] + "}";
                            }
                        }
                        else if(conditions[i].Contains("loweralpha"))
                        {
                            if (numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] == "+")
                            {
                                constructregex += "[a-z]" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1];
                            }
                            else
                            {
                                constructregex += "[a-z]{" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] + "}";
                            }
                        }
                        else
                        {
                            if (numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] == "+")
                            {
                                constructregex += "[A-Z]" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1];
                            }
                            else
                            {
                                constructregex += "[A-Z]{" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] + "}";
                            }
                        }
                    }
                    else
                    {
                        if (numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] == "+")
                        {
                            constructregex += "[" + conditions[i] + "]" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1];
                        }
                        else
                        {
                            constructregex += "[" + conditions[i] + "]{" + numberOfTimesToMatch[numberOfTimesToMatch.Length - 1] + "}";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Went into else " + conditions[i]);
                    if (conditions[i].Contains("num") || conditions[i].Contains("loweralpha") || conditions[i].Contains("upperalpha"))
                    {
                        if (conditions[i].Contains("num"))
                        {
                            constructregex += "[0-9]";
                        }
                        else if (conditions[i].Contains("loweralpha"))
                        {
                            constructregex += "[a-z]";
                        }
                        else
                        {
                            constructregex += "[A-Z]";
                        }
                    }
                    else
                    {
                        constructregex += "[" + conditions[i] + "]";
                    }
                }
            }

            potentialRegex.Add(constructregex);
            return potentialRegex;
        }

        /// <summary>
        /// DONE
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<String> generateRangeRegex(String input)
        {
            List<String> potentialRegex = new List<String>();

            Regex checknumber = new Regex(@"^[0-9]+$");
            Regex checkloweralphabet = new Regex(@"^[a-z]+$");
            Regex checkupperalphabet = new Regex(@"^[A-Z]+$");

            Regex checkLCaseNum = new Regex(@"^([a-z]+)([0-9]+)$");
            Regex checkNumLCase = new Regex(@"^([0-9]+)([a-z]+)$");

            Regex checkUCaseNum = new Regex(@"^([A-Z]+)([0-9]+)$");
            Regex checkNumUCase = new Regex(@"^([0-9]+)([A-Z]+)$");

            Regex checkLCaseUCase = new Regex(@"^([a-z]+)([A-Z]+)$");
            Regex checkUCaseLCase = new Regex(@"^([A-Z]+)([a-z]+)$");

            Regex checkLCaseUCaseNum = new Regex(@"^([a-z]+)([A-Z]+)([0-9]+)$");
            Regex checkLCaseNumUCase = new Regex(@"^([a-z]+)([0-9]+)([A-Z]+)$");
            Regex checkUCaseLCaseNum = new Regex(@"^([A-Z]+)([a-z]+)([0-9]+)$");
            Regex checkUCaseNumLCase = new Regex(@"^([A-Z]+)([0-9]+)([a-z]+)$");
            Regex checkNumUCaseLCase = new Regex(@"^([a-z]+)([A-Z]+)([0-9]+)$");
            Regex checkNumLCaseUCase = new Regex(@"^([0-9]+)([a-z]+)([A-Z]+)$");

            if (checkLCaseUCaseNum.IsMatch(input) || checkLCaseNumUCase.IsMatch(input) || checkUCaseLCaseNum.IsMatch(input) || checkUCaseNumLCase.IsMatch(input) || checkNumUCaseLCase.IsMatch(input) || checkNumLCaseUCase.IsMatch(input))
            {
                String splitNumbers = "";
                String splitlowerAlphabet = "";
                String splitupperAlphabet = "";

                foreach (Char c in input)
                {
                    if (checknumber.IsMatch(Convert.ToString(c)))
                    {
                        splitNumbers += c;
                    }
                    else if (checkloweralphabet.IsMatch(Convert.ToString(c)))
                    {
                        splitlowerAlphabet += c;
                    }
                    else
                    {
                        splitupperAlphabet += c;
                    }
                }

                potentialRegex.Add("[" + splitNumbers[0] + "-" + splitNumbers[splitNumbers.Length - 1] + splitlowerAlphabet[0] + "-" + splitlowerAlphabet[splitlowerAlphabet.Length - 1] + splitupperAlphabet[0] + "-" + splitupperAlphabet[splitupperAlphabet.Length - 1] + "]{" + input.Length + "}");
            }
            else if (checkLCaseNum.IsMatch(input) || checkNumLCase.IsMatch(input))
            {
                String splitNumbers = "";
                String splitlowerAlphabet = "";

                foreach (Char c in input)
                {
                    if (checknumber.IsMatch(Convert.ToString(c)))
                    {
                        splitNumbers += c;
                    }
                    else if (checkloweralphabet.IsMatch(Convert.ToString(c)))
                    {
                        splitlowerAlphabet += c;
                    }
                }

                potentialRegex.Add("[" + splitNumbers[0] + "-" + splitNumbers[splitNumbers.Length - 1] + splitlowerAlphabet[0] + "-" + splitlowerAlphabet[splitlowerAlphabet.Length - 1] + "]{" + input.Length + "}");
            }
            else if (checkUCaseNum.IsMatch(input) || checkNumUCase.IsMatch(input))
            {
                String splitNumbers = "";
                String splitupperAlphabet = "";

                foreach (Char c in input)
                {
                    if (checknumber.IsMatch(Convert.ToString(c)))
                    {
                        splitNumbers += c;
                    }
                    else
                    {
                        splitupperAlphabet += c;
                    }
                }

                potentialRegex.Add("[" + splitNumbers[0] + "-" + splitNumbers[splitNumbers.Length - 1] + splitupperAlphabet[0] + "-" + splitupperAlphabet[splitupperAlphabet.Length - 1] + "]{" + input.Length + "}");
            }
            else if (checkLCaseUCase.IsMatch(input) || checkUCaseLCase.IsMatch(input))
            {
                String splitlowerAlphabet = "";
                String splitupperAlphabet = "";

                foreach (Char c in input)
                {
                    if (checkloweralphabet.IsMatch(Convert.ToString(c)))
                    {
                        splitlowerAlphabet += c;
                    }
                    else
                    {
                        splitupperAlphabet += c;
                    }
                }

                potentialRegex.Add("[" + splitlowerAlphabet[0] + "-" + splitlowerAlphabet[splitlowerAlphabet.Length - 1] + splitupperAlphabet[0] + "-" + splitupperAlphabet[splitupperAlphabet.Length - 1] + "]{" + input.Length + "}");
            }
            else
            {
                String regex = "[" + input[0] + "-" + input[input.Length - 1] + "]{" + input.Length + "}";
                potentialRegex.Add(regex);

                Regex r = new Regex(@"^[\d]{" + input.Length + "}$");
                if (r.IsMatch(input))
                {
                    potentialRegex.Add("[\\d]{" + input.Length + "}");
                }

                //using tryparse to check if the input is a number or not
                int num = 0;
                if (int.TryParse(input, out num) == false)
                {
                    Regex re = new Regex(@"^[\w]{" + input.Length + "}$");
                    if (re.IsMatch(input))
                    {
                        potentialRegex.Add("[\\w]{" + input.Length + "}");
                    }
                }
            }
            return potentialRegex;
        }
    }
}
