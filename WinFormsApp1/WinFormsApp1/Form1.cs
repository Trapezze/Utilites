namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        int count = 0;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Кнопка отвечающая за успешное закрытие приложения
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Утилиты содержит ряд программ для демонстрации понимания C#");
            //Выводит информацию в окне "Помощь - О программе"
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
            //Плюс число
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //кнопка выхода
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
            //минус число
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int x;
            x = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = x.ToString();
            if (chkboxNotRepeat.Checked)
            //Логика для срабатывания галочки "Без повторения"
            {
                int y = 0;
                while (txtboxRandom.Text.IndexOf(x.ToString()) != -1)
                {
                    x = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    y++;
                    if (y > 350) break;
                    //Цикл прерывается если будет достигнут лимит в 350
                }
                if (y < 350) txtboxRandom.AppendText(x + "\n");
                //Переносим на новую строку текст из textbox
            }
            else txtboxRandom.AppendText(x + "\n");
            //Добавил чтобы не повторялись сгенерированные числа
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxRandom.Clear();
            //Кнопка для того чтобы стереть в окне накопившейся цифры
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtboxRandom.Text);
            //Кнопка для того чтобы скопировать в буфер обмена
        }

        private void chkboxNotRepeat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmPasteDate_Click(object sender, EventArgs e)
        {

        }
    }
}