using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJPaint
{
    public partial class frm_FileLoc : Form
    {
        public string FileLoc { get; set; }
        public int ChosenFormat { get; set; }

        public frm_FileLoc()
        { InitializeComponent(); }

        private void frm_FileLoc_Load(object sender, EventArgs e)
        { cmbx_FileExtensions.SelectedIndex = 0; }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            switch (cmbx_FileExtensions.SelectedItem.ToString())
            {
                case ".png":
                {
                    ChosenFormat = 0;
                    break;
                }
                case ".bmp":
                {
                    ChosenFormat = 1;
                    break;
                }
                case ".jpg":
                {
                    ChosenFormat = 2;
                    break;
                }
                case ".gif":
                {
                    ChosenFormat = 3;
                    break;
                }
                case ".ico":
                {
                    ChosenFormat = 4;
                    break;
                }
            }

            FileLoc = txt_FolderPath.Text + "\\" + txt_FileName.Text;
            FileLoc += cmbx_FileExtensions.SelectedItem.ToString();
            this.Dispose();
        }

        private void btn_FindFolderLoc_Click(object sender, EventArgs e)
        {
            fbd_ChosenFolder.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();

            fbd_ChosenFolder.ShowDialog();

            txt_FolderPath.Text = fbd_ChosenFolder.SelectedPath;
        }

        private void txt_FolderPath_TextChanged(object sender, EventArgs e)
        {btn_Submit.Enabled = true;}
    }
}
