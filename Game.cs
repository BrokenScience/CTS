using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CTS
{
    class Game {
        // Author: Ben Fairlamb
        // Purpose: Main Game
        // Limitations: None

        // Fields
        private Screen screen;
        private KeyboardStates keyboardStates;
        private long time;
        private bool inputCursor;

        // Properties

        // Constructors
        public Game(int width, int height)
        {
            screen = new Screen(width, height);
            keyboardStates = new KeyboardStates();

            //screen.Input = (Console.LargestWindowWidth + ", " + Console.LargestWindowHeight).ToCharArray();
        }

        // Methods
        /// <summary>
        /// Update the game
        /// </summary>
        /// <param name="gameTime">Time in miliseconds since start</param>
        /// <returns>Exit?</returns>
        public bool Update(long gameTime)
        {
            keyboardStates.Update();

            CheckTypeables();
            //keyboardStates.IdentifyKey();

            screen.DrawToScreen(1, 1, keyboardStates.IsKeyActive(Key.Space).ToString().ToCharArray());

            if (gameTime > time + 450)
            {
                inputCursor = !inputCursor;
                time = gameTime;
            }

            screen.Draw(inputCursor);

            return false;
        }

        private void CheckTypeables()
        {
            if (Keyboard.IsKeyToggled(Key.CapsLock) ^ (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
            {
                if (keyboardStates.IsKeyActive(Key.Q))
                {
                    screen.AddInput('Q');
                }
                if (keyboardStates.IsKeyActive(Key.W))
                {
                    screen.AddInput('W');
                }
                if (keyboardStates.IsKeyActive(Key.E))
                {
                    screen.AddInput('E');
                }
                if (keyboardStates.IsKeyActive(Key.R))
                {
                    screen.AddInput('R');
                }
                if (keyboardStates.IsKeyActive(Key.T))
                {
                    screen.AddInput('T');
                }
                if (keyboardStates.IsKeyActive(Key.Y))
                {
                    screen.AddInput('Y');
                }
                if (keyboardStates.IsKeyActive(Key.U))
                {
                    screen.AddInput('U');
                }
                if (keyboardStates.IsKeyActive(Key.I))
                {
                    screen.AddInput('I');
                }
                if (keyboardStates.IsKeyActive(Key.O))
                {
                    screen.AddInput('O');
                }
                if (keyboardStates.IsKeyActive(Key.P))
                {
                    screen.AddInput('P');
                }
                if (keyboardStates.IsKeyActive(Key.OemOpenBrackets))
                {
                    screen.AddInput('{');
                }
                if (keyboardStates.IsKeyActive(Key.OemCloseBrackets))
                {
                    screen.AddInput('}');
                }
                if (keyboardStates.IsKeyActive(Key.OemBackslash))
                {
                    screen.AddInput('|');
                }
                if (keyboardStates.IsKeyActive(Key.A))
                {
                    screen.AddInput('A');
                }
                if (keyboardStates.IsKeyActive(Key.S))
                {
                    screen.AddInput('S');
                }
                if (keyboardStates.IsKeyActive(Key.D))
                {
                    screen.AddInput('D');
                }
                if (keyboardStates.IsKeyActive(Key.F))
                {
                    screen.AddInput('F');
                }
                if (keyboardStates.IsKeyActive(Key.G))
                {
                    screen.AddInput('G');
                }
                if (keyboardStates.IsKeyActive(Key.H))
                {
                    screen.AddInput('H');
                }
                if (keyboardStates.IsKeyActive(Key.J))
                {
                    screen.AddInput('J');
                }
                if (keyboardStates.IsKeyActive(Key.K))
                {
                    screen.AddInput('K');
                }
                if (keyboardStates.IsKeyActive(Key.L))
                {
                    screen.AddInput('L');
                }
                if (keyboardStates.IsKeyActive(Key.OemSemicolon))
                {
                    screen.AddInput(':');
                }
                if (keyboardStates.IsKeyActive(Key.OemQuotes))
                {
                    screen.AddInput('"');
                }
                if (keyboardStates.IsKeyActive(Key.Z))
                {
                    screen.AddInput('Z');
                }
                if (keyboardStates.IsKeyActive(Key.X))
                {
                    screen.AddInput('X');
                }
                if (keyboardStates.IsKeyActive(Key.C))
                {
                    screen.AddInput('C');
                }
                if (keyboardStates.IsKeyActive(Key.V))
                {
                    screen.AddInput('V');
                }
                if (keyboardStates.IsKeyActive(Key.B))
                {
                    screen.AddInput('B');
                }
                if (keyboardStates.IsKeyActive(Key.N))
                {
                    screen.AddInput('N');
                }
                if (keyboardStates.IsKeyActive(Key.M))
                {
                    screen.AddInput('M');
                }
                if (keyboardStates.IsKeyActive(Key.OemComma))
                {
                    screen.AddInput('<');
                }
                if (keyboardStates.IsKeyActive(Key.OemPeriod))
                {
                    screen.AddInput('>');
                }
                if (keyboardStates.IsKeyActive(Key.OemQuestion))
                {
                    screen.AddInput('?');
                }
                if (keyboardStates.IsKeyActive(Key.Oem3))
                {
                    screen.AddInput('~');
                }
                if (keyboardStates.IsKeyActive(Key.D1))
                {
                    screen.AddInput('!');
                }
                if (keyboardStates.IsKeyActive(Key.D2))
                {
                    screen.AddInput('@');
                }
                if (keyboardStates.IsKeyActive(Key.D3))
                {
                    screen.AddInput('#');
                }
                if (keyboardStates.IsKeyActive(Key.D4))
                {
                    screen.AddInput('$');
                }
                if (keyboardStates.IsKeyActive(Key.D5))
                {
                    screen.AddInput('%');
                }
                if (keyboardStates.IsKeyActive(Key.D6))
                {
                    screen.AddInput('^');
                }
                if (keyboardStates.IsKeyActive(Key.D7))
                {
                    screen.AddInput('&');
                }
                if (keyboardStates.IsKeyActive(Key.D8))
                {
                    screen.AddInput('*');
                }
                if (keyboardStates.IsKeyActive(Key.D9))
                {
                    screen.AddInput('(');
                }
                if (keyboardStates.IsKeyActive(Key.D0))
                {
                    screen.AddInput(')');
                }
                if (keyboardStates.IsKeyActive(Key.OemMinus))
                {
                    screen.AddInput('_');
                }
                if (keyboardStates.IsKeyActive(Key.OemPlus))
                {
                    screen.AddInput('+');
                }
            }
            else
            {
                if (keyboardStates.IsKeyActive(Key.Q))
                {
                    screen.AddInput('q');
                }
                if (keyboardStates.IsKeyActive(Key.W))
                {
                    screen.AddInput('w');
                }
                if (keyboardStates.IsKeyActive(Key.E))
                {
                    screen.AddInput('e');
                }
                if (keyboardStates.IsKeyActive(Key.R))
                {
                    screen.AddInput('r');
                }
                if (keyboardStates.IsKeyActive(Key.T))
                {
                    screen.AddInput('t');
                }
                if (keyboardStates.IsKeyActive(Key.Y))
                {
                    screen.AddInput('y');
                }
                if (keyboardStates.IsKeyActive(Key.U))
                {
                    screen.AddInput('u');
                }
                if (keyboardStates.IsKeyActive(Key.I))
                {
                    screen.AddInput('i');
                }
                if (keyboardStates.IsKeyActive(Key.O))
                {
                    screen.AddInput('o');
                }
                if (keyboardStates.IsKeyActive(Key.P))
                {
                    screen.AddInput('p');
                }
                if (keyboardStates.IsKeyActive(Key.OemOpenBrackets))
                {
                    screen.AddInput('[');
                }
                if (keyboardStates.IsKeyActive(Key.OemCloseBrackets))
                {
                    screen.AddInput(']');
                }
                if (keyboardStates.IsKeyActive(Key.OemBackslash))
                {
                    screen.AddInput('\\');
                }
                if (keyboardStates.IsKeyActive(Key.A))
                {
                    screen.AddInput('a');
                }
                if (keyboardStates.IsKeyActive(Key.S))
                {
                    screen.AddInput('s');
                }
                if (keyboardStates.IsKeyActive(Key.D))
                {
                    screen.AddInput('d');
                }
                if (keyboardStates.IsKeyActive(Key.F))
                {
                    screen.AddInput('f');
                }
                if (keyboardStates.IsKeyActive(Key.G))
                {
                    screen.AddInput('g');
                }
                if (keyboardStates.IsKeyActive(Key.H))
                {
                    screen.AddInput('h');
                }
                if (keyboardStates.IsKeyActive(Key.J))
                {
                    screen.AddInput('j');
                }
                if (keyboardStates.IsKeyActive(Key.K))
                {
                    screen.AddInput('k');
                }
                if (keyboardStates.IsKeyActive(Key.L))
                {
                    screen.AddInput('l');
                }
                if (keyboardStates.IsKeyActive(Key.OemSemicolon))
                {
                    screen.AddInput(';');
                }
                if (keyboardStates.IsKeyActive(Key.OemQuotes))
                {
                    screen.AddInput('\'');
                }
                if (keyboardStates.IsKeyActive(Key.Z))
                {
                    screen.AddInput('z');
                }
                if (keyboardStates.IsKeyActive(Key.X))
                {
                    screen.AddInput('x');
                }
                if (keyboardStates.IsKeyActive(Key.C))
                {
                    screen.AddInput('c');
                }
                if (keyboardStates.IsKeyActive(Key.V))
                {
                    screen.AddInput('v');
                }
                if (keyboardStates.IsKeyActive(Key.B))
                {
                    screen.AddInput('b');
                }
                if (keyboardStates.IsKeyActive(Key.N))
                {
                    screen.AddInput('n');
                }
                if (keyboardStates.IsKeyActive(Key.M))
                {
                    screen.AddInput('m');
                }
                if (keyboardStates.IsKeyActive(Key.OemComma))
                {
                    screen.AddInput(',');
                }
                if (keyboardStates.IsKeyActive(Key.OemPeriod))
                {
                    screen.AddInput('.');
                }
                if (keyboardStates.IsKeyActive(Key.OemQuestion))
                {
                    screen.AddInput('/');
                }
                if (keyboardStates.IsKeyActive(Key.Oem3))
                {
                    screen.AddInput('`');
                }
                if (keyboardStates.IsKeyActive(Key.D1))
                {
                    screen.AddInput('1');
                }
                if (keyboardStates.IsKeyActive(Key.D2))
                {
                    screen.AddInput('2');
                }
                if (keyboardStates.IsKeyActive(Key.D3))
                {
                    screen.AddInput('3');
                }
                if (keyboardStates.IsKeyActive(Key.D4))
                {
                    screen.AddInput('4');
                }
                if (keyboardStates.IsKeyActive(Key.D5))
                {
                    screen.AddInput('5');
                }
                if (keyboardStates.IsKeyActive(Key.D6))
                {
                    screen.AddInput('6');
                }
                if (keyboardStates.IsKeyActive(Key.D7))
                {
                    screen.AddInput('7');
                }
                if (keyboardStates.IsKeyActive(Key.D8))
                {
                    screen.AddInput('8');
                }
                if (keyboardStates.IsKeyActive(Key.D9))
                {
                    screen.AddInput('9');
                }
                if (keyboardStates.IsKeyActive(Key.D0))
                {
                    screen.AddInput('0');
                }
                if (keyboardStates.IsKeyActive(Key.OemMinus))
                {
                    screen.AddInput('-');
                }
                if (keyboardStates.IsKeyActive(Key.OemPlus))
                {
                    screen.AddInput('=');
                }
            }
            if (keyboardStates.IsKeyActive(Key.Back))
            {
                screen.Backspace();
            }
            if (keyboardStates.IsKeyActive(Key.Enter))
            {
                screen.ResetInput();
            }
            if (keyboardStates.IsKeyActive(Key.Space))
            {
                screen.AddInput(' ');
            }
            if (keyboardStates.IsKeyActive(Key.Delete))
            {
                screen.ResetInput();
            }
        }
    }
}
