
namespace WinForm01
{
    partial class Multi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuzzle = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPuzzle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Необходимо набрать число: ";
            // 
            // lblPuzzle
            // 
            this.lblPuzzle.AutoSize = true;
            this.lblPuzzle.Location = new System.Drawing.Point(165, 26);
            this.lblPuzzle.Name = "lblPuzzle";
            this.lblPuzzle.Size = new System.Drawing.Size(0, 13);
            this.lblPuzzle.TabIndex = 1;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(12, 106);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(199, 20);
            this.tbAnswer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество сделанных ходов:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(175, 142);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 174);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(136, 174);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "*2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Отменить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(175, 215);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(95, 215);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Сброс";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 251);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Multi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра удвоитель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Multi_FormClosing);
            this.Load += new System.EventHandler(this.Multi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPuzzle;
        public System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnRestart;
    }
}