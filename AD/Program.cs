using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        public static readonly bool clearScreen;

        static Program()
        {
            // Save argument for later use and clear console window because that's expected.
            if (Environment.GetCommandLineArgs().Length > 1 && Environment.GetCommandLineArgs()[1] == "-noClear")
            {
                clearScreen = false;
            }
            else
            {
                clearScreen = true;
                Console.Clear();
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">-noClear - Use the argument "-noClear" for not clearing the console window on starting up and
        /// when outputting text to it.</param>
        [STAThread]
        static void Main(string[] args)
        {
            // Hide the console window
            setConsoleWindowVisibility(false);
            // Open your form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        /// <summary>
        /// Set the visibility of the console window en sets the title of the console window.
        /// </summary>
        /// <param name="visible">The visibilty of the console window.</param>
        public static void setConsoleWindowVisibility(bool visible)
        {
            IntPtr hWnd = GetConsoleWindow();

            if (hWnd != IntPtr.Zero)
            {
                if (!visible)
                {
                    // Hide the window
                    ShowWindow(hWnd, 0); // 0 = SW_HIDE
                }
                else
                {
                    // Show the window again
                    ShowWindow(hWnd, 1); // 1 = SW_SHOWNORMA
                }
            }
        }

        /// <summary>
        /// Set the visibility of the console window en sets the title of the console window.
        /// </summary>
        /// <param name="visible">The visibilty of the console window.</param>
        /// <param name="title">The title for the console window. No title is set if
        /// the title is empty or only consist of whitespace.</param>
        public static void setConsoleWindowVisibility(bool visible, string title)
        {
            if (title != null && title.Trim().Length != 0)
            {
                Console.Title = title;
            }

            setConsoleWindowVisibility(visible);
        }
    }
}