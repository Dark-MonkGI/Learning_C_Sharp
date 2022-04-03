namespace GuessTheMelody
{
    partial class fParameters
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
            this.lbListMusik = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.cbSubfolders = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListMusik
            // 
            this.lbListMusik.FormattingEnabled = true;
            this.lbListMusik.ItemHeight = 20;
            this.lbListMusik.Location = new System.Drawing.Point(-3, 0);
            this.lbListMusik.Name = "lbListMusik";
            this.lbListMusik.Size = new System.Drawing.Size(849, 324);
            this.lbListMusik.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSelectFolder.Location = new System.Drawing.Point(14, 340);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(146, 42);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnClearList.Location = new System.Drawing.Point(208, 340);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(146, 42);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // cbSubfolders
            // 
            this.cbSubfolders.AutoSize = true;
            this.cbSubfolders.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbSubfolders.Location = new System.Drawing.Point(717, 350);
            this.cbSubfolders.Name = "cbSubfolders";
            this.cbSubfolders.Size = new System.Drawing.Size(107, 24);
            this.cbSubfolders.TabIndex = 3;
            this.cbSubfolders.Text = "Subfolders";
            this.cbSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(500, 436);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 42);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(674, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 512);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSubfolders);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lbListMusik);
            this.Name = "fParameters";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbListMusik;
        private Button btnSelectFolder;
        private Button btnClearList;
        private CheckBox cbSubfolders;
        private Button btnOK;
        private Button btnCancel;
    }
}