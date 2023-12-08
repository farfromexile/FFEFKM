using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FFEFKM
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_loginlogin_Click(object sender, EventArgs e)
        {
            Methods.ForLogin(txt_loginmail, txt_loginpassword);
        }

        private void btn_registerlogin_Click(object sender, EventArgs e)
        {
            Methods.ForRegisterLogin(tabcontrol);
        }

        private void btn_loginregister_Click(object sender, EventArgs e)
        {
            Methods.ForLoginRegister(tabcontrol);
        }


        private void btn_registerregister_Click(object sender, EventArgs e)
        {
            Methods.ForRegisterRegister(txt_registername, txt_registerpassword, txt_registermail, txt_registerphone,txt_loginmail, txt_loginpassword);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Methods.ForClose(this);
        }
    }
}

