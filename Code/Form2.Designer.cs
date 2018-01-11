namespace File_Master
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(391, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 22);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(96, 54);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(294, 20);
            this.txtKeyword.TabIndex = 13;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblKeyword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKeyword.Location = new System.Drawing.Point(2, 53);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(97, 19);
            this.lblKeyword.TabIndex = 12;
            this.lblKeyword.Text = "File Keyword";
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPath.FlatAppearance.BorderSize = 0;
            this.btnPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPath.Location = new System.Drawing.Point(391, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(90, 21);
            this.btnPath.TabIndex = 11;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(81, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(309, 20);
            this.txtPath.TabIndex = 10;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPath.Location = new System.Drawing.Point(7, 11);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(68, 19);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(2, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instuctions: Simply select the location of the files you wish to delete ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(2, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "and input a keyword, when you press delete this will delete all files ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(2, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "that contain that word.";
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMain.Location = new System.Drawing.Point(389, 181);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(90, 22);
            this.btnMain.TabIndex = 18;
            this.btnMain.Text = "Main Menu";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(481, 215);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 254);
            this.MinimumSize = new System.Drawing.Size(497, 254);
            this.Name = "Delete";
            this.Text = "Delete Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMain;
    }
}
