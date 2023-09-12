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
            // ������ ���������� �� �������� �������� ����������
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� �������� ��� �������� ��� ������������ ��������� C#");
            //������� ���������� � ���� "������ - � ���������"
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
            //���� �����
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //������ ������
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
            //����� �����
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
            //������ ��� ������������ ������� "��� ����������"
            {
                int y = 0;
                while (txtboxRandom.Text.IndexOf(x.ToString()) != -1)
                {
                    x = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    y++;
                    if (y > 350) break;
                    //���� ����������� ���� ����� ��������� ����� � 350
                }
                if (y < 350) txtboxRandom.AppendText(x + "\n");
                //��������� �� ����� ������ ����� �� textbox
            }
            else txtboxRandom.AppendText(x + "\n");
            //������� ����� �� ����������� ��������������� �����
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxRandom.Clear();
            //������ ��� ���� ����� ������� � ���� ������������ �����
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtboxRandom.Text);
            //������ ��� ���� ����� ����������� � ����� ������
        }

        private void chkboxNotRepeat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmPasteDate_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }//��������� ����

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //������ ������ � ���������� ����
        }

        private void tsmPasteTime_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }//��������� �����

        private void pasteTimedateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortTimeString() + DateTime.Now + "\n");
        }// ��������� �����+����

        private void tsmSave_Click(object sender, EventArgs e)
        {
            try
            {
                RTBNotepad.SaveFile("notepad.rtf");
                //������ ��� ����������
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
                //������ ��������
            }
            catch
            {
                MessageBox.Show("Error with loading!!!");
            }
        }
        // ����� ���� try-catch ����������� ������ - "��� ��������" � "��� ����������" (���� notepad ����� � ����� WinFormsApp1\bin\Debug\net6.0-windows
        //�������� ��� ����� ������������� ������ - ������� ���� notepad, � ������ ����� ��������

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
        //����� ���������� (������ ������) ������� ������� 
    }
}