using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017
{
    public class Day4Solution
    {
        public IEnumerable<string> GetInputFromFile()
        {
            return File.ReadLines("../../PuzzleInputs/Day4.txt");
        }

        #region Part 1

        // A new system policy has been put in place that requires all accounts to use a passphrase instead of simply a password.
        // A passphrase consists of a series of words (lowercase letters) separated by spaces. 
        // To ensure security, a valid passphrase must contain no duplicate words. For example:

        //  aa bb cc dd ee is valid.
        //  aa bb cc dd aa is not valid - the word aa appears more than once.
        //  aa bb cc dd aaa is valid - aa and aaa count as different words.

        // The system's full passphrase list is available as your puzzle input. How many passphrases are valid?

        public int SolvePart1(IEnumerable<string> inputStrings)
        {
            return FindValidPassphrases(inputStrings);
        }

        private int FindValidPassphrases(IEnumerable<string> passphraseList)
        {
            int validPassphraseCount = 0;

            foreach (var passphrase in passphraseList)
            {
                List<string> splitPhrase = passphrase.Split(' ').ToList();
                validPassphraseCount += (splitPhrase.Count == splitPhrase.Distinct().Count()) ? 1 : 0;
            }

            return validPassphraseCount;
        }

        #endregion

        #region Part 2

        // For added security, yet another system policy has been put in place.
        // Now, a valid passphrase must contain no two words that are anagrams of each other - that is,
        // a passphrase is invalid if any word's letters can be rearranged to form any other word in the passphrase.
        // For example:

        //  abcde fghij is a valid passphrase.
        //  abcde xyz ecdab is not valid - the letters from the third word can be rearranged to form the first word.
        //  a ab abc abd abf abj is a valid passphrase, because all letters need to be used when forming another word.
        //  iiii oiii ooii oooi oooo is valid.
        //  oiii ioii iioi iiio is not valid - any of these words can be rearranged to form any other word.

        //Under this new system policy, how many passphrases are valid?

        public int SolvePart2(IEnumerable<string> inputStrings)
        {
            return FindValidPassphrasesIncludingAnagrams(inputStrings);
        }

        private int FindValidPassphrasesIncludingAnagrams(IEnumerable<string> passphraseList)
        {
            int validPassphraseCount = 0;

            foreach (var passphrase in passphraseList)
            {
                List<string> splitPhrase = passphrase.Split(' ').ToList();
                var sortedPhrases = new List<string>();

                foreach(var phrase in splitPhrase)
                {
                    sortedPhrases.Add(new string(phrase.OrderBy(c => c).ToArray()));
                }

                validPassphraseCount += (sortedPhrases.Count == sortedPhrases.Distinct().Count()) ? 1 : 0;
            }

            return validPassphraseCount;
        }

        #endregion
    }
}
