/*
// Read keystroke from the console by using ReadKey(0.

using System;

class ReadKeys
{
    static void Main()
    {
        ConsoleKeyInfo KeyPress;

        Console.WriteLine("Enter Keystrokes. Enter Q to Stop.");

        do
        {
            KeyPress = Console.ReadKey(); // read keystrokes

            Console.WriteLine(" Your Key is: " + KeyPress.KeyChar);

            if ((ConsoleModifiers.Alt & KeyPress.Modifiers) != 0)
                Console.WriteLine("Alt key pressed.");
            if ((ConsoleModifiers.Control & KeyPress.Modifiers) != 0)
                Console.WriteLine("Control key pressed.");
            if ((ConsoleModifiers.Shift & KeyPress.Modifiers) != 0)
                Console.WriteLine("Shift Key Pressed.");
        }
        while
        (KeyPress.KeyChar != 'Q');
    }
}
*/