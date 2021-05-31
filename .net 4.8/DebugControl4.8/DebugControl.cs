using System.ComponentModel;
using System.Windows.Forms;

namespace DebugControlLibrary
{
    public partial class DebugControl: UserControl
    {
        public DebugControl()
        {
            InitializeComponent();
        }
        private string demoStringValue = null;
        [Browsable(true)]
        public string DemoString
        {
            get
            {
                return this.demoStringValue;
            }
            set
            {
                demoStringValue = value;
            }
        }
    }
}
