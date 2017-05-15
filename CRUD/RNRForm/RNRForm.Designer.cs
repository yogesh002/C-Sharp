namespace RNRForm
{
    partial class RNRForm
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
            this.SelectAuthorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SelectAuthorTextBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FictionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectAuthorLabel
            // 
            this.SelectAuthorLabel.AutoSize = true;
            this.SelectAuthorLabel.Location = new System.Drawing.Point(-1, 46);
            this.SelectAuthorLabel.Name = "SelectAuthorLabel";
            this.SelectAuthorLabel.Size = new System.Drawing.Size(71, 13);
            this.SelectAuthorLabel.TabIndex = 0;
            this.SelectAuthorLabel.Text = "Select Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject Code";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(402, 38);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(171, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(402, 108);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(171, 20);
            this.PublisherTextBox.TabIndex = 1;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(402, 165);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(171, 20);
            this.SubjectCodeTextBox.TabIndex = 1;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(402, 230);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(171, 20);
            this.SubjectTextBox.TabIndex = 1;
            // 
            // SelectAuthorTextBox
            // 
            this.SelectAuthorTextBox.FormattingEnabled = true;
            this.SelectAuthorTextBox.Location = new System.Drawing.Point(76, 43);
            this.SelectAuthorTextBox.Name = "SelectAuthorTextBox";
            this.SelectAuthorTextBox.Size = new System.Drawing.Size(195, 21);
            this.SelectAuthorTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiction ?";
            // 
            // FictionTextBox
            // 
            this.FictionTextBox.Location = new System.Drawing.Point(402, 304);
            this.FictionTextBox.Name = "FictionTextBox";
            this.FictionTextBox.Size = new System.Drawing.Size(171, 20);
            this.FictionTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 380);
            this.Controls.Add(this.SelectAuthorTextBox);
            this.Controls.Add(this.FictionTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectAuthorLabel);
            this.Name = "Form1";
            this.Text = "RNRForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectAuthorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.ComboBox SelectAuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FictionTextBox;
    }
}

