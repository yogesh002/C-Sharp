namespace ProjectGroup1
{
    partial class AboutUs
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
            this.MainHeading = new System.Windows.Forms.Label();
            this.subContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainHeading
            // 
            this.MainHeading.AutoSize = true;
            this.MainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHeading.Location = new System.Drawing.Point(148, 38);
            this.MainHeading.Name = "MainHeading";
            this.MainHeading.Size = new System.Drawing.Size(219, 17);
            this.MainHeading.TabIndex = 0;
            this.MainHeading.Text = "Group1 Online Grocery Shop";
            // 
            // subContent
            // 
            this.subContent.AutoSize = true;
            this.subContent.Location = new System.Drawing.Point(58, 83);
            this.subContent.Name = "subContent";
            this.subContent.Size = new System.Drawing.Size(35, 13);
            this.subContent.TabIndex = 1;
            this.subContent.Text = "label2";
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 295);
            this.Controls.Add(this.subContent);
            this.Controls.Add(this.MainHeading);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainHeading;
        private System.Windows.Forms.Label subContent;
    }
}