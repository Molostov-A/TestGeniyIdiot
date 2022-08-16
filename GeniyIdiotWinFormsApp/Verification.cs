using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public class Verification
    {
        public (bool,int) CheckNumericInput(string answer)
        {
            try
            {
                var answerConvert = Convert.ToInt32(answer);
                return (true, answerConvert);
            }
            catch (OverflowException)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Пожалуйста, введите число от -2*10^9 до 2*10^9!", "Неверный ввод", buttons);
                return (false, -1);
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Пожалуйста, введите число!", "Неверный ввод", buttons);
                return (false, -1);
            }
        }
        public bool EmptyName(string nameUser)
        {
            if (nameUser != "")
            {
                return false;
            }
            return true;
        }
    }
}
