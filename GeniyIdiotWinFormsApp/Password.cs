using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class Password : Form
    {
        private UsersStorage usersStorage = new();
        public Password()
        {
            InitializeComponent();
        }
        private void enterPassword_button_Click(object sender, EventArgs e)
        {
            if (usersStorage.Autorization(password_textBox.Text, "admin"))
            {
                if(remember_checkBox.Checked)
                {
                    MyConstant.AdminAutorisation = true;
                }
                Hide();
                var AdminPanel = new AdminPanelForm();
                AdminPanel.ShowDialog();
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Вы ввели неверный пароль \nЖелаете повторить ввод?", "Внимание", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    password_textBox.Clear();
                }
                if (result == DialogResult.No)
                {
                    Application.Restart();
                }
            }
        }

    }
}
