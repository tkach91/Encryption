using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Enigma
{
    public partial class enigma_algorithm : Form
    {
        enigma_cript enigma;

        public enigma_algorithm()
        {
            InitializeComponent();
            enigma = new enigma_cript();
        }

        private void btn_code_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fdialog.FilterIndex = 1;
            fdialog.RestoreDirectory = true;
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                byte[] block, out_block = null;
                FileStream fs = new FileStream(fdialog.FileName, FileMode.Open, FileAccess.Read);
                block = new byte[(int)fs.Length];
                out_block = new byte[(int)fs.Length];
                fs.Read(block, 0, block.Length);
                fs.Close();
                enigma.crypt(block, out_block);
                MessageBox.Show("Файл зашифрован!");
                fs = new FileStream(fdialog.FileName, FileMode.Create, FileAccess.Write);
                fs.Write(out_block, 0, out_block.Length);
                fs.Close();
            }
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fdialog.FilterIndex = 1;
            fdialog.RestoreDirectory = true;
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                byte[] block, out_block = null;
                FileStream fs = new FileStream(fdialog.FileName, FileMode.Open, FileAccess.Read);
                block = new byte[(int)fs.Length];
                out_block = new byte[(int)fs.Length];
                fs.Read(block, 0, block.Length);
                fs.Close();
                enigma.crypt(block, out_block);
                MessageBox.Show("Файл расшифрован!");
                fs = new FileStream(fdialog.FileName, FileMode.Create, FileAccess.Write);
                fs.Write(out_block, 0, out_block.Length);
                fs.Close();
            }
        }
    }
}
