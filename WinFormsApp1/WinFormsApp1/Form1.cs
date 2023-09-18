namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        int count = 0;
        Random rnd;
        char[] spec_chars = new char[]
            {
                '!','@','#','$','%','^','&','*','(',')','`','{','}'
            };
        Dictionary<string, double> metrica;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("km", 10000);
            metrica.Add("m", 1000);
            metrica.Add("mile", 11609344);
            metrica.Add("l", 1000);
            metrica.Add("ml", 100);
            metrica.Add("kg", 10000);
            metrica.Add("gm", 100);
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
            RTBNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }//Вставляем дату

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Кнопка выхода в контексном меню
        }

        private void tsmPasteTime_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }//Вставляем Время

        private void pasteTimedateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateTimeString = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()}";
            RTBNotepad.AppendText(dateTimeString + "\n");
            //Вставляем дату+время
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            try
            {
                RTBNotepad.SaveFile("notepad.rtf");
                //Кнопка для созранения
            }
            catch
            {
                MessageBox.Show("Error with saving!!!");
            }
        }

        void LoadNotepad()
        {
            try
            {
                RTBNotepad.LoadFile("notepad.rtf");
                //Кнопка загрузки
            }
            catch
            {
                MessageBox.Show("Error with loading!!!");
            }
        }
        // Через блок try-catch отлавливаем ошибки - "при загрузке" и "при сохранении" (файл notepad лежит в папке WinFormsApp1\bin\Debug\net6.0-windows
        //Ситуация как можно воспроизвести ошибку - удалить файл notepad, и ошибка будет выведена

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
            //Сохраняет последнюю операцию галочек для правила создания пароля
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudLenghtPass.Value; i++)
            {
                int p = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[p].ToString();
                switch (s)
                {
                    case "Numbers":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Capital Letters":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Lower case":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPassword.Text = password;
                Clipboard.SetText(password);
                //Сохраняем пароль в буфер обмена
            }
            //Кнопка и логика для создания пароля
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
            //Через обработчик (значок молнии) создали функцию 
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
            //Логика для того чтобы поменять местами значения. С ними же меняются и цифры
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Lenght":
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("km", 10000);
                    metrica.Add("m", 1000);
                    metrica.Add("mile", 11609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbFrom.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    break;

                case "Weight":
                    metrica.Clear();
                    metrica.Add("gm", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbFrom.Items.Clear();
                    cbTo.Items.Add("gm");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;
                default:
                    break;

            }
        }
    }
}