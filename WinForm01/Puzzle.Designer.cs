
namespace WinForm01
{
    partial class Puzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.tbAnsver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(296, 52);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Игра Угадай число.\r\nВ данной игре компьютер загадывает число от 1 до 100.\r\nПользо" +
    "ватель должен угадать это число. \r\nКоличество попыток неограничено.";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(12, 84);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(0, 13);
            this.lblReport.TabIndex = 1;
            // 
            // tbAnsver
            // 
            this.tbAnsver.Location = new System.Drawing.Point(142, 115);
            this.tbAnsver.Name = "tbAnsver";
            this.tbAnsver.Size = new System.Drawing.Size(100, 20);
            this.tbAnsver.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите ваше число:";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(142, 161);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(230, 161);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(50, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Новая игра";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 206);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnsver);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblInfo);
            this.Name = "Puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Угадай число";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Puzzle_FormClosing);
            this.Load += new System.EventHandler(this.Puzzle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox tbAnsver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnStart;
    }
}