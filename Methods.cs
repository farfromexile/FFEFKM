using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace FFEFKM
{
    internal static class Methods
    {


        public static void ForLogin(TextBox txtLoginMail, TextBox txtLoginPassword)
        {
            String loginmail = txtLoginMail.Text;
            String loginpassword = txtLoginPassword.Text;

            FFEEntities vt = new FFEEntities();

            var user = vt.Users.FirstOrDefault(u => u.UsersEPosta == loginmail && u.UsersPassword == loginpassword);

            if (user != null)
            {

                FFEFKM.AdminPages.AddInformations informations = new FFEFKM.AdminPages.AddInformations();
                LogIn login = new LogIn();
                login.Close();
                informations.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı veya şifre hatalı. Lütfen bilgilerinizi kontrol edin.");
            }
        }

        public static void ForRegisterLogin(TabControl tabControl)
        {
            int targetTabIndex = 1;

            if (targetTabIndex >= 0 && targetTabIndex < tabControl.TabCount)
            {
                tabControl.SelectedIndex = targetTabIndex;
            }
        }

        public static void ForLoginRegister(TabControl tabControl)
        {
            int targetTabIndex = 0;

            if (targetTabIndex >= 0 && targetTabIndex < tabControl.TabCount)
            {
                tabControl.SelectedIndex = targetTabIndex;
            }
        }

        public static void ForRegisterRegister(TextBox txt_registername,TextBox txt_registerpassword,TextBox txt_registermail,TextBox txt_registerphone, TextBox txtLoginMail, TextBox txtLoginPassword)
        {
            FFEEntities vt = new FFEEntities();

            String userName = txt_registername.Text;
            String userEmail = txt_registermail.Text;
            String userPassword = txt_registerpassword.Text;
            String userPhone = txt_registerphone.Text;

            int logId = vt.UsersLogs
              .Where(log => log.LogName == "Create")
              .Select(log => log.LogID)
              .FirstOrDefault();


            var newUser = new User
            {
                UsersName = userName,
                UsersEPosta = userEmail,
                UsersPassword = userPassword,
                UsersPhone = userPhone,
                Userslogid = logId

            };

            vt.Users.Add(newUser);
            vt.SaveChanges();

            MessageBox.Show("Kayıt başarıyla eklendi.");

            txtLoginMail.Text = userEmail;
            txtLoginPassword.Text = userPassword;
        }

        public static void ForClose(Form form)
        {
            form.Close();
        }


    }
}
