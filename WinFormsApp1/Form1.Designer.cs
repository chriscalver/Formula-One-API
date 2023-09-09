namespace WinFormsApp1
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
            txtOutput = new TextBox();
            txtOutput2 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbldriver1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(391, 564);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(359, 45);
            txtOutput.TabIndex = 0;
            // 
            // txtOutput2
            // 
            txtOutput2.Location = new Point(391, 639);
            txtOutput2.Multiline = true;
            txtOutput2.Name = "txtOutput2";
            txtOutput2.Size = new Size(359, 59);
            txtOutput2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(431, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 161);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Michroma", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(904, 142);
            label1.TabIndex = 3;
            label1.Text = "FORMULA ONE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Racing Sans One", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1188, 627);
            label2.Name = "label2";
            label2.Size = new Size(161, 59);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Racing Sans One", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(248, 151);
            label3.Name = "label3";
            label3.Size = new Size(160, 50);
            label3.TabIndex = 5;
            label3.Text = "Drivers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Racing Sans One", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(728, 151);
            label4.Name = "label4";
            label4.Size = new Size(269, 50);
            label4.TabIndex = 6;
            label4.Text = "Constructors";
            // 
            // lbldriver1
            // 
            lbldriver1.AutoSize = true;
            lbldriver1.Font = new Font("Michroma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbldriver1.Location = new Point(299, 201);
            lbldriver1.Name = "lbldriver1";
            lbldriver1.Size = new Size(97, 30);
            lbldriver1.TabIndex = 7;
            lbldriver1.Text = "Driver 1";
            lbldriver1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1132, 728);
            Controls.Add(label3);
            Controls.Add(lbldriver1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtOutput2);
            Controls.Add(txtOutput);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private TextBox txtOutput2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbldriver1;
    }
}