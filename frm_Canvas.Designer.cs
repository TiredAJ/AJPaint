namespace AJPaint
{
    partial class frm_Canvas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Export = new Button();
            btn_ClearCanvas = new Button();
            btn_Redo = new Button();
            btn_Undo = new Button();
            ckbx_AddToBottom = new CheckBox();
            gbx_ColourSelector = new GroupBox();
            pbx_CanvasColour = new PictureBox();
            pbx_SecondaryColour = new PictureBox();
            pbx_OutlineColour = new PictureBox();
            btn_CanvasColour = new Button();
            btn_SecondaryColour = new Button();
            btn_PrimaryColour = new Button();
            gbx_StyleSelector = new GroupBox();
            cmbx_HatchStyles = new ComboBox();
            rbtn_HatchStyle = new RadioButton();
            rbtn_FilledStyle = new RadioButton();
            rbtn_HollowStyle = new RadioButton();
            gbx_ShapeSelector = new GroupBox();
            rbtn_Triangle = new RadioButton();
            rbtn_Circle = new RadioButton();
            rbtn_Square = new RadioButton();
            pbx_Canvas = new PictureBox();
            gbx_ColourSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_CanvasColour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_SecondaryColour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_OutlineColour).BeginInit();
            gbx_StyleSelector.SuspendLayout();
            gbx_ShapeSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Canvas).BeginInit();
            SuspendLayout();
            // 
            // btn_Export
            // 
            btn_Export.Location = new Point(1078, 596);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(144, 53);
            btn_Export.TabIndex = 17;
            btn_Export.Text = "Export Picture";
            btn_Export.UseVisualStyleBackColor = true;
            btn_Export.Click += btn_Export_Click;
            // 
            // btn_ClearCanvas
            // 
            btn_ClearCanvas.Location = new Point(915, 595);
            btn_ClearCanvas.Name = "btn_ClearCanvas";
            btn_ClearCanvas.Size = new Size(100, 53);
            btn_ClearCanvas.TabIndex = 16;
            btn_ClearCanvas.Text = "Clear Screen";
            btn_ClearCanvas.UseVisualStyleBackColor = true;
            btn_ClearCanvas.Click += btn_ClearCanvas_Click;
            // 
            // btn_Redo
            // 
            btn_Redo.Location = new Point(1078, 411);
            btn_Redo.Name = "btn_Redo";
            btn_Redo.Size = new Size(144, 73);
            btn_Redo.TabIndex = 15;
            btn_Redo.Text = "Redo";
            btn_Redo.UseVisualStyleBackColor = true;
            btn_Redo.Click += btn_Redo_Click;
            // 
            // btn_Undo
            // 
            btn_Undo.Location = new Point(915, 411);
            btn_Undo.Name = "btn_Undo";
            btn_Undo.Size = new Size(144, 73);
            btn_Undo.TabIndex = 14;
            btn_Undo.Text = "Undo";
            btn_Undo.UseVisualStyleBackColor = true;
            btn_Undo.Click += btn_Undo_Click;
            // 
            // ckbx_AddToBottom
            // 
            ckbx_AddToBottom.AutoSize = true;
            ckbx_AddToBottom.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbx_AddToBottom.Location = new Point(915, 12);
            ckbx_AddToBottom.Name = "ckbx_AddToBottom";
            ckbx_AddToBottom.Size = new Size(152, 34);
            ckbx_AddToBottom.TabIndex = 13;
            ckbx_AddToBottom.Text = "Add Beneath";
            ckbx_AddToBottom.UseVisualStyleBackColor = true;
            ckbx_AddToBottom.CheckedChanged += ckbx_AddToBottom_CheckedChanged;
            // 
            // gbx_ColourSelector
            // 
            gbx_ColourSelector.Controls.Add(pbx_CanvasColour);
            gbx_ColourSelector.Controls.Add(pbx_SecondaryColour);
            gbx_ColourSelector.Controls.Add(pbx_OutlineColour);
            gbx_ColourSelector.Controls.Add(btn_CanvasColour);
            gbx_ColourSelector.Controls.Add(btn_SecondaryColour);
            gbx_ColourSelector.Controls.Add(btn_PrimaryColour);
            gbx_ColourSelector.FlatStyle = FlatStyle.Popup;
            gbx_ColourSelector.Location = new Point(915, 268);
            gbx_ColourSelector.Name = "gbx_ColourSelector";
            gbx_ColourSelector.Size = new Size(307, 113);
            gbx_ColourSelector.TabIndex = 12;
            gbx_ColourSelector.TabStop = false;
            gbx_ColourSelector.Text = "Colours";
            // 
            // pbx_CanvasColour
            // 
            pbx_CanvasColour.BackColor = Color.Beige;
            pbx_CanvasColour.Location = new Point(206, 65);
            pbx_CanvasColour.Name = "pbx_CanvasColour";
            pbx_CanvasColour.Size = new Size(94, 35);
            pbx_CanvasColour.TabIndex = 5;
            pbx_CanvasColour.TabStop = false;
            // 
            // pbx_SecondaryColour
            // 
            pbx_SecondaryColour.BackColor = Color.Gray;
            pbx_SecondaryColour.Location = new Point(106, 65);
            pbx_SecondaryColour.Name = "pbx_SecondaryColour";
            pbx_SecondaryColour.Size = new Size(94, 35);
            pbx_SecondaryColour.TabIndex = 4;
            pbx_SecondaryColour.TabStop = false;
            // 
            // pbx_OutlineColour
            // 
            pbx_OutlineColour.BackColor = Color.Green;
            pbx_OutlineColour.Location = new Point(6, 65);
            pbx_OutlineColour.Name = "pbx_OutlineColour";
            pbx_OutlineColour.Size = new Size(94, 35);
            pbx_OutlineColour.TabIndex = 3;
            pbx_OutlineColour.TabStop = false;
            // 
            // btn_CanvasColour
            // 
            btn_CanvasColour.Location = new Point(206, 24);
            btn_CanvasColour.Name = "btn_CanvasColour";
            btn_CanvasColour.Size = new Size(94, 35);
            btn_CanvasColour.TabIndex = 2;
            btn_CanvasColour.Text = "Canvas";
            btn_CanvasColour.UseVisualStyleBackColor = true;
            btn_CanvasColour.Click += btn_CanvasColour_Click;
            // 
            // btn_SecondaryColour
            // 
            btn_SecondaryColour.Location = new Point(106, 24);
            btn_SecondaryColour.Name = "btn_SecondaryColour";
            btn_SecondaryColour.Size = new Size(94, 35);
            btn_SecondaryColour.TabIndex = 1;
            btn_SecondaryColour.Text = "Secondary";
            btn_SecondaryColour.UseVisualStyleBackColor = true;
            btn_SecondaryColour.Click += btn_SecondaryColour_Click;
            // 
            // btn_PrimaryColour
            // 
            btn_PrimaryColour.Location = new Point(6, 24);
            btn_PrimaryColour.Name = "btn_PrimaryColour";
            btn_PrimaryColour.Size = new Size(94, 35);
            btn_PrimaryColour.TabIndex = 0;
            btn_PrimaryColour.Text = "Primary";
            btn_PrimaryColour.UseVisualStyleBackColor = true;
            btn_PrimaryColour.Click += btn_PrimaryColour_Click;
            // 
            // gbx_StyleSelector
            // 
            gbx_StyleSelector.Controls.Add(cmbx_HatchStyles);
            gbx_StyleSelector.Controls.Add(rbtn_HatchStyle);
            gbx_StyleSelector.Controls.Add(rbtn_FilledStyle);
            gbx_StyleSelector.Controls.Add(rbtn_HollowStyle);
            gbx_StyleSelector.FlatStyle = FlatStyle.Popup;
            gbx_StyleSelector.Location = new Point(915, 181);
            gbx_StyleSelector.Name = "gbx_StyleSelector";
            gbx_StyleSelector.Size = new Size(307, 81);
            gbx_StyleSelector.TabIndex = 11;
            gbx_StyleSelector.TabStop = false;
            gbx_StyleSelector.Text = "Style";
            // 
            // cmbx_HatchStyles
            // 
            cmbx_HatchStyles.Enabled = false;
            cmbx_HatchStyles.FormattingEnabled = true;
            cmbx_HatchStyles.Items.AddRange(new object[] { "Diagonal", "Horizontal", "Vertical", "Cross", "Dashed Diagonal", "Dashed Horizontal", "Diagonal Brick", "Horizontal Brick", "Diagonal Cross", "Divot", "Dotted Diamond", "Dotted Grid", "Checkerboard", "Confetti", "Outlined Diamond", "Plaid", "Shingle", "Sphere", "Wave", "Weave", "Zigzag" });
            cmbx_HatchStyles.Location = new Point(177, 20);
            cmbx_HatchStyles.Name = "cmbx_HatchStyles";
            cmbx_HatchStyles.Size = new Size(121, 25);
            cmbx_HatchStyles.TabIndex = 6;
            cmbx_HatchStyles.SelectedIndexChanged += cmbx_HatchStyles_SelectedIndexChanged;
            // 
            // rbtn_HatchStyle
            // 
            rbtn_HatchStyle.AutoSize = true;
            rbtn_HatchStyle.Location = new Point(112, 24);
            rbtn_HatchStyle.Name = "rbtn_HatchStyle";
            rbtn_HatchStyle.Size = new Size(59, 21);
            rbtn_HatchStyle.TabIndex = 5;
            rbtn_HatchStyle.Text = "Hatch";
            rbtn_HatchStyle.UseVisualStyleBackColor = true;
            rbtn_HatchStyle.CheckedChanged += rbtn_HatchStyle_CheckedChanged;
            // 
            // rbtn_FilledStyle
            // 
            rbtn_FilledStyle.AutoSize = true;
            rbtn_FilledStyle.Location = new Point(6, 51);
            rbtn_FilledStyle.Name = "rbtn_FilledStyle";
            rbtn_FilledStyle.Size = new Size(56, 21);
            rbtn_FilledStyle.TabIndex = 4;
            rbtn_FilledStyle.Text = "Filled";
            rbtn_FilledStyle.UseVisualStyleBackColor = true;
            rbtn_FilledStyle.CheckedChanged += rbtn_FilledStyle_CheckedChanged;
            // 
            // rbtn_HollowStyle
            // 
            rbtn_HollowStyle.AutoSize = true;
            rbtn_HollowStyle.Checked = true;
            rbtn_HollowStyle.Location = new Point(6, 24);
            rbtn_HollowStyle.Name = "rbtn_HollowStyle";
            rbtn_HollowStyle.Size = new Size(66, 21);
            rbtn_HollowStyle.TabIndex = 3;
            rbtn_HollowStyle.TabStop = true;
            rbtn_HollowStyle.Text = "Hollow";
            rbtn_HollowStyle.UseVisualStyleBackColor = true;
            rbtn_HollowStyle.CheckedChanged += rbtn_HollowStyle_CheckedChanged;
            // 
            // gbx_ShapeSelector
            // 
            gbx_ShapeSelector.Controls.Add(rbtn_Triangle);
            gbx_ShapeSelector.Controls.Add(rbtn_Circle);
            gbx_ShapeSelector.Controls.Add(rbtn_Square);
            gbx_ShapeSelector.FlatStyle = FlatStyle.Popup;
            gbx_ShapeSelector.Location = new Point(915, 94);
            gbx_ShapeSelector.Name = "gbx_ShapeSelector";
            gbx_ShapeSelector.Size = new Size(307, 81);
            gbx_ShapeSelector.TabIndex = 10;
            gbx_ShapeSelector.TabStop = false;
            gbx_ShapeSelector.Text = "Shapes";
            // 
            // rbtn_Triangle
            // 
            rbtn_Triangle.AutoSize = true;
            rbtn_Triangle.Location = new Point(112, 24);
            rbtn_Triangle.Name = "rbtn_Triangle";
            rbtn_Triangle.Size = new Size(72, 21);
            rbtn_Triangle.TabIndex = 2;
            rbtn_Triangle.Text = "Triangle";
            rbtn_Triangle.UseVisualStyleBackColor = true;
            rbtn_Triangle.CheckedChanged += rbtn_Triangle_CheckedChanged;
            // 
            // rbtn_Circle
            // 
            rbtn_Circle.AutoSize = true;
            rbtn_Circle.Location = new Point(6, 51);
            rbtn_Circle.Name = "rbtn_Circle";
            rbtn_Circle.Size = new Size(58, 21);
            rbtn_Circle.TabIndex = 1;
            rbtn_Circle.Text = "Circle";
            rbtn_Circle.UseVisualStyleBackColor = true;
            rbtn_Circle.CheckedChanged += rbtn_Circle_CheckedChanged;
            // 
            // rbtn_Square
            // 
            rbtn_Square.AutoSize = true;
            rbtn_Square.Checked = true;
            rbtn_Square.Location = new Point(6, 24);
            rbtn_Square.Name = "rbtn_Square";
            rbtn_Square.Size = new Size(67, 21);
            rbtn_Square.TabIndex = 0;
            rbtn_Square.TabStop = true;
            rbtn_Square.Text = "Square";
            rbtn_Square.UseVisualStyleBackColor = true;
            rbtn_Square.CheckedChanged += rbtn_Square_CheckedChanged;
            // 
            // pbx_Canvas
            // 
            pbx_Canvas.BackColor = Color.Beige;
            pbx_Canvas.BorderStyle = BorderStyle.FixedSingle;
            pbx_Canvas.Location = new Point(12, 12);
            pbx_Canvas.Name = "pbx_Canvas";
            pbx_Canvas.Size = new Size(897, 637);
            pbx_Canvas.TabIndex = 9;
            pbx_Canvas.TabStop = false;
            pbx_Canvas.Paint += pbx_Canvas_Paint;
            pbx_Canvas.MouseDown += pbx_Canvas_MouseDown;
            pbx_Canvas.MouseUp += pbx_Canvas_MouseUp;
            // 
            // frm_Canvas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 655);
            Controls.Add(btn_Export);
            Controls.Add(btn_ClearCanvas);
            Controls.Add(btn_Redo);
            Controls.Add(btn_Undo);
            Controls.Add(ckbx_AddToBottom);
            Controls.Add(gbx_ColourSelector);
            Controls.Add(gbx_StyleSelector);
            Controls.Add(gbx_ShapeSelector);
            Controls.Add(pbx_Canvas);
            MaximizeBox = false;
            Name = "frm_Canvas";
            Text = "Form1";
            FormClosing += frm_Canvas_FormClosing;
            Load += frm_Canvas_Load;
            gbx_ColourSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_CanvasColour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_SecondaryColour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_OutlineColour).EndInit();
            gbx_StyleSelector.ResumeLayout(false);
            gbx_StyleSelector.PerformLayout();
            gbx_ShapeSelector.ResumeLayout(false);
            gbx_ShapeSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Export;
        private Button btn_ClearCanvas;
        private Button btn_Redo;
        private Button btn_Undo;
        private CheckBox ckbx_AddToBottom;
        private GroupBox gbx_ColourSelector;
        private PictureBox pbx_CanvasColour;
        private PictureBox pbx_SecondaryColour;
        private PictureBox pbx_OutlineColour;
        private Button btn_CanvasColour;
        private Button btn_SecondaryColour;
        private Button btn_PrimaryColour;
        private GroupBox gbx_StyleSelector;
        private ComboBox cmbx_HatchStyles;
        private RadioButton rbtn_HatchStyle;
        private RadioButton rbtn_FilledStyle;
        private RadioButton rbtn_HollowStyle;
        private GroupBox gbx_ShapeSelector;
        private RadioButton rbtn_Triangle;
        private RadioButton rbtn_Circle;
        private RadioButton rbtn_Square;
        private PictureBox pbx_Canvas;
    }
}