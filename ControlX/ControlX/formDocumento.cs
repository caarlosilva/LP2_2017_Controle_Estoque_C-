using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Word = Microsoft.Office.Interop.Word;

namespace ControlX
{
    public partial class formDocumento : Form
    {
        public formDocumento()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
