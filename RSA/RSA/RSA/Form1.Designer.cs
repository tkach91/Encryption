namespace RSA
{
    partial class RSA_alg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA_alg));
            this.tab_code = new System.Windows.Forms.TabControl();
            this.tbaPEncode = new System.Windows.Forms.TabPage();
            this.btn_decode = new System.Windows.Forms.Button();
            this.btn_getFile = new System.Windows.Forms.Button();
            this.tB_mod = new System.Windows.Forms.TextBox();
            this.tB_key = new System.Windows.Forms.TextBox();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.lblo_key = new System.Windows.Forms.Label();
            this.btn_encode = new System.Windows.Forms.Button();
            this.tB_encode = new System.Windows.Forms.TextBox();
            this.lbl_after_encode = new System.Windows.Forms.Label();
            this.lbl_base = new System.Windows.Forms.Label();
            this.tB_base = new System.Windows.Forms.TextBox();
            this.tP_generate = new System.Windows.Forms.TabPage();
            this.tB_d = new System.Windows.Forms.TextBox();
            this.tB_n = new System.Windows.Forms.TextBox();
            this.tB_e = new System.Windows.Forms.TextBox();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl_e = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tab_code.SuspendLayout();
            this.tbaPEncode.SuspendLayout();
            this.tP_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_code
            // 
            this.tab_code.Controls.Add(this.tbaPEncode);
            this.tab_code.Controls.Add(this.tP_generate);
            this.tab_code.Location = new System.Drawing.Point(11, 11);
            this.tab_code.Name = "tab_code";
            this.tab_code.SelectedIndex = 0;
            this.tab_code.Size = new System.Drawing.Size(278, 255);
            this.tab_code.TabIndex = 1;
            // 
            // tbaPEncode
            // 
            this.tbaPEncode.Controls.Add(this.btn_decode);
            this.tbaPEncode.Controls.Add(this.btn_getFile);
            this.tbaPEncode.Controls.Add(this.tB_mod);
            this.tbaPEncode.Controls.Add(this.tB_key);
            this.tbaPEncode.Controls.Add(this.lbl_mod);
            this.tbaPEncode.Controls.Add(this.lblo_key);
            this.tbaPEncode.Controls.Add(this.btn_encode);
            this.tbaPEncode.Controls.Add(this.tB_encode);
            this.tbaPEncode.Controls.Add(this.lbl_after_encode);
            this.tbaPEncode.Controls.Add(this.lbl_base);
            this.tbaPEncode.Controls.Add(this.tB_base);
            this.tbaPEncode.Location = new System.Drawing.Point(4, 22);
            this.tbaPEncode.Name = "tbaPEncode";
            this.tbaPEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tbaPEncode.Size = new System.Drawing.Size(270, 229);
            this.tbaPEncode.TabIndex = 0;
            this.tbaPEncode.Text = "Шифровать";
            this.tbaPEncode.UseVisualStyleBackColor = true;
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(172, 181);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(92, 33);
            this.btn_decode.TabIndex = 12;
            this.btn_decode.Text = "Декодировать";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // btn_getFile
            // 
            this.btn_getFile.Location = new System.Drawing.Point(14, 6);
            this.btn_getFile.Name = "btn_getFile";
            this.btn_getFile.Size = new System.Drawing.Size(250, 23);
            this.btn_getFile.TabIndex = 11;
            this.btn_getFile.Text = "Выбрать файл";
            this.btn_getFile.UseVisualStyleBackColor = true;
            this.btn_getFile.Click += new System.EventHandler(this.btn_getFile_Click);
            // 
            // tB_mod
            // 
            this.tB_mod.Location = new System.Drawing.Point(56, 188);
            this.tB_mod.Name = "tB_mod";
            this.tB_mod.Size = new System.Drawing.Size(110, 20);
            this.tB_mod.TabIndex = 10;
            // 
            // tB_key
            // 
            this.tB_key.Location = new System.Drawing.Point(56, 149);
            this.tB_key.Name = "tB_key";
            this.tB_key.Size = new System.Drawing.Size(110, 20);
            this.tB_key.TabIndex = 9;
            // 
            // lbl_mod
            // 
            this.lbl_mod.AutoSize = true;
            this.lbl_mod.Location = new System.Drawing.Point(11, 191);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(45, 13);
            this.lbl_mod.TabIndex = 8;
            this.lbl_mod.Text = "Модуль";
            // 
            // lblo_key
            // 
            this.lblo_key.AutoSize = true;
            this.lblo_key.Location = new System.Drawing.Point(14, 152);
            this.lblo_key.Name = "lblo_key";
            this.lblo_key.Size = new System.Drawing.Size(33, 13);
            this.lblo_key.TabIndex = 7;
            this.lblo_key.Text = "Ключ";
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(172, 142);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(92, 33);
            this.btn_encode.TabIndex = 5;
            this.btn_encode.Text = "Кодировать";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // tB_encode
            // 
            this.tB_encode.Location = new System.Drawing.Point(14, 116);
            this.tB_encode.Name = "tB_encode";
            this.tB_encode.Size = new System.Drawing.Size(250, 20);
            this.tB_encode.TabIndex = 4;
            // 
            // lbl_after_encode
            // 
            this.lbl_after_encode.AutoSize = true;
            this.lbl_after_encode.Location = new System.Drawing.Point(15, 100);
            this.lbl_after_encode.Name = "lbl_after_encode";
            this.lbl_after_encode.Size = new System.Drawing.Size(216, 13);
            this.lbl_after_encode.TabIndex = 3;
            this.lbl_after_encode.Text = "Зашифрованный/расшифрованный файл";
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(15, 47);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(87, 13);
            this.lbl_base.TabIndex = 2;
            this.lbl_base.Text = "Исходный файл";
            // 
            // tB_base
            // 
            this.tB_base.Location = new System.Drawing.Point(14, 63);
            this.tB_base.Name = "tB_base";
            this.tB_base.Size = new System.Drawing.Size(250, 20);
            this.tB_base.TabIndex = 1;
            // 
            // tP_generate
            // 
            this.tP_generate.Controls.Add(this.tB_d);
            this.tP_generate.Controls.Add(this.tB_n);
            this.tP_generate.Controls.Add(this.tB_e);
            this.tP_generate.Controls.Add(this.lbl_d);
            this.tP_generate.Controls.Add(this.lbl_n);
            this.tP_generate.Controls.Add(this.lbl_e);
            this.tP_generate.Controls.Add(this.btn_generate);
            this.tP_generate.Location = new System.Drawing.Point(4, 22);
            this.tP_generate.Name = "tP_generate";
            this.tP_generate.Padding = new System.Windows.Forms.Padding(3);
            this.tP_generate.Size = new System.Drawing.Size(270, 229);
            this.tP_generate.TabIndex = 2;
            this.tP_generate.Text = "Генерировать";
            this.tP_generate.UseVisualStyleBackColor = true;
            // 
            // tB_d
            // 
            this.tB_d.Location = new System.Drawing.Point(25, 67);
            this.tB_d.Name = "tB_d";
            this.tB_d.Size = new System.Drawing.Size(231, 20);
            this.tB_d.TabIndex = 6;
            // 
            // tB_n
            // 
            this.tB_n.Location = new System.Drawing.Point(25, 100);
            this.tB_n.Name = "tB_n";
            this.tB_n.Size = new System.Drawing.Size(231, 20);
            this.tB_n.TabIndex = 5;
            // 
            // tB_e
            // 
            this.tB_e.Location = new System.Drawing.Point(25, 38);
            this.tB_e.Name = "tB_e";
            this.tB_e.Size = new System.Drawing.Size(231, 20);
            this.tB_e.TabIndex = 2;
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(6, 70);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(13, 13);
            this.lbl_d.TabIndex = 4;
            this.lbl_d.Text = "d";
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Location = new System.Drawing.Point(6, 103);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(13, 13);
            this.lbl_n.TabIndex = 3;
            this.lbl_n.Text = "n";
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Location = new System.Drawing.Point(6, 41);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(13, 13);
            this.lbl_e.TabIndex = 1;
            this.lbl_e.Text = "e";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(6, 6);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(250, 23);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Сгенерировать ключи";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // RSA_alg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 278);
            this.Controls.Add(this.tab_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RSA_alg";
            this.Text = "RSA";
            this.tab_code.ResumeLayout(false);
            this.tbaPEncode.ResumeLayout(false);
            this.tbaPEncode.PerformLayout();
            this.tP_generate.ResumeLayout(false);
            this.tP_generate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_code;
        private System.Windows.Forms.TabPage tbaPEncode;
        private System.Windows.Forms.TextBox tB_mod;
        private System.Windows.Forms.TextBox tB_key;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Label lblo_key;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.TextBox tB_encode;
        private System.Windows.Forms.Label lbl_after_encode;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.TextBox tB_base;
        private System.Windows.Forms.TabPage tP_generate;
        private System.Windows.Forms.TextBox tB_d;
        private System.Windows.Forms.TextBox tB_n;
        private System.Windows.Forms.TextBox tB_e;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_getFile;
        private System.Windows.Forms.Button btn_decode;
    }
}

