using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class vrijemefrm : Form
    {
        public vrijemefrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            webBrowser1.Navigate("https://www.google.hr/search?q=vrijeme");
        }
    }
}
