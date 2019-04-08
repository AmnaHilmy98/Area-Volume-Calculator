namespace AreaVolumeCalculator
{
    partial class FormSolidSquareBasedPyramid
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBaseLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtBaseLength = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(45, 124);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(143, 24);
            this.lblHeight.TabIndex = 31;
            this.lblHeight.Text = "Enter the height";
            // 
            // lblBaseLength
            // 
            this.lblBaseLength.AutoSize = true;
            this.lblBaseLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseLength.Location = new System.Drawing.Point(45, 67);
            this.lblBaseLength.Name = "lblBaseLength";
            this.lblBaseLength.Size = new System.Drawing.Size(189, 24);
            this.lblBaseLength.TabIndex = 30;
            this.lblBaseLength.Text = "Enter the base length";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(273, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 39);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(57, 331);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(76, 24);
            this.lblVolume.TabIndex = 26;
            this.lblVolume.Text = "Volume";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(57, 274);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(120, 24);
            this.lblArea.TabIndex = 25;
            this.lblArea.Text = "Surface-Area";
            // 
            // txtBaseLength
            // 
            this.txtBaseLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseLength.Location = new System.Drawing.Point(252, 67);
            this.txtBaseLength.Name = "txtBaseLength";
            this.txtBaseLength.Size = new System.Drawing.Size(157, 29);
            this.txtBaseLength.TabIndex = 34;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(252, 124);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(157, 29);
            this.txtHeight.TabIndex = 35;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(245, 274);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(157, 29);
            this.txtArea.TabIndex = 36;
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(245, 331);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(157, 29);
            this.txtVolume.TabIndex = 37;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(173, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 33);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSolidSquareBasedPyramid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBaseLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBaseLength);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Name = "FormSolidSquareBasedPyramid";
            this.Text = "Solid Square-Based Pyramid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBaseLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtBaseLength;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnExit;
    }
}