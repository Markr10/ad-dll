using AD_Dll.Hoofdstuk_5;
using System;

namespace AD
{
    public partial class StacksAndQueues : FormConsole
    {
        public StacksAndQueues() : base(false)
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            ShowConsole("Stack");
            new Stacks();
            CloseConsole();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            ShowConsole("Queue");
            new Queue();
            CloseConsole();
        }
    }
}
