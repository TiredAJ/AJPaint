namespace AJPaint
{
    partial class frm_FileLoc
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
            lbl_FolderPath = new Label();
            txt_FolderPath = new TextBox();
            btn_FindFolderLoc = new Button();
            txt_FileName = new TextBox();
            lbl_FileName = new Label();
            cmbx_FileExtensions = new ComboBox();
            btn_Submit = new Button();
            fbd_ChosenFolder = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // lbl_FolderPath
            // 
            lbl_FolderPath.AutoSize = true;
            lbl_FolderPath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FolderPath.Location = new Point(12, 9);
            lbl_FolderPath.Name = "lbl_FolderPath";
            lbl_FolderPath.Size = new Size(88, 21);
            lbl_FolderPath.TabIndex = 0;
            lbl_FolderPath.Text = "Folder Path";
            // 
            // txt_FolderPath
            // 
            txt_FolderPath.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_FolderPath.Location = new Point(12, 33);
            txt_FolderPath.Name = "txt_FolderPath";
            txt_FolderPath.Size = new Size(376, 33);
            txt_FolderPath.TabIndex = 1;
            txt_FolderPath.TextChanged += txt_FolderPath_TextChanged;
            // 
            // btn_FindFolderLoc
            // 
            btn_FindFolderLoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_FindFolderLoc.Location = new Point(394, 34);
            btn_FindFolderLoc.Name = "btn_FindFolderLoc";
            btn_FindFolderLoc.Size = new Size(116, 31);
            btn_FindFolderLoc.TabIndex = 2;
            btn_FindFolderLoc.Text = "Select Folder";
            btn_FindFolderLoc.UseVisualStyleBackColor = true;
            btn_FindFolderLoc.Click += btn_FindFolderLoc_Click;
            // 
            // txt_FileName
            // 
            txt_FileName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_FileName.Location = new Point(12, 93);
            txt_FileName.Name = "txt_FileName";
            txt_FileName.Size = new Size(299, 33);
            txt_FileName.TabIndex = 4;
            txt_FileName.Text = "MyDrawing";
            // 
            // lbl_FileName
            // 
            lbl_FileName.AutoSize = true;
            lbl_FileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FileName.Location = new Point(12, 69);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(52, 21);
            lbl_FileName.TabIndex = 3;
            lbl_FileName.Text = "label2";
            // 
            // cmbx_FileExtensions
            // 
            cmbx_FileExtensions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbx_FileExtensions.FormattingEnabled = true;
            cmbx_FileExtensions.Items.AddRange(new object[] { ".png", ".bmp", ".jpg", ".gif", ".ico" });
            cmbx_FileExtensions.Location = new Point(317, 93);
            cmbx_FileExtensions.Name = "cmbx_FileExtensions";
            cmbx_FileExtensions.Size = new Size(71, 33);
            cmbx_FileExtensions.TabIndex = 5;
            // 
            // btn_Submit
            // 
            btn_Submit.Enabled = false;
            btn_Submit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Submit.Location = new Point(394, 94);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(116, 33);
            btn_Submit.TabIndex = 6;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // fbd_ChosenFolder
            // 
            fbd_ChosenFolder.RootFolder = Environment.SpecialFolder.MyPictures;
            // 
            // frm_FileLoc
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 138);
            Controls.Add(btn_Submit);
            Controls.Add(cmbx_FileExtensions);
            Controls.Add(txt_FileName);
            Controls.Add(lbl_FileName);
            Controls.Add(btn_FindFolderLoc);
            Controls.Add(txt_FolderPath);
            Controls.Add(lbl_FolderPath);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_FileLoc";
            Text = "frm_FileLoc";
            Load += frm_FileLoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_FolderPath;
        private TextBox txt_FolderPath;
        private Button btn_FindFolderLoc;
        private TextBox txt_FileName;
        private Label lbl_FileName;
        private ComboBox cmbx_FileExtensions;
        private Button btn_Submit;
        private FolderBrowserDialog fbd_ChosenFolder;
    }
}