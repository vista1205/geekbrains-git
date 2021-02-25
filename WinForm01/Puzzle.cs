using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Puzzle : Form
    {
        private DialogResult otherDialogresult = DialogResult.None;
        public DialogResult OtherDialogResult
        {
            get { return otherDialogresult; }
        }
        int chislo;
        int count;
        Random rnd = new Random();
        public Puzzle()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                btnStart.Enabled = true;
                int answer = Convert.ToInt32(tbAnsver.Text);
                if (answer < 1 || answer > 100)
                {
                    MessageBox.Show(this, "Вы должны ввести число от 1 до 100!", "Надо ввести число заново!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbAnsver.Text = "1";
                }
                if (answer > chislo)
                {
                    lblReport.Text = "Ваше число больше!";
                }
                if (answer < chislo)
                {
                    lblReport.Text = "Ваше число меньше!";
                }
                if (answer == chislo)
                    MessageBox.Show(this, $"Вы победили! Вы отгадали загаданное число за {count} попыток", "Поздравляем!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
                
        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            chislo = rnd.Next(1, 100);
            tbAnsver.Text = "";
            lblReport.Text = "";
            count = 0;
        }

        private void Puzzle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (otherDialogresult != DialogResult.Abort)
            {
                if(MessageBox.Show(this, "Вы действительно желаете завершить работу приложения?",
                "Завершение работы", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    otherDialogresult = DialogResult.Cancel;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите выйти в меню?",
                "Выход в меню", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                otherDialogresult = DialogResult.Abort;
                Close();
            }
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            chislo = rnd.Next(1, 100);
            count = 0;
            btnStart.Enabled = false;
        }
    }
}
