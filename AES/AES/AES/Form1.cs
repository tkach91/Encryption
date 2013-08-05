using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AES
{
    public partial class Form1 : Form
    {
        FileStream fs1, fs2;
        string fsname, fsname1;
        byte[] keyBytes = new byte[] {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,0x08, 0x09, 
                                      0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 
                                      0x14, 0x15, 0x18, 0x17};

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "All files (*.*)|*.*";
            fdialog.FilterIndex = 1;
            fdialog.RestoreDirectory = true;
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                tB_in.Text = fdialog.FileName;
                fsname = fdialog.FileName;

                string[] stmp = fsname.Split('.');
                if (stmp[0].Substring(stmp[0].Length - 3, 3) == "mod")
                    stmp[0] = stmp[0].Substring(0, stmp[0].Length - 3) + "dec";
                else
                    stmp[0] += "mod";
                fsname1 = stmp[0] + "." + stmp[1];

                tB_out.Text = fsname1;
            }
        }

        private void btn_code_Click(object sender, EventArgs e)
        {
            AESCL a;
            if (rB_192b.Checked)
                a = new AESCL(AESCL.KeySize.Bits192, keyBytes);
            else if (rB_256b.Checked)
                a = new AESCL(AESCL.KeySize.Bits256, keyBytes);
            else 
                a = new AESCL(AESCL.KeySize.Bits128, keyBytes);

            fs1 = new FileStream(fsname, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(fsname1, FileMode.Create, FileAccess.Write);

            int res = 1;
            byte[] inp = new byte[16];
            byte[] outp = new byte[16];

            while (res != 0)
            {
                res = fs1.Read(inp, 0, 16);
                a.Cipher(inp, outp);
            }

            fs2.Write(outp, 0, 16);
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            AESCL a;
            if (rB_192b.Checked)
                a = new AESCL(AESCL.KeySize.Bits192, keyBytes);
            else if (rB_256b.Checked)
                a = new AESCL(AESCL.KeySize.Bits256, keyBytes);
            else
                a = new AESCL(AESCL.KeySize.Bits128, keyBytes);

            fs1 = new FileStream(fsname, FileMode.Append, FileAccess.Read);
            fs2 = new FileStream(fsname1, FileMode.Create, FileAccess.Write);

            int res = 1;
            byte[] inp = new byte[16];
            byte[] outp = new byte[16];

            while (res != 0)
            {
                res = fs1.Read(inp, 0, 16);
                a.Cipher(inp, outp);
            }

            fs2.Write(outp, 0, 16);
        }
    }
}
