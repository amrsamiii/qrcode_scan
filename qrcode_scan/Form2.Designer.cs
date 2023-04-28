
namespace qrcode_scan
{
    partial class Form2
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
            this.generateButton1 = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton1
            // 
            this.generateButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton1.Location = new System.Drawing.Point(321, 55);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(109, 37);
            this.generateButton1.TabIndex = 5;
            this.generateButton1.Text = "Generate";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.generateButton1_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(17, 143);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(771, 258);
            this.resultPictureBox.TabIndex = 7;
            this.resultPictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.generateButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton1;
        private System.Windows.Forms.PictureBox resultPictureBox;
    }
}