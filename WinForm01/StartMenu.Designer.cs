namespace WinForm01
{
    partial class StartMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnPuzzle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(54, 12);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(121, 23);
            this.btnMulti.TabIndex = 0;
            this.btnMulti.Text = "Игра удвоитель";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnPuzzle
            // 
            this.btnPuzzle.Location = new System.Drawing.Point(54, 67);
            this.btnPuzzle.Name = "btnPuzzle";
            this.btnPuzzle.Size = new System.Drawing.Size(121, 23);
            this.btnPuzzle.TabIndex = 1;
            this.btnPuzzle.Text = "Игра Угадай число";
            this.btnPuzzle.UseVisualStyleBackColor = true;
            this.btnPuzzle.Click += new System.EventHandler(this.btnPuzzle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(54, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 183);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPuzzle);
            this.Controls.Add(this.btnMulti);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Давай играть";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnPuzzle;
        private System.Windows.Forms.Button btnExit;
    }
}

