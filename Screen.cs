using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS
{
    class Screen
    {
        // Author: Ben Fairlamb
        // Purpose: The game screen
        // Limitations: None

        //─│┌┐└┘

        // Fields
        private char[][] screen;
        private List<char> input;
        private const string INPUT = "> ";
        private const int INPUTLENGTH = 2;

        // Properties
        public char[][] GameScreen
        {
            get { return screen; }
        }

        public List<char> Input
        {
            get { return input; }
            set { input = value; }
        }

        // Constructors
        public Screen(int height, int width)
        {

            // Create screen
            screen = new char[height + 2][];
            for (int i = 0; i < screen.Length; i++)
            {
                screen[i] = new char[width + 2];
            }

            // Create corners
            screen[0][0] = '┌';
            screen[0][screen[0].Length - 1] = '┐';
            screen[screen.Length - 1][0] = '└';
            screen[screen.Length - 1][screen[0].Length - 1] = '┘';

            // Create borders
            // Top and bot
            for (int i = 1; i < screen[0].Length - 1; i++)
            {
                screen[0][i] = '─';
                screen[screen.Length - 1][i] = '─';
            }

            // left and right
            for (int i = 1; i < screen.Length - 1; i++)
            {
                screen[i][0] = '│';
                screen[i][screen[0].Length - 1] = '│';
            }

            Zero();
            input = new List<char>();
        }

        // Methods
        /// <summary>
        /// Draw screen to console
        /// </summary>
        public void Draw(bool cursor)
        {
            Console.SetCursorPosition(0, 0);
            foreach (char[] line in screen)
            {
                Console.WriteLine(line);
            }

            Console.SetCursorPosition(0, screen.Length + 2);
            Console.Write(INPUT);

            foreach (char c in input)
            {
                Console.Write(c);
            }

            if (cursor)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(' ');
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.Write(' ');
            }

            Zero();
        }

        private void Zero()
        {
            for (int i = 1; i < screen.Length - 1; i++)
            {
                for (int j = 1; j < screen[0].Length - 1; j++)
                {
                    screen[i][j] = ' ';
                }
            }
        }

        /// <summary>
        /// Draw character to screen
        /// </summary>
        /// <param name="width">Column of character</param>
        /// <param name="height">Row of character</param>
        /// <param name="character">Character to draw</param>
        public void DrawToScreen(int width, int height, char character)
        {
            screen[height + 1][width + 1] = character;
        }

        /// <summary>
        /// Draw group of characters to screen
        /// </summary>
        /// <param name="width">Column of first character</param>
        /// <param name="height">Row of characters</param>
        /// <param name="characters">Characters to draw</param>
        public void DrawToScreen(int width, int height, char[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                screen[height + 1][width + i + 1] = characters[i];
            }
        }

        /// <summary>
        /// Reset input
        /// </summary>
        public void ResetInput()
        {
            for (int i = 0; i < input.Count + 1; i++)
            {
                input[i] = ' ';
            }
            input.Add(' ');
            Console.SetCursorPosition(0, screen.Length + 2);
            Console.Write(input);

            input.Clear();
        }

        /// <summary>
        /// Add a character[] to input
        /// </summary>
        /// <param name="characters">Character[] to add</param>
        public void AddInput(char[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                input.Add(characters[i]);
            }
        }

        /// <summary>
        /// Add a character to input
        /// </summary>
        /// <param name="character">Character to add</param>
        public void AddInput(char character)
        {
            input.Add(character);
        }

        /// <summary>
        /// Delete the last character of the char array
        /// </summary>
        public void Backspace()
        {
            if (input.Count > 0)
            {
                Console.SetCursorPosition(input.Count + INPUTLENGTH, screen.Length + 2);
                input.RemoveAt(input.Count - 1);
                Console.Write(" ");
            }
        }
    }
}
