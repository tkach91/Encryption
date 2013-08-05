using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Huffman
{
    public partial class Form1 : Form
    {
        FileStream fs1, fs2;
        string fsname, fsname1;
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
            Huf ha = new Huf();
            FileStream FsIn = new FileStream(fsname, FileMode.Open);
            ha.Shrink(FsIn, fsname1);
            FsIn.Close();
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            Huf ha = new Huf();
            FileStream FsIn = new FileStream(fsname, FileMode.Open);
            ha.Extract(FsIn, fsname1);
            FsIn.Close();
        }
    }
}
