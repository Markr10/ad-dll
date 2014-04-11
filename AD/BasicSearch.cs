using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_Dll.Hoofdstuk_4;

namespace AD
{
    public partial class BasicSearch : FormConsole
    {
        public BasicSearch() : base(false)
        {
            InitializeComponent();
        }

        private void btnShowSeqSearch_Click(object sender, EventArgs e)
        {
            ShowConsole("Sequential search");
            int[] searchArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Search<int>.linear(searchArray, 3));
            CloseConsole();

        }
    }
}
