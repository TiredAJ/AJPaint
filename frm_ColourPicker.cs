using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJPaint
{
    public partial class frm_ColourPicker : Form
    {
        private byte Red, Green = 128, Blue, Alpha = 255;
        private static Queue<Color> PrevColours = new Queue<Color>();

        public Color Colour = Color.Green;

        public frm_ColourPicker()
        {
            InitializeComponent();

            Colour = new Color();

            ColourChanged();
        }

        public void SetInitialColour(Color _Colour)
        {
            Colour = _Colour;

            Red = Colour.R;
            Green = Colour.G;
            Blue = Colour.B;
            Alpha = Colour.A;

            ColourChanged();
        }

        private void LoadPrevColours()
        {
            if (PrevColours.Count != 0)
            {
                Color[] Temp = PrevColours.ToArray();

                Array.Reverse<Color>(Temp);

                PictureBox[] TempPBX = new PictureBox[8];

                for (int i = 0; i < 8; i++)
                { TempPBX[i] = (PictureBox)pnl_PrevColours.Controls[i]; }

                for (int i = 0; i < Temp.Count(); i++)
                { TempPBX[i].BackColor = Temp[i]; }
            }
        }

        private void ColourChanged()
        {
            Colour = Color.FromArgb(Alpha, Red, Green, Blue);

            pbx_ColourChoice.BackColor = Colour;
            pbx_ColourChoice.Invalidate();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Control Temp = (Control)sender;
            NumericUpDown TempNud = new NumericUpDown();
            TrackBar TempTbr = new TrackBar();

            string[] TagSplit = Temp.Tag.ToString().Split
            (
                '-',
                StringSplitOptions.None
            );


            switch (TagSplit[0])
            {
                case "0":
                {//nud

                    switch (TagSplit[1])
                    {
                        case "R":
                        {
                            Red = (byte)((NumericUpDown)Temp).Value;
                            break;
                        }
                        case "G":
                        {
                            Green = (byte)((NumericUpDown)Temp).Value;
                            break;
                        }
                        case "B":
                        {
                            Blue = (byte)((NumericUpDown)Temp).Value;
                            break;
                        }
                        case "A":
                        {
                            Alpha = (byte)((NumericUpDown)Temp).Value;
                            break;
                        }
                    }
                    break;
                }
                case "1":
                {//tbr

                    switch (TagSplit[1])
                    {
                        case "R":
                        {
                            Red = (byte)((TrackBar)Temp).Value;
                            break;
                        }
                        case "G":
                        {
                            Green = (byte)((TrackBar)Temp).Value;
                            break;
                        }
                        case "B":
                        {
                            Blue = (byte)((TrackBar)Temp).Value;
                            break;
                        }
                        case "A":
                        {
                            Alpha = (byte)((TrackBar)Temp).Value;
                            break;
                        }
                    }
                    break;
                }
            }

            UpdateControls();

            ColourChanged();
        }

        private void frm_ColourPicker_Load(object sender, EventArgs e)
        {
            this.BringToFront();

            LoadPrevColours();

            UpdateControls();
        }

        private void btn_SelectColour_Click(object sender, EventArgs e)
        {
            PrevColours.Enqueue(Colour);

            if (PrevColours.Count > 8)
            { PrevColours.Dequeue(); }

            this.Close();
        }

        private void UpdateControls()
        {
            Task Updater = Task.Run(() =>
            {
                nud_Red.Invoke(new Action(() =>
                {
                    nud_Red.Value = Red;
                }));
                nud_Green.Invoke(new Action(() =>
                {
                    nud_Green.Value = Green;
                }));
                nud_Blue.Invoke(new Action(() =>
                {
                    nud_Blue.Value = Blue;
                }));
                nud_Alpha.Invoke(new Action(() =>
                {
                    nud_Alpha.Value = Alpha;
                }));

                tbr_Red.Invoke(new Action(() =>
                {
                    tbr_Red.Value = Red;
                }));
                tbr_Green.Invoke(new Action(() =>
                {
                    tbr_Green.Value = Green;
                }));
                tbr_Blue.Invoke(new Action(() =>
                {
                    tbr_Blue.Value = Blue;
                }));
                tbr_Red.Invoke(new Action(() =>
                {
                    tbr_Alpha.Value = Alpha;
                }));
            });
        }
    }
}
