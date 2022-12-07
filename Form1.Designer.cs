namespace ACA_Story_Generator_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.txtOutput.Location = new System.Drawing.Point(0, 43);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(807, 158);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Tag = "txtOutput";
            this.txtOutput.Text = "Click the button below to generate an ACA story. :^)";
            this.txtOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnter.Location = new System.Drawing.Point(159, 264);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(495, 55);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Tag = "btnEnter";
            this.btnEnter.Text = "Hello, I\'m Tracy Grimshaw, and welcome to A Current Affair.";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkName.Location = new System.Drawing.Point(67, 363);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(118, 24);
            this.chkName.TabIndex = 2;
            this.chkName.Text = "Input a name";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(66, 393);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "John Fortnite";
            this.txtName.Size = new System.Drawing.Size(310, 27);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 556);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "A Current Affair Story Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtOutput;
        private Button btnEnter;
        private CheckBox chkName;
        private TextBox txtName;
    }
}