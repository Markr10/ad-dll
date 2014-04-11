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
    public partial class Stacks_and_Queues : FormConsole
    {
        public Stacks_and_Queues() : base(false)
        {
            InitializeComponent();
            ShowConsole("Hallo");
            textBox1.Text = new Stacks().ToString();
            CloseConsole();
        }
    }
}
