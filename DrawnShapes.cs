using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AJPaint
{
    public class DrawnShapes : IComparable
    {
        private Rectangle Region;

        public List<Point> Points = new List<Point>();
        public Color PrimaryColour, SecondaryColour;
        public Shapes ShapeType;
        public float LineWidth;
        public bool FilledShape;
        public bool HatchedShape;
        public HatchStyle HatchStyle;

        public DrawnShapes()
        {
            ShapeType = Shapes.Rectangle;
            LineWidth = 4f;
            FilledShape = false;
            HatchedShape = false;
            PrimaryColour = Color.Green;
            //FF008000
        }

        public DrawnShapes
        (
            Color _Primary, Color _Secondary,
            Shapes _ShapeType, float _LineWidth
        )
        {
            ShapeType = _ShapeType;
            PrimaryColour = _Primary;
            SecondaryColour = _Secondary;
            LineWidth = _LineWidth;
        }

        public int Layer { get; set; }

        public void AddPoint(Point _NewPoint)
        {
            Points.Add(_NewPoint);

            if (Points.Count == 2)
            {
                SwapPoints();

                Region = new Rectangle
                (
                    Points[0], new Size
                    (
                        Math.Abs(Points[0].X - Points[1].X),
                        Math.Abs(Points[0].Y - Points[1].Y)
                    )
                );
            }
        }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            switch ((int)ShapeType)
            {
                case 0:
                {
                    if (FilledShape)
                    {
                        g.FillRectangle
                            (
                                new SolidBrush(SecondaryColour),
                                Region
                            );
                    }

                    if (HatchedShape)
                    {
                        g.FillRectangle
                        (
                            new HatchBrush
                            (
                                HatchStyle,
                                PrimaryColour,
                                SecondaryColour
                            ),
                            Region
                        );
                    }

                    g.DrawRectangle
                        (
                            new Pen(PrimaryColour, LineWidth),
                            Region
                        );

                    break;
                }
                case 1:
                {
                    if (FilledShape)
                    {
                        g.FillEllipse
                            (
                                new SolidBrush(SecondaryColour),
                                Region
                            );
                    }

                    if (HatchedShape)
                    {
                        g.FillEllipse
                        (
                            new HatchBrush
                            (
                                HatchStyle,
                                PrimaryColour,
                                SecondaryColour
                            ),
                            Region
                        );
                    }

                    g.DrawEllipse
                        (
                            new Pen(PrimaryColour, LineWidth),
                            Region
                        );

                    break;
                }
                case 2:
                {
                    Point[] Points =
                    {
                        new Point //A
                        (
                            Region.X,
                            Region.Y + Region.Height
                        ),
                        new Point //B
                        (
                            Region.X + (Region.Width / 2),
                            Region.Y
                        ),
                        new Point //C
                        (
                            Region.X + Region.Width,
                            Region.Y + Region.Height
                        )
                    };

                    if (FilledShape)
                    {
                        g.FillPolygon
                        (
                            new SolidBrush(SecondaryColour),
                            Points
                        );
                    }

                    if (HatchedShape)
                    {
                        g.FillPolygon
                        (
                            new HatchBrush
                            (
                                HatchStyle,
                                PrimaryColour,
                                SecondaryColour
                            ),
                            Points
                        );
                    }

                    g.DrawPolygon
                    (
                        new Pen(PrimaryColour, LineWidth),
                        Points
                    );

                    break;
                }
            }
        }

        public override string ToString()
        {
            string Temp;

            Temp = "Point 0: " + Points[0] + Environment.NewLine;

            if (Points.Count > 1)
            {
                for (int i = 1; i < Points.Count; i++)
                { Temp += "Point " + i + ": " + Points[i] + Environment.NewLine; }
            }

            Temp += "Region: " + Region + Environment.NewLine;
            Temp += "PrimaryColour: " + PrimaryColour + Environment.NewLine;
            Temp += "Shapes: " + ShapeType + Environment.NewLine;
            Temp += "LineWidth: " + LineWidth + Environment.NewLine;
            Temp += Environment.NewLine;

            return Temp;
        }

        public void Clear()
        {
            Points.Clear();
            Region = new Rectangle();
            PrimaryColour = Color.Black;
            ShapeType = 0;
            LineWidth = 0;
        }

        private void SwapPoints()
        {
            Point Temp = new Point();
            Point P0 = Points[0];
            Point P1 = Points[1];

            if (P1.X < P0.X)
            {
                Temp.X = P0.X;
                P0.X = P1.X;
                P1.X = Temp.X;
            }

            if (P1.Y < P0.Y)
            {
                Temp.Y = P0.Y;
                P0.Y = P1.Y;
                P1.Y = Temp.Y;
            }

            Points[0] = P0;
            Points[1] = P1;
        }

        public int Compare(object DS1, object DS2)
        {

            return (new CaseInsensitiveComparer()).Compare
                (
                    ((DrawnShapes)DS1).Layer,
                    ((DrawnShapes)DS2).Layer
                );
        }

        public int CompareTo(object? obj)
        {
            return ((DrawnShapes)obj).Layer.CompareTo(Layer);
        }
    }

    public enum Shapes
    {
        Rectangle,
        Circle,
        Triangle
    }
}

