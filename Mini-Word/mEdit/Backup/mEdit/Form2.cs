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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // щелчок на WEB-ссылке
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //System.Diagnostics.Process.Start("IEXPLORE.EXE","http://kultin.ru");
           string webRef = linkLabel1.Text;
           System.Diagnostics.Process.Start(webRef);
        }

        
    }
}
