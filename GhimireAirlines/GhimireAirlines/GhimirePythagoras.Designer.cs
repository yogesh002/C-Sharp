namespace GhimireAirlines
{
    partial class GhimirePythagoras
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YesRadioBtn = new System.Windows.Forms.RadioButton();
            this.NoRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindThirdSideBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FirstSideTextBox = new System.Windows.Forms.TextBox();
            this.SecondSideTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextArea = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter two sides of a Right Angled Triangle to find the third side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sedond Side";
            // 
            // YesRadioBtn
            // 
            this.YesRadioBtn.AutoSize = true;
            this.YesRadioBtn.Location = new System.Drawing.Point(15, 30);
            this.YesRadioBtn.Name = "YesRadioBtn";
            this.YesRadioBtn.Size = new System.Drawing.Size(43, 17);
            this.YesRadioBtn.TabIndex = 2;
            this.YesRadioBtn.TabStop = true;
            this.YesRadioBtn.Text = "Yes";
            this.YesRadioBtn.UseVisualStyleBackColor = true;
            this.YesRadioBtn.CheckedChanged += new System.EventHandler(this.YesRadioBtn_CheckedChanged);
            // 
            // NoRadioBtn
            // 
            this.NoRadioBtn.AutoSize = true;
            this.NoRadioBtn.Location = new System.Drawing.Point(15, 62);
            this.NoRadioBtn.Name = "NoRadioBtn";
            this.NoRadioBtn.Size = new System.Drawing.Size(39, 17);
            this.NoRadioBtn.TabIndex = 2;
            this.NoRadioBtn.TabStop = true;
            this.NoRadioBtn.Text = "No";
            this.NoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YesRadioBtn);
            this.groupBox1.Controls.Add(this.NoRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(124, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "One of the Inputs is Hypotenuse";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FindThirdSideBtn
            // 
            this.FindThirdSideBtn.Location = new System.Drawing.Point(124, 283);
            this.FindThirdSideBtn.Name = "FindThirdSideBtn";
            this.FindThirdSideBtn.Size = new System.Drawing.Size(109, 36);
            this.FindThirdSideBtn.TabIndex = 4;
            this.FindThirdSideBtn.Text = "Find Third Side";
            this.FindThirdSideBtn.UseVisualStyleBackColor = true;
            this.FindThirdSideBtn.Click += new System.EventHandler(this.FindThirdSideBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(270, 283);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 36);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FirstSideTextBox
            // 
            this.FirstSideTextBox.Location = new System.Drawing.Point(204, 52);
            this.FirstSideTextBox.Name = "FirstSideTextBox";
            this.FirstSideTextBox.Size = new System.Drawing.Size(217, 20);
            this.FirstSideTextBox.TabIndex = 5;
            // 
            // SecondSideTextBox
            // 
            this.SecondSideTextBox.Location = new System.Drawing.Point(204, 96);
            this.SecondSideTextBox.Name = "SecondSideTextBox";
            this.SecondSideTextBox.Size = new System.Drawing.Size(217, 20);
            this.SecondSideTextBox.TabIndex = 5;
            // 
            // ResultTextArea
            // 
            this.ResultTextArea.Location = new System.Drawing.Point(124, 367);
            this.ResultTextArea.Multiline = true;
            this.ResultTextArea.Name = "ResultTextArea";
            this.ResultTextArea.ReadOnly = true;
            this.ResultTextArea.Size = new System.Drawing.Size(297, 99);
            this.ResultTextArea.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GhimirePythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 506);
            this.Controls.Add(this.ResultTextArea);
            this.Controls.Add(this.SecondSideTextBox);
            this.Controls.Add(this.FirstSideTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.FindThirdSideBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GhimirePythagoras";
            this.Text = "Version B: Ghimire Pythagoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton YesRadioBtn;
        private System.Windows.Forms.RadioButton NoRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindThirdSideBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox FirstSideTextBox;
        private System.Windows.Forms.TextBox SecondSideTextBox;
        private System.Windows.Forms.TextBox ResultTextArea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

