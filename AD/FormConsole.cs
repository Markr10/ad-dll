using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    public class FormConsole : Form
    {
        protected void WriteFirstLine(string text, string title)
        {
            ShowConsole(text);
            Console.WriteLine(text);
        }

        protected void ShowConsole(string title)
        {
            // Set always a console window title because that looks nicer
            // Title wordt later verder gefilterd.
            if (title != null && Console.Title != title)
            {
                Program.setConsoleWindowVisibility(true, title);
            }
            else if (Console.Title != this.Text)
            {
                Program.setConsoleWindowVisibility(true, this.Text);
            }
            else
            {
                Program.setConsoleWindowVisibility(true);
            }

            this.Hide();

            if (Program.clearScreen)
            {
                Console.Clear();
            }
        }

        protected void WriteLastLine(String text)
        {
            Console.WriteLine(text);
            CloseConsole();
        }

        protected void CloseConsole()
        {
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            this.Show();
            Program.setConsoleWindowVisibility(false);
        }
    }
}
