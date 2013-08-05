using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class RSA_alg : Form
    {
        FileStream fs1, fs2;
        rsa_encode code;
        string fsname, fsname1;

        public RSA_alg()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            code = new rsa_encode();
            tB_e.Text = code.ex.ToString();
            tB_d.Text = code.d.ToString();
            tB_n.Text = code.n.ToString();
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            UInt64 ex = Convert.ToUInt64(tB_key.Text);
            UInt64 n = Convert.ToUInt64(tB_mod.Text);

            fs1 = new FileStream(fsname, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(fsname1, FileMode.Create, FileAccess.Write);

            for (int i = 0; i < fs1.Length; i++)
            {
                int ch = fs1.ReadByte();
                UInt64 b64 = rsa_encode.power(Convert.ToUInt64(ch), ex, n);
                for (int j = 0; j < 8; j++)
                {
                    byte b = Convert.ToByte((b64 >> j * 8) & 0xFF);
                    fs2.WriteByte(b);
                }
            }

            fs1.Close();
            fs2.Close();
            MessageBox.Show("Кодирование завершено!");
        }

        private void btn_getFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "All files (*.*)|*.*";
            fdialog.FilterIndex = 1;
            fdialog.RestoreDirectory = true;
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                tB_base.Text = fdialog.FileName;
                fsname = fdialog.FileName;

                string[] stmp = fsname.Split('.');
                if (stmp[0].Substring(stmp[0].Length-3, 3) == "mod")
                    stmp[0] = stmp[0].Substring(0, stmp[0].Length - 3) + "dec";
                else
                    stmp[0] += "mod";
                fsname1 = stmp[0] + "." + stmp[1];

                tB_encode.Text = fsname1; 
            }
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            UInt64 ex = Convert.ToUInt64(tB_key.Text);
            UInt64 n = Convert.ToUInt64(tB_mod.Text);

            fs1 = new FileStream(fsname, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(fsname1, FileMode.Create, FileAccess.Write);

            for (int i = 0; i < fs1.Length/8; i++)
            {
                UInt64 bx = Convert.ToUInt64(fs1.ReadByte());
                for (int j = 1; j < 8; j++)
                {
                    UInt64 t = Convert.ToUInt64(fs1.ReadByte());
                    bx += (t << j * 8);
                }
                UInt64 b64 = rsa_encode.power(Convert.ToUInt64(bx), ex, n);
                byte b = Convert.ToByte(b64 & 0xFF);
                fs2.WriteByte(b);
            }
            fs1.Close();
            fs2.Close();
            MessageBox.Show("Кодирование завершено!");
        }
    }
}
