using System.ComponentModel;
using System.Windows.Forms;
//C:\Program Files (x86)\Microsoft Visual Studio\2019\Preview\Common7\IDE\devenv.exe
namespace DebugControlLibrary
{
    
    public partial class DebugControl : UserControl
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
                //The above breakpoint is never hit, and shows no symbols have been loaded for this document,Obviously it will show this 
                //until the debugging instance loads the form and or edits the DemoString, but in this .net 5 scenario, it never hits
                //Also the modules window shows no modules loaded at all, ever

                //In contrast, the exact same project running .net framework 4.8, performs correctly
                //when you start the project you can see all modules loaded,except the DebuggerControl, even before loading the solution in the 
                //debugging instance

            }
        }
    }
}
