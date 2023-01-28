using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.CodeDom.Compiler;
using System.Drawing.Imaging;

namespace AJPaint
{
    public partial class frm_Canvas : Form
    {
        private frm_ColourPicker ColourPicker = new frm_ColourPicker();
        private List<DrawnShapes> Shapes = new List<DrawnShapes>();
        private Stack<DrawnShapes> UndoneShapes = new Stack<DrawnShapes>();
        private DrawnShapes CurrentShape = new DrawnShapes();
        private Color Primary = Color.Green, Secondary = Color.Gray;
        private AJPaint.Shapes CurrentShapeType = AJPaint.Shapes.Rectangle;
        private int TopmostLayer = 0;
        private int BottommostLayer = -1;
        private bool BottomLayer = false;
        private bool StopAsync = false;
        private bool FilledShape = false;
        private bool HatchedShape = false;

        public frm_Canvas()
        { InitializeComponent(); }

        private void Drawer()
        {
            while (!StopAsync)
            {
                Task Refresher = Task.Run(() =>
                {
                    pbx_Canvas.Invoke(new Action(() =>
                    {
                        pbx_Canvas.Invalidate();
                    }));
                });
                Thread.Sleep(100);
            }
        }

        private void frm_Canvas_Load(object sender, EventArgs e)
        {
            Thread DrawerThread = new Thread(Drawer);
            DrawerThread.Start();


            pbx_Canvas.BackColor = Color.Beige;

            CurrentShape.ShapeType = AJPaint.Shapes.Rectangle;
            CurrentShape.PrimaryColour = Color.Green;
            CurrentShape.SecondaryColour = Color.Gray;
        }

        private void pbx_Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawnShapes[] Temp = new DrawnShapes[Shapes.Count];

            Shapes.CopyTo(Temp, 0);

            if (Temp != null)
            {
                Array.Sort(Temp);

                for (int i = Temp.Count() - 1; i >= 0; i--)
                {
                    Temp[i].Draw(e.Graphics);
                }
            }

            Thread.Sleep(100);
        }

