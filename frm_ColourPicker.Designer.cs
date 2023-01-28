namespace AJPaint
{
    partial class frm_ColourPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbx_ColourChoice = new PictureBox();
            tbr_Alpha = new TrackBar();
            label1 = new Label();
            nud_Alpha = new NumericUpDown();
            nud_Red = new NumericUpDown();
            label2 = new Label();
            tbr_Red = new TrackBar();
            nud_Green = new NumericUpDown();
            label3 = new Label();
            tbr_Green = new TrackBar();
            nud_Blue = new NumericUpDown();
            label4 = new Label();
            tbr_Blue = new TrackBar();
            btn_SelectColour = new Button();
            pbx_Col1 = new PictureBox();
            pbx_Col2 = new PictureBox();
            pbx_Col3 = new PictureBox();
            pbx_Col4 = new PictureBox();
            pbx_Col5 = new PictureBox();
            pbx_Col6 = new PictureBox();
            pbx_Col7 = new PictureBox();
            pbx_Col8 = new PictureBox();
            pnl_PrevColours = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbx_ColourChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Alpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Alpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col8).BeginInit();
            pnl_PrevColours.SuspendLayout();
            SuspendLayout();
            // 
            // pbx_ColourChoice
            // 
            pbx_ColourChoice.BorderStyle = BorderStyle.FixedSingle;
            pbx_ColourChoice.Location = new Point(12, 12);
            pbx_ColourChoice.Name = "pbx_ColourChoice";
            pbx_ColourChoice.Size = new Size(300, 241);
            pbx_ColourChoice.TabIndex = 0;
            pbx_ColourChoice.TabStop = false;
            // 
            // tbr_Alpha
            // 
            tbr_Alpha.Location = new Point(483, 34);
            tbr_Alpha.Maximum = 255;
            tbr_Alpha.Name = "tbr_Alpha";
            tbr_Alpha.Orientation = Orientation.Vertical;
            tbr_Alpha.Size = new Size(45, 186);
            tbr_Alpha.TabIndex = 1;
            tbr_Alpha.Tag = "1-A";
            tbr_Alpha.TickFrequency = 0;
            tbr_Alpha.Value = 255;
            tbr_Alpha.ValueChanged += ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 14);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 4;
            label1.Text = "Alpha";
            // 
            // nud_Alpha
            // 
            nud_Alpha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Alpha.Location = new Point(480, 226);
            nud_Alpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nud_Alpha.Name = "nud_Alpha";
            nud_Alpha.Size = new Size(48, 27);
            nud_Alpha.TabIndex = 7;
            nud_Alpha.Tag = "0-A";
            nud_Alpha.TextAlign = HorizontalAlignment.Right;
            nud_Alpha.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nud_Alpha.ValueChanged += ValueChanged;
            // 
            // nud_Red
            // 
            nud_Red.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Red.Location = new Point(318, 226);
            nud_Red.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nud_Red.Name = "nud_Red";
            nud_Red.Size = new Size(48, 27);
            nud_Red.TabIndex = 10;
            nud_Red.Tag = "0-R";
            nud_Red.TextAlign = HorizontalAlignment.Right;
            nud_Red.ValueChanged += ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 14);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 9;
            label2.Text = "Red";
            // 
            // tbr_Red
            // 
            tbr_Red.Location = new Point(321, 34);
            tbr_Red.Maximum = 255;
            tbr_Red.Name = "tbr_Red";
            tbr_Red.Orientation = Orientation.Vertical;
            tbr_Red.Size = new Size(45, 186);
            tbr_Red.TabIndex = 8;
            tbr_Red.Tag = "1-R";
            tbr_Red.TickFrequency = 0;
            tbr_Red.ValueChanged += ValueChanged;
            // 
            // nud_Green
            // 
            nud_Green.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Green.Location = new Point(372, 226);
            nud_Green.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nud_Green.Name = "nud_Green";
            nud_Green.Size = new Size(48, 27);
            nud_Green.TabIndex = 13;
            nud_Green.Tag = "0-G";
            nud_Green.TextAlign = HorizontalAlignment.Right;
            nud_Green.Value = new decimal(new int[] { 128, 0, 0, 0 });
            nud_Green.ValueChanged += ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 14);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 12;
            label3.Text = "Green";
            // 
            // tbr_Green
            // 
            tbr_Green.Location = new Point(375, 34);
            tbr_Green.Maximum = 255;
            tbr_Green.Name = "tbr_Green";
            tbr_Green.Orientation = Orientation.Vertical;
            tbr_Green.Size = new Size(45, 186);
            tbr_Green.TabIndex = 11;
            tbr_Green.Tag = "1-G";
            tbr_Green.TickFrequency = 0;
            tbr_Green.Value = 128;
            tbr_Green.ValueChanged += ValueChanged;
            // 
            // nud_Blue
            // 
            nud_Blue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Blue.Location = new Point(426, 226);
            nud_Blue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nud_Blue.Name = "nud_Blue";
            nud_Blue.Size = new Size(48, 27);
            nud_Blue.TabIndex = 16;
            nud_Blue.Tag = "0-B";
            nud_Blue.TextAlign = HorizontalAlignment.Right;
            nud_Blue.ValueChanged += ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 14);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 15;
            label4.Text = "Blue";
            // 
            // tbr_Blue
            // 
            tbr_Blue.Location = new Point(429, 34);
            tbr_Blue.Maximum = 255;
            tbr_Blue.Name = "tbr_Blue";
            tbr_Blue.Orientation = Orientation.Vertical;
            tbr_Blue.Size = new Size(45, 186);
            tbr_Blue.TabIndex = 14;
            tbr_Blue.Tag = "1-B";
            tbr_Blue.TickFrequency = 0;
            tbr_Blue.ValueChanged += ValueChanged;
            // 
            // btn_SelectColour
            // 
            btn_SelectColour.Location = new Point(318, 259);
            btn_SelectColour.Name = "btn_SelectColour";
            btn_SelectColour.Size = new Size(210, 32);
            btn_SelectColour.TabIndex = 17;
            btn_SelectColour.Text = "Select Colour";
            btn_SelectColour.UseVisualStyleBackColor = true;
            btn_SelectColour.Click += btn_SelectColour_Click;
            // 
            // pbx_Col1
            // 
            pbx_Col1.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col1.Location = new Point(3, 3);
            pbx_Col1.Name = "pbx_Col1";
            pbx_Col1.Size = new Size(32, 32);
            pbx_Col1.TabIndex = 100;
            pbx_Col1.TabStop = false;
            pbx_Col1.Tag = "1";
            // 
            // pbx_Col2
            // 
            pbx_Col2.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col2.Location = new Point(39, 3);
            pbx_Col2.Name = "pbx_Col2";
            pbx_Col2.Size = new Size(32, 32);
            pbx_Col2.TabIndex = 101;
            pbx_Col2.TabStop = false;
            pbx_Col2.Tag = "2";
            // 
            // pbx_Col3
            // 
            pbx_Col3.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col3.Location = new Point(75, 3);
            pbx_Col3.Name = "pbx_Col3";
            pbx_Col3.Size = new Size(32, 32);
            pbx_Col3.TabIndex = 102;
            pbx_Col3.TabStop = false;
            pbx_Col3.Tag = "3";
            // 
            // pbx_Col4
            // 
            pbx_Col4.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col4.Location = new Point(113, 3);
            pbx_Col4.Name = "pbx_Col4";
            pbx_Col4.Size = new Size(32, 32);
            pbx_Col4.TabIndex = 103;
            pbx_Col4.TabStop = false;
            pbx_Col4.Tag = "4";
            // 
            // pbx_Col5
            // 
            pbx_Col5.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col5.Location = new Point(150, 3);
            pbx_Col5.Name = "pbx_Col5";
            pbx_Col5.Size = new Size(32, 32);
            pbx_Col5.TabIndex = 104;
            pbx_Col5.TabStop = false;
            pbx_Col5.Tag = "5";
            // 
            // pbx_Col6
            // 
            pbx_Col6.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col6.Location = new Point(188, 3);
            pbx_Col6.Name = "pbx_Col6";
            pbx_Col6.Size = new Size(32, 32);
            pbx_Col6.TabIndex = 105;
            pbx_Col6.TabStop = false;
            pbx_Col6.Tag = "6";
            // 
            // pbx_Col7
            // 
            pbx_Col7.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col7.Location = new Point(227, 3);
            pbx_Col7.Name = "pbx_Col7";
            pbx_Col7.Size = new Size(32, 32);
            pbx_Col7.TabIndex = 106;
            pbx_Col7.TabStop = false;
            pbx_Col7.Tag = "7";
            // 
            // pbx_Col8
            // 
            pbx_Col8.BorderStyle = BorderStyle.FixedSingle;
            pbx_Col8.Location = new Point(265, 3);
            pbx_Col8.Name = "pbx_Col8";
            pbx_Col8.Size = new Size(32, 32);
            pbx_Col8.TabIndex = 107;
            pbx_Col8.TabStop = false;
            pbx_Col8.Tag = "8";
            // 
            // pnl_PrevColours
            // 
            pnl_PrevColours.Controls.Add(pbx_Col1);
            pnl_PrevColours.Controls.Add(pbx_Col2);
            pnl_PrevColours.Controls.Add(pbx_Col3);
            pnl_PrevColours.Controls.Add(pbx_Col4);
            pnl_PrevColours.Controls.Add(pbx_Col5);
            pnl_PrevColours.Controls.Add(pbx_Col6);
            pnl_PrevColours.Controls.Add(pbx_Col7);
            pnl_PrevColours.Controls.Add(pbx_Col8);
            pnl_PrevColours.Location = new Point(12, 252);
            pnl_PrevColours.Name = "pnl_PrevColours";
            pnl_PrevColours.Size = new Size(300, 39);
            pnl_PrevColours.TabIndex = 26;
            // 
            // frm_ColourPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 376);
            Controls.Add(pbx_ColourChoice);
            Controls.Add(pnl_PrevColours);
            Controls.Add(btn_SelectColour);
            Controls.Add(nud_Blue);
            Controls.Add(label4);
            Controls.Add(tbr_Blue);
            Controls.Add(nud_Green);
            Controls.Add(label3);
            Controls.Add(tbr_Green);
            Controls.Add(nud_Red);
            Controls.Add(label2);
            Controls.Add(tbr_Red);
            Controls.Add(nud_Alpha);
            Controls.Add(label1);
            Controls.Add(tbr_Alpha);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_ColourPicker";
            Text = "ColourPicker";
            Load += frm_ColourPicker_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_ColourChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Alpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Alpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbr_Blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Col8).EndInit();
            pnl_PrevColours.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbx_ColourChoice;
        private TrackBar tbr_Alpha;
        private Label label1;
        private NumericUpDown nud_Alpha;
        private NumericUpDown nud_Red;
        private Label label2;
        private TrackBar tbr_Red;
        private NumericUpDown nud_Green;
        private Label label3;
        private TrackBar tbr_Green;
        private NumericUpDown nud_Blue;
        private Label label4;
        private TrackBar tbr_Blue;
        private Button btn_SelectColour;
        private PictureBox pbx_Col1;
        private PictureBox pbx_Col2;
        private PictureBox pbx_Col3;
        private PictureBox pbx_Col4;
        private PictureBox pbx_Col5;
        private PictureBox pbx_Col6;
        private PictureBox pbx_Col7;
        private PictureBox pbx_Col8;
        private Panel pnl_PrevColours;
    }
}