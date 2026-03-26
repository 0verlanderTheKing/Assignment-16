namespace Assignment_16
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lightOnPictureBox = new System.Windows.Forms.PictureBox();
            this.lightOffPictureBox = new System.Windows.Forms.PictureBox();
            this.lightStateLabel = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightOnPictureBox
            // 
            this.lightOnPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightOnPictureBox.Image")));
            this.lightOnPictureBox.Location = new System.Drawing.Point(91, 30);
            this.lightOnPictureBox.Name = "lightOnPictureBox";
            this.lightOnPictureBox.Size = new System.Drawing.Size(70, 88);
            this.lightOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightOnPictureBox.TabIndex = 0;
            this.lightOnPictureBox.TabStop = false;
            // 
            // lightOffPictureBox
            // 
            this.lightOffPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightOffPictureBox.Image")));
            this.lightOffPictureBox.Location = new System.Drawing.Point(91, 30);
            this.lightOffPictureBox.Name = "lightOffPictureBox";
            this.lightOffPictureBox.Size = new System.Drawing.Size(70, 88);
            this.lightOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightOffPictureBox.TabIndex = 1;
            this.lightOffPictureBox.TabStop = false;
            // 
            // lightStateLabel
            // 
            this.lightStateLabel.AutoSize = true;
            this.lightStateLabel.Location = new System.Drawing.Point(110, 125);
            this.lightStateLabel.Name = "lightStateLabel";
            this.lightStateLabel.Size = new System.Drawing.Size(33, 16);
            this.lightStateLabel.TabIndex = 2;
            this.lightStateLabel.Text = "OFF";
            this.lightStateLabel.Click += new System.EventHandler(this.lightStateLabel_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(62, 161);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 3;
            this.switchButton.Text = "Switch Light";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(144, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 203);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.lightStateLabel);
            this.Controls.Add(this.lightOffPictureBox);
            this.Controls.Add(this.lightOnPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lightOnPictureBox;
        private System.Windows.Forms.PictureBox lightOffPictureBox;
        private System.Windows.Forms.Label lightStateLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