        private void pbx_Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentShape.AddPoint(e.Location);
        }

        private void pbx_Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            CurrentShape.AddPoint(e.Location);
            CurrentShape.LineWidth = 4;
            CurrentShape.PrimaryColour = Primary;
            CurrentShape.SecondaryColour = Secondary;
            CurrentShape.ShapeType = CurrentShapeType;
            CurrentShape.FilledShape = FilledShape;
            CurrentShape.HatchedShape = HatchedShape;

            if (BottomLayer)
            {
                CurrentShape.Layer = BottommostLayer;
                BottommostLayer--;
                Shapes.Add(CurrentShape);
            }
            else
            {
                CurrentShape.Layer = TopmostLayer;
                TopmostLayer++;

                Shapes.Add(CurrentShape);
            }

            CurrentShape = new DrawnShapes();
        }

        private void btn_ClearCanvas_Click(object sender, EventArgs e)
        {
            Shapes.Clear();
            pbx_Canvas.Invalidate();
        }

        private void rbtn_Square_CheckedChanged(object sender, EventArgs e)
        { CurrentShapeType = AJPaint.Shapes.Rectangle; }

        private void rbtn_Triangle_CheckedChanged(object sender, EventArgs e)
        { CurrentShapeType = AJPaint.Shapes.Triangle; }

        private void rbtn_Circle_CheckedChanged(object sender, EventArgs e)
        { CurrentShapeType = AJPaint.Shapes.Circle; }

        private void rbtn_HollowStyle_CheckedChanged(object sender, EventArgs e)
        {
            FilledShape = !(rbtn_HollowStyle.Checked);
            HatchedShape = !(rbtn_HollowStyle.Checked);
        }

        private void rbtn_FilledStyle_CheckedChanged(object sender, EventArgs e)
        {
            FilledShape = rbtn_FilledStyle.Checked;
            HatchedShape = !(rbtn_FilledStyle.Checked);
        }

        private void rbtn_HatchStyle_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_HatchStyles.Enabled = rbtn_HatchStyle.Checked;
            HatchedShape = rbtn_HatchStyle.Checked;
            FilledShape = !(rbtn_HatchStyle.Checked);
        }

        private void btn_PrimaryColour_Click(object sender, EventArgs e)
        {
            ColourPicker.SetInitialColour(Primary);

            ColourPicker.ShowDialog();

            pbx_OutlineColour.BackColor = ColourPicker.Colour;
            Primary = ColourPicker.Colour;
        }

        private void btn_SecondaryColour_Click(object sender, EventArgs e)
        {
            ColourPicker.SetInitialColour(Secondary);

            ColourPicker.ShowDialog();

            pbx_SecondaryColour.BackColor = ColourPicker.Colour;
            Secondary = ColourPicker.Colour;
        }

        private void btn_CanvasColour_Click(object sender, EventArgs e)
        {
            ColourPicker.SetInitialColour(pbx_Canvas.BackColor);

            ColourPicker.ShowDialog();

            pbx_Canvas.BackColor = ColourPicker.Colour;
            pbx_CanvasColour.BackColor = ColourPicker.Colour;
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (Shapes.Count > 0)
            {
                UndoneShapes.Push(Shapes.Last());
                Shapes.Remove(Shapes.Last());
                pbx_Canvas.Invalidate();
            }
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (UndoneShapes.Count > 0)
            {
                Shapes.Add(UndoneShapes.Pop());
                pbx_Canvas.Invalidate();
            }
        }

        private void frm_Canvas_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAsync = true;

            Thread.Sleep(200);
        }

        private void ckbx_AddToBottom_CheckedChanged(object sender, EventArgs e)
        { BottomLayer = ckbx_AddToBottom.Checked; }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            frm_FileLoc GetFileLocForm = new frm_FileLoc();

            GetFileLocForm.ShowDialog();

            string FileLoc = GetFileLocForm.FileLoc;
            int FileType = GetFileLocForm.ChosenFormat;
            Bitmap Temp;


            if (FileLoc != "")
            {
                Temp = new Bitmap(pbx_Canvas.Width, pbx_Canvas.Height);

                Graphics G = Graphics.FromImage(Temp);

                DrawnShapes[] TempArr = new DrawnShapes[Shapes.Count];

                G.FillRectangle
                    (
                        new SolidBrush(pbx_Canvas.BackColor),
                        new Rectangle
                        (
                            new Point(0, 0),
                            Temp.Size
                        )
                    );

                Shapes.CopyTo(TempArr, 0);

                if (TempArr != null)
                {
                    Array.Sort(TempArr);

                    for (int i = TempArr.Count() - 1; i >= 0; i--)
                    { TempArr[i].Draw(G); }
                }

                Debug.WriteLine(FileLoc);

                switch (FileType)
                {
                    case 0:
                    {
                        Temp.Save(FileLoc, ImageFormat.Png);
                        break;
                    }
                    case 1:
                    {
                        Temp.Save(FileLoc, ImageFormat.Bmp);
                        break;
                    }
                    case 2:
                    {
                        Temp.Save(FileLoc, ImageFormat.Jpeg);
                        break;
                    }
                    case 3:
                    {
                        Temp.Save(FileLoc, ImageFormat.Gif);
                        break;
                    }
                    case 4:
                    {
                        Temp.Save(FileLoc, ImageFormat.Icon);
                        break;
                    }
                    default:
                    {
                        throw new FileFormatException("There was an error saving the file");
                        break;
                    }
                }

            }
        }

        private void cmbx_HatchStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)cmbx_HatchStyles.SelectedItem)
            {
                case "Diagonal":
                {
                    CurrentShape.HatchStyle = HatchStyle.BackwardDiagonal;
                    break;
                }
                case "Horizontal":
                {
                    CurrentShape.HatchStyle = HatchStyle.Horizontal;
                    break;
                }
                case "Vertical":
                {
                    CurrentShape.HatchStyle = HatchStyle.Vertical;
                    break;
                }
                case "Cross":
                {
                    CurrentShape.HatchStyle = HatchStyle.Cross;
                    break;
                }
                case "Dashed Diagonal":
                {
                    CurrentShape.HatchStyle = HatchStyle.DashedDownwardDiagonal;
                    break;
                }
                case "Dashed Horizontal":
                {
                    CurrentShape.HatchStyle = HatchStyle.DashedHorizontal;
                    break;
                }
                case "Diagonal Brick":
                {
                    CurrentShape.HatchStyle = HatchStyle.DiagonalBrick;
                    break;
                }
                case "Diagonal Cross":
                {
                    CurrentShape.HatchStyle = HatchStyle.DiagonalCross;
                    break;
                }
                case "Divot":
                {
                    CurrentShape.HatchStyle = HatchStyle.Divot;
                    break;
                }
                case "Dotted Diamond":
                {
                    CurrentShape.HatchStyle = HatchStyle.DottedDiamond;
                    break;
                }
                case "Dotted grid":
                {
                    CurrentShape.HatchStyle = HatchStyle.DottedGrid;
                    break;
                }
                case "Checkerboard":
                {
                    CurrentShape.HatchStyle = HatchStyle.LargeCheckerBoard;
                    break;
                }
                case "Confetti":
                {
                    CurrentShape.HatchStyle = HatchStyle.LargeConfetti;
                    break;
                }
                case "Outlined Diamond":
                {
                    CurrentShape.HatchStyle = HatchStyle.OutlinedDiamond;
                    break;
                }
                case "Plaid":
                {
                    CurrentShape.HatchStyle = HatchStyle.Plaid;
                    break;
                }
                case "Shingle":
                {
                    CurrentShape.HatchStyle = HatchStyle.Shingle;
                    break;
                }
                case "Sphere":
                {
                    CurrentShape.HatchStyle = HatchStyle.Sphere;
                    break;
                }
                case "Wave":
                {
                    CurrentShape.HatchStyle = HatchStyle.Wave;
                    break;
                }
                case "Weave":
                {
                    CurrentShape.HatchStyle = HatchStyle.Weave;
                    break;
                }
                case "Zigzag":
                {
                    CurrentShape.HatchStyle = HatchStyle.ZigZag;
                    break;
                }
            }
        }
    }
}