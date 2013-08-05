namespace Huffman
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
            this.tB_out = new System.Windows.Forms.TextBox();
            this.lbl_out = new System.Windows.Forms.Label();
            this.tB_in = new System.Windows.Forms.TextBox();
            this.lbl_base = new System.Windows.Forms.Label();
            this.btn_encode = new System.Windows.Forms.Button();
            this.btn_code = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_out
            // 
            this.tB_out.Location = new System.Drawing.Point(134, 77);
            this.tB_out.Name = "tB_out";
            this.tB_out.Size = new System.Drawing.Size(366, 20);
            this.tB_out.TabIndex = 14;
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Location = new System.Drawing.Point(131, 55);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(216, 13);
            this.lbl_out.TabIndex = 13;
            this.lbl_out.Text = "Зашифрованный/расшифрованный файл";
            // 
            // tB_in
            // 
            this.tB_in.Location = new System.Drawing.Point(134, 28);
            this.tB_in.Name = "tB_in";
            this.tB_in.Size = new System.Drawing.Size(366, 20);
            this.tB_in.TabIndex = 12;
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(131, 9);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(87, 13);
            this.lbl_base.TabIndex = 11;
            this.lbl_base.Text = "Исходный файл";
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(8, 74);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(96, 23);
            this.btn_encode.TabIndex = 10;
            this.btn_encode.Text = "Распаковать";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // btn_code
            // 
            this.btn_code.Location = new System.Drawing.Point(8, 42);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(96, 23);
            this.btn_code.TabIndex = 9;
            this.btn_code.Text = "Запаковать";
            this.btn_code.UseVisualStyleBackColor = true;
            this.btn_code.Click += new System.EventHandler(this.btn_code_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(8, 9);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(96, 23);
            this.btn_get.TabIndex = 8;
            this.btn_get.Text = "Обзор";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 111);
            this.Controls.Add(this.tB_out);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.tB_in);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.btn_code);
            this.Controls.Add(this.btn_get);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Хаффман";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_out;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.TextBox tB_in;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.Button btn_code;
        private System.Windows.Forms.Button btn_get;
    }
}

