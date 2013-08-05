namespace Enigma
{
    partial class enigma_algorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enigma_algorithm));
            this.btn_code = new System.Windows.Forms.Button();
            this.btn_decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_code
            // 
            this.btn_code.Location = new System.Drawing.Point(12, 12);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(95, 25);
            this.btn_code.TabIndex = 0;
            this.btn_code.Text = "Зашифровать";
            this.btn_code.UseVisualStyleBackColor = true;
            this.btn_code.Click += new System.EventHandler(this.btn_code_Click);
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(113, 12);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(95, 25);
            this.btn_decode.TabIndex = 1;
            this.btn_decode.Text = "Расшифровать";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // enigma_algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 50);
            this.Controls.Add(this.btn_decode);
            this.Controls.Add(this.btn_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "enigma_algorithm";
            this.Text = "Enigma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_code;
        private System.Windows.Forms.Button btn_decode;
    }
}

