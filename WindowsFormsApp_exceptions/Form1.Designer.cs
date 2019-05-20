namespace WindowsFormsApp_exceptions
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_kw = new System.Windows.Forms.TextBox();
            this.textBox_pr = new System.Windows.Forms.TextBox();
            this.textBox_pr2 = new System.Windows.Forms.TextBox();
            this.textBox_multiply1 = new System.Windows.Forms.TextBox();
            this.textBox_multiply2 = new System.Windows.Forms.TextBox();
            this.textBox_divide1 = new System.Windows.Forms.TextBox();
            this.textBox_divide2 = new System.Windows.Forms.TextBox();
            this.checkBox_kwadrat = new System.Windows.Forms.CheckBox();
            this.checkBox_obwod = new System.Windows.Forms.CheckBox();
            this.checkBox_pomnoz = new System.Windows.Forms.CheckBox();
            this.checkBox_divide = new System.Windows.Forms.CheckBox();
            this.textBox1_kw_ans = new System.Windows.Forms.TextBox();
            this.textBox_ob_ans = new System.Windows.Forms.TextBox();
            this.textBox_mul_ans = new System.Windows.Forms.TextBox();
            this.textBox_div_ans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox_kw
            // 
            this.textBox_kw.Location = new System.Drawing.Point(13, 13);
            this.textBox_kw.Name = "textBox_kw";
            this.textBox_kw.Size = new System.Drawing.Size(100, 22);
            this.textBox_kw.TabIndex = 1;
            // 
            // textBox_pr
            // 
            this.textBox_pr.Location = new System.Drawing.Point(13, 41);
            this.textBox_pr.Name = "textBox_pr";
            this.textBox_pr.Size = new System.Drawing.Size(100, 22);
            this.textBox_pr.TabIndex = 1;
            // 
            // textBox_pr2
            // 
            this.textBox_pr2.Location = new System.Drawing.Point(119, 41);
            this.textBox_pr2.Name = "textBox_pr2";
            this.textBox_pr2.Size = new System.Drawing.Size(100, 22);
            this.textBox_pr2.TabIndex = 1;
            // 
            // textBox_multiply1
            // 
            this.textBox_multiply1.Location = new System.Drawing.Point(13, 69);
            this.textBox_multiply1.Name = "textBox_multiply1";
            this.textBox_multiply1.Size = new System.Drawing.Size(100, 22);
            this.textBox_multiply1.TabIndex = 1;
            // 
            // textBox_multiply2
            // 
            this.textBox_multiply2.Location = new System.Drawing.Point(119, 69);
            this.textBox_multiply2.Name = "textBox_multiply2";
            this.textBox_multiply2.Size = new System.Drawing.Size(100, 22);
            this.textBox_multiply2.TabIndex = 1;
            // 
            // textBox_divide1
            // 
            this.textBox_divide1.Location = new System.Drawing.Point(13, 97);
            this.textBox_divide1.Name = "textBox_divide1";
            this.textBox_divide1.Size = new System.Drawing.Size(100, 22);
            this.textBox_divide1.TabIndex = 1;
            // 
            // textBox_divide2
            // 
            this.textBox_divide2.Location = new System.Drawing.Point(119, 97);
            this.textBox_divide2.Name = "textBox_divide2";
            this.textBox_divide2.Size = new System.Drawing.Size(100, 22);
            this.textBox_divide2.TabIndex = 1;
            // 
            // checkBox_kwadrat
            // 
            this.checkBox_kwadrat.AutoSize = true;
            this.checkBox_kwadrat.Location = new System.Drawing.Point(245, 14);
            this.checkBox_kwadrat.Name = "checkBox_kwadrat";
            this.checkBox_kwadrat.Size = new System.Drawing.Size(119, 21);
            this.checkBox_kwadrat.TabIndex = 2;
            this.checkBox_kwadrat.Text = "Pole kwadrata";
            this.checkBox_kwadrat.UseVisualStyleBackColor = true;
            // 
            // checkBox_obwod
            // 
            this.checkBox_obwod.AutoSize = true;
            this.checkBox_obwod.Location = new System.Drawing.Point(245, 41);
            this.checkBox_obwod.Name = "checkBox_obwod";
            this.checkBox_obwod.Size = new System.Drawing.Size(91, 21);
            this.checkBox_obwod.TabIndex = 2;
            this.checkBox_obwod.Text = "Obwód pr";
            this.checkBox_obwod.UseVisualStyleBackColor = true;
            // 
            // checkBox_pomnoz
            // 
            this.checkBox_pomnoz.AutoSize = true;
            this.checkBox_pomnoz.Location = new System.Drawing.Point(245, 70);
            this.checkBox_pomnoz.Name = "checkBox_pomnoz";
            this.checkBox_pomnoz.Size = new System.Drawing.Size(77, 21);
            this.checkBox_pomnoz.TabIndex = 2;
            this.checkBox_pomnoz.Text = "Multiply";
            this.checkBox_pomnoz.UseVisualStyleBackColor = true;
            // 
            // checkBox_divide
            // 
            this.checkBox_divide.AutoSize = true;
            this.checkBox_divide.Location = new System.Drawing.Point(245, 97);
            this.checkBox_divide.Name = "checkBox_divide";
            this.checkBox_divide.Size = new System.Drawing.Size(69, 21);
            this.checkBox_divide.TabIndex = 2;
            this.checkBox_divide.Text = "Divide";
            this.checkBox_divide.UseVisualStyleBackColor = true;
            // 
            // textBox1_kw_ans
            // 
            this.textBox1_kw_ans.Location = new System.Drawing.Point(462, 14);
            this.textBox1_kw_ans.Name = "textBox1_kw_ans";
            this.textBox1_kw_ans.Size = new System.Drawing.Size(100, 22);
            this.textBox1_kw_ans.TabIndex = 1;
            // 
            // textBox_ob_ans
            // 
            this.textBox_ob_ans.Location = new System.Drawing.Point(462, 42);
            this.textBox_ob_ans.Name = "textBox_ob_ans";
            this.textBox_ob_ans.Size = new System.Drawing.Size(100, 22);
            this.textBox_ob_ans.TabIndex = 1;
            // 
            // textBox_mul_ans
            // 
            this.textBox_mul_ans.Location = new System.Drawing.Point(462, 70);
            this.textBox_mul_ans.Name = "textBox_mul_ans";
            this.textBox_mul_ans.Size = new System.Drawing.Size(100, 22);
            this.textBox_mul_ans.TabIndex = 1;
            this.textBox_mul_ans.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // textBox_div_ans
            // 
            this.textBox_div_ans.Location = new System.Drawing.Point(462, 98);
            this.textBox_div_ans.Name = "textBox_div_ans";
            this.textBox_div_ans.Size = new System.Drawing.Size(100, 22);
            this.textBox_div_ans.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_divide);
            this.Controls.Add(this.checkBox_pomnoz);
            this.Controls.Add(this.checkBox_obwod);
            this.Controls.Add(this.checkBox_kwadrat);
            this.Controls.Add(this.textBox_divide2);
            this.Controls.Add(this.textBox_multiply2);
            this.Controls.Add(this.textBox_pr2);
            this.Controls.Add(this.textBox_div_ans);
            this.Controls.Add(this.textBox_divide1);
            this.Controls.Add(this.textBox_mul_ans);
            this.Controls.Add(this.textBox_multiply1);
            this.Controls.Add(this.textBox_ob_ans);
            this.Controls.Add(this.textBox_pr);
            this.Controls.Add(this.textBox1_kw_ans);
            this.Controls.Add(this.textBox_kw);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Exceptions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_kw;
        private System.Windows.Forms.TextBox textBox_pr;
        private System.Windows.Forms.TextBox textBox_pr2;
        private System.Windows.Forms.TextBox textBox_multiply1;
        private System.Windows.Forms.TextBox textBox_multiply2;
        private System.Windows.Forms.TextBox textBox_divide1;
        private System.Windows.Forms.TextBox textBox_divide2;
        private System.Windows.Forms.CheckBox checkBox_kwadrat;
        private System.Windows.Forms.CheckBox checkBox_obwod;
        private System.Windows.Forms.CheckBox checkBox_pomnoz;
        private System.Windows.Forms.CheckBox checkBox_divide;
        private System.Windows.Forms.TextBox textBox1_kw_ans;
        private System.Windows.Forms.TextBox textBox_ob_ans;
        private System.Windows.Forms.TextBox textBox_mul_ans;
        private System.Windows.Forms.TextBox textBox_div_ans;
    }
}

