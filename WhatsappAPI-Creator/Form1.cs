using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace WhatsappAPI_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string CustomTXT = TextW.Text;
            
            var output = CustomTXT.UrlEncode();
            string WhatsappAPI = "https://api.whatsapp.com/send?phone=" + NumberW.Text + "&text=" + output;
            string url = EncurteURL.EncurtadorUrl(new Uri(WhatsappAPI));
            API.Text = url;
        }
    }
}
