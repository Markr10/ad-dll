using System;
using System.Windows.Forms;

namespace AD
{
    /// <summary>
    /// Een form dat rekening houdt met de console. Wordt gebruikt als basis voor
    /// andere Forms
    /// </summary>
    public class FormConsole : Form
    {
        [Obsolete("Designer only", true)]
        private FormConsole() { }

        /// <summary>
        /// Constructor die het close event voor het object van de klasse FormConsole instelt
        /// </summary>
        /// <param name="setCloseEvent">Geeft aan of het close event
        /// aan het object moet worden toegevoegd</param>
        public FormConsole(bool setCloseEvent)
        {
            if (setCloseEvent)
            {
                this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsole_FormClosed);
            }
        }

        /// <summary>
        /// Toont de console en schrijft er een regel tekst naar toe
        /// </summary>
        /// <param name="text">De tekst die naar de console geschreven moet worden</param>
        /// <param name="title">De titel van het consolevenster</param>
        protected void WriteFirstLine(string text, string title)
        {
            ShowConsole(title);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Toont de console
        /// </summary>
        /// <param name="title">De titel van het consolevenster</param>
        protected void ShowConsole(string title)
        {
            // Stel altijd de titel van het consolevenster in omdat dat er nice uitziet
            // Titel wordt later verder gefilterd
            if (title != null && Console.Title != title)
            {
                Program.setConsoleWindowVisibility(true, title);
            }
            else if (Console.Title != title && Console.Title != this.Text)
            {
                Program.setConsoleWindowVisibility(true, this.Text);
            }
            else
            {
                Program.setConsoleWindowVisibility(true);
            }

            this.Hide();
        }

        /// <summary>
        /// Schrijft een regel tekst naar de console. Bovendien zorgt deze methode ervoor
        /// dat de gebruiker terug kan gaan naar het vorige venster en de console verborgen wordt
        /// </summary>
        /// <remarks>De console moet open staan voordat deze methode aangeroepen wordt</remarks>
        /// <param name="text">De tekst die naar de console geschreven moet worden</param>
        protected void WriteLastLine(String text)
        {
            Console.WriteLine(text);
            CloseConsole();
        }

        /// <summary>
        /// Pauzeert de console totdat de gebruiker een toets indrukt
        /// </summary>
        /// <remarks>Voegt van te voren een lege lijn in</remarks>
        protected void PauseConsole()
        {
            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Zorgt ervoor dat de gebruiker terug kan gaan naar het vorige venster en
        /// de console verborgen wordt
        /// </summary>
        /// <remarks>De console moet open staan voordat deze methode aangeroepen wordt</remarks>
        protected void CloseConsole()
        {
            PauseConsole();
            this.Show();
            Program.setConsoleWindowVisibility(false);

            if (Program.clearScreen)
            {
                Console.Clear();
            }
        }


        /// <summary>
        /// Event handler om te voorkomen dat cmd.exe afgesloten wordt,
        /// wanneer de applicatie via cmd.exe aangeroepen is
        /// </summary>
        /// <param name="sender">De afzender van het event</param>
        /// <param name="e">Een FormClosedEventArgs object die de gegevens van het event bevat</param>
        private void FormConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.setConsoleWindowVisibility(true);
        }
    }
}
