namespace AES
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gB_KeyS = new System.Windows.Forms.GroupBox();
            this.rB_256b = new System.Windows.Forms.RadioButton();
            this.rB_192b = new System.Windows.Forms.RadioButton();
            this.rB_128b = new System.Windows.Forms.RadioButton();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_code = new System.Windows.Forms.Button();
            this.btn_encode = new System.Windows.Forms.Button();
            this.lbl_base = new System.Windows.Forms.Label();
            this.tB_in = new System.Windows.Forms.TextBox();
            this.lbl_out = new System.Windows.Forms.Label();
            this.tB_out = new System.Windows.Forms.TextBox();
            this.gB_KeyS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_KeyS
            // 
            this.gB_KeyS.Controls.Add(this.rB_256b);
            this.gB_KeyS.Controls.Add(this.rB_192b);
            this.gB_KeyS.Controls.Add(this.rB_128b);
            this.gB_KeyS.Location = new System.Drawing.Point(12, 12);
            this.gB_KeyS.Name = "gB_KeyS";
            this.gB_KeyS.Size = new System.Drawing.Size(126, 92);
            this.gB_KeyS.TabIndex = 0;
            this.gB_KeyS.TabStop = false;
            this.gB_KeyS.Text = "Размер ключа";
            // 
            // rB_256b
            // 
            this.rB_256b.AutoSize = true;
            this.rB_256b.Location = new System.Drawing.Point(17, 65);
            this.rB_256b.Name = "rB_256b";
            this.rB_256b.Size = new System.Drawing.Size(62, 17);
            this.rB_256b.TabIndex = 2;
            this.rB_256b.Text = "256 bits";
            this.rB_256b.UseVisualStyleBackColor = true;
            // 
            // rB_192b
            // 
            this.rB_192b.AutoSize = true;
            this.rB_192b.Checked = true;
            this.rB_192b.Location = new System.Drawing.Point(17, 42);
            this.rB_192b.Name = "rB_192b";
            this.rB_192b.Size = new System.Drawing.Size(62, 17);
            this.rB_192b.TabIndex = 1;
            this.rB_192b.TabStop = true;
            this.rB_192b.Text = "192 bits";
            this.rB_192b.UseVisualStyleBackColor = true;
            // 
            // rB_128b
            // 
            this.rB_128b.AutoSize = true;
            this.rB_128b.Location = new System.Drawing.Point(17, 19);
            this.rB_128b.Name = "rB_128b";
            this.rB_128b.Size = new System.Drawing.Size(62, 17);
            this.rB_128b.TabIndex = 0;
            this.rB_128b.Text = "128 bits";
            this.rB_128b.UseVisualStyleBackColor = true;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(158, 12);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(96, 23);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Обзор";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_code
            // 
            this.btn_code.Location = new System.Drawing.Point(158, 45);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(96, 23);
            this.btn_code.TabIndex = 2;
            this.btn_code.Text = "Зашифровать";
            this.btn_code.UseVisualStyleBackColor = true;
            this.btn_code.Click += new System.EventHandler(this.btn_code_Click);
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(158, 77);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(96, 23);
            this.btn_encode.TabIndex = 3;
            this.btn_encode.Text = "Расшифровать";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(281, 12);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(87, 13);
            this.lbl_base.TabIndex = 4;
            this.lbl_base.Text = "Исходный файл";
            // 
            // tB_in
            // 
            this.tB_in.Location = new System.Drawing.Point(284, 31);
            this.tB_in.Name = "tB_in";
            this.tB_in.Size = new System.Drawing.Size(366, 20);
            this.tB_in.TabIndex = 5;
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Location = new System.Drawing.Point(281, 58);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(216, 13);
            this.lbl_out.TabIndex = 6;
            this.lbl_out.Text = "Зашифрованный/расшифрованный файл";
            // 
            // tB_out
            // 
            this.tB_out.Location = new System.Drawing.Point(284, 80);
            this.tB_out.Name = "tB_out";
            this.tB_out.Size = new System.Drawing.Size(366, 20);
            this.tB_out.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 112);
            this.Controls.Add(this.tB_out);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.tB_in);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.btn_code);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.gB_KeyS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AES";
            this.gB_KeyS.ResumeLayout(false);
            this.gB_KeyS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_KeyS;
        private System.Windows.Forms.RadioButton rB_256b;
        private System.Windows.Forms.RadioButton rB_192b;
        private System.Windows.Forms.RadioButton rB_128b;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_code;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.TextBox tB_in;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.TextBox tB_out;
    }
}

