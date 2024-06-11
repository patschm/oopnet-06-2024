﻿using System.Collections;

namespace ConsoleLingo
{
    public class LingoWord : IEnumerable
    {
        private readonly LingoCharacter[] internalWord;

        public LingoCharacter? this[int i]
        {
            get
            {
                if (i >= 0 && i < internalWord.Length)
                {
                    return internalWord[i];
                }
                return null;
            }
            set
            {
                if (value == null) return;
                if (i >= 0 && i < internalWord.Length)
                {
                    internalWord[i] =  value;
                }
            }
        }
        public int Count
        {
            get
            {
                return internalWord.Length;
            }
        }
        public void Show()
        {
            foreach(LingoCharacter c in internalWord)
            {
                c.Draw();
            }
            Console.WriteLine();
        }
        public void CompareTo(LingoWord guess)
        {
            // CharCounter is class that keeps list of all characters in a LingoWord and how often they appear.
            // Use IsCharacterInWord(lingCharacter) to test if a character exists in the list.
            // Use DecrementCharacterCount(lingoCharacter) to lower the character count for the character
            // Of course you can use your own strategy if you like.
            CharCounter counter = new CharCounter(this);
            
            // TODO 4: Complete this method by modifying the LingoWord guess parameter.
            // If the character is correct and in the right place then you place an ExactCharacter at that position in the resulting LingoWord
            // If the character is part of the word but not in the right place a PartialCharacter at that position in the resulting LingoWord
            // If the character is not part of the word you place a LingoCharacter at that position in the resulting LingoWord
            // Hint: First check for the exact characters, then for the partial characters
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i]!;
                foreach (LingoCharacter targetChar in this)
                {
                    if (LingoCharacter.ExactlyEqual(targetChar, guessChar))
                    {
                        counter.DecrementCharacterCount(targetChar);
                        guess[i] = new ExactCharacter { 
                            Character = guessChar.Character, 
                            Position = guessChar.Position };
                    }
                }
            }
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i]!;

                foreach (LingoCharacter thisChar in this)
                {
                    if (!guessChar.IsExact() &&
                        counter.IsCharacterInWord(guessChar) && 
                        LingoCharacter.PartialEqual(thisChar, guessChar))
                    {
                        counter.DecrementCharacterCount(thisChar);
                        guess[i] = new PartialCharacter { 
                            Character = guessChar.Character, 
                            Position = guessChar.Position };
                    }
                }
            }
        }
       
        /// <summary>
        /// Method required by IEnumarable.
        /// It makes LingoWord useable in foreach
        /// We'll talk about this later
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return internalWord.GetEnumerator();
        }
        public override string ToString()
        {
            char[] chars = new char[internalWord.Length];
            for(int i = 0; i < internalWord.Length; i++)
            {
                chars[i] = internalWord[i].Character;
            }
            return new string(chars);
        }
        public LingoWord(string? word)
        {
            this.internalWord = new LingoCharacter[word!.Length];
            for(int i = 0; i < word.Length;i++)
            {
                LingoCharacter ch = new LingoCharacter { Position = i, Character = word[i] };
                this.internalWord[i] = ch;
            }
        }
    }
}
