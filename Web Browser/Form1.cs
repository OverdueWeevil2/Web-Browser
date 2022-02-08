using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxTA.KeyDown += TXTA_KeyDown;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(TxTA.Text));
        }
        
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TxTA.Text = e.Url.ToString();
        }
        
        private void TXTA_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
              webBrowser1.Navigate(new Uri(TxTA.Text));
           }
        }
    }
}
