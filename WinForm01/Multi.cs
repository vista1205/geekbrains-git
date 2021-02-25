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
    public partial class Multi : Form
    {
        private DialogResult otherDialogresult = DialogResult.None;
        public DialogResult OtherDialogResult
        {
            get { return otherDialogresult; }
        }
        private Random rnd = new Random();
        private int pyzzlecount;
        private int useranswer;
        public static int coutClick;
        private List<bool> Operation = new List<bool>(30);
        public Multi()
        {
            InitializeComponent();
        }

        private void Multi_Load(object sender, EventArgs e)
        {
            pyzzlecount = rnd.Next(1, 100);
            coutClick = 0;
            tbAnswer.Text = "1";
            useranswer = 1;
            lblPuzzle.Text = pyzzlecount.ToString();
            lblCount.Text = coutClick.ToString();
            btnReset.Enabled = false;
            btnRestart.Enabled = false;
        }
        private void MessageFinish()
        {
            if (useranswer == pyzzlecount)
            {
                MessageBox.Show($"Поздравляем! Вы выиграли! Вы сделали {coutClick} ходов!",
                        "Вы Выиграли!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            btnRestart.Enabled = true;
            Operation.Add(true);
            useranswer++;
            tbAnswer.Text = useranswer.ToString();
            coutClick++;
            lblCount.Text = coutClick.ToString();
            MessageFinish();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            btnRestart.Enabled = true;
            Operation.Add(false);
            useranswer*=2;
            tbAnswer.Text = useranswer.ToString();
            coutClick++;
            lblCount.Text = coutClick.ToString();
            MessageFinish();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (Operation.Count != 0)
            {
                if (Operation[Operation.Count - 1])
                {
                    useranswer--;
                }
                else
                {
                    useranswer /= 2;
                }
                Operation.RemoveAt(Operation.Count - 1);
                tbAnswer.Text = useranswer.ToString();
                lblCount.Text = coutClick.ToString();
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

        private void Multi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (otherDialogresult != DialogResult.Abort)
            {
                if (MessageBox.Show(this, "Вы действительно желаете завершить работу приложения?",
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pyzzlecount = rnd.Next(1, 100);
            coutClick = 0;
            tbAnswer.Text = "1";
            useranswer = 1;
            lblPuzzle.Text = pyzzlecount.ToString();
            lblCount.Text = coutClick.ToString();
            btnReset.Enabled = false;
            btnRestart.Enabled = false;
        }
    }
}
