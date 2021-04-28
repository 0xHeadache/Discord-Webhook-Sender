using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webhooktest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                     Username
                },
                {
                    "content",
                    msg
                }
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sendWebHook(textBox1.Text, textBox3.Text, textBox2.Text);
        }
    }
}
