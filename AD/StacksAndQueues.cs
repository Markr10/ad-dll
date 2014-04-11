using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_5;

namespace AD
{
    public partial class StacksAndQueues : FormConsole
    {
        public StacksAndQueues() : base(false)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowConsole("Queue");
            new Queue().ToString();
            CloseConsole();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowConsole("Stack");
            new Stacks().ToString();
            CloseConsole();
        }
    }
}
