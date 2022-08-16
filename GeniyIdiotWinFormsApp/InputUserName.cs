using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class InputUserName : Form
    {
        public UsersStorage usersStorage = new();
        private Verification verification = new();
        public InputUserName()
        {
            InitializeComponent();
        }

        private void InputUserName_Load(object sender, EventArgs e)
        {
            usersStorage.RewriteCurrentUser(null);
            enterUserName_Button.Text = "Далее";
            if (MyConstant.StartingGreeting)
            {
                startingGreeting_Lable.Text = MyConstant.Greeting;
                MyConstant.StartingGreeting = false;
            }
            inputNameUser_Label.Text = "Пожалуйста, введите своё имя:";
            
        }

        private void enterUserNameButton_Click(object sender, EventArgs e)
        {
            var name = inputUserName_TextBox.Text;
            if (!verification.EmptyName(name))
            {
                usersStorage.RewriteCurrentUser(name);
                Hide();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Пожалуйста, введите своё имя", "Неверный ввод", buttons);
            }
        }


    }
}
