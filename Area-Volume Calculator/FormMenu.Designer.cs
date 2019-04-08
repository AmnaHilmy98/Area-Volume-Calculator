namespace AreaVolumeCalculator
{
    partial class FormMenu
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
            this.btnSolidCone = new System.Windows.Forms.Button();
            this.btnSolidCylinder = new System.Windows.Forms.Button();
            this.btnSolidSphere = new System.Windows.Forms.Button();
            this.btnSolidSquareBasedPyramid = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolidCone
            // 
            this.btnSolidCone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSolidCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCone.Location = new System.Drawing.Point(62, 122);
            this.btnSolidCone.Margin = new System.Windows.Forms.Padding(6);
            this.btnSolidCone.Name = "btnSolidCone";
            this.btnSolidCone.Size = new System.Drawing.Size(316, 57);
            this.btnSolidCone.TabIndex = 0;
            this.btnSolidCone.Text = "Solid cone";
            this.btnSolidCone.UseVisualStyleBackColor = false;
            this.btnSolidCone.Click += new System.EventHandler(this.solidCone_Click);
            // 
            // btnSolidCylinder
            // 
            this.btnSolidCylinder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSolidCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCylinder.Location = new System.Drawing.Point(62, 208);
            this.btnSolidCylinder.Margin = new System.Windows.Forms.Padding(6);
            this.btnSolidCylinder.Name = "btnSolidCylinder";
            this.btnSolidCylinder.Size = new System.Drawing.Size(316, 57);
            this.btnSolidCylinder.TabIndex = 1;
            this.btnSolidCylinder.Text = "Solid cylinder";
            this.btnSolidCylinder.UseVisualStyleBackColor = false;
            this.btnSolidCylinder.Click += new System.EventHandler(this.solidCylinder_Click);
            // 
            // btnSolidSphere
            // 
            this.btnSolidSphere.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSolidSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidSphere.Location = new System.Drawing.Point(62, 296);
            this.btnSolidSphere.Margin = new System.Windows.Forms.Padding(6);
            this.btnSolidSphere.Name = "btnSolidSphere";
            this.btnSolidSphere.Size = new System.Drawing.Size(316, 57);
            this.btnSolidSphere.TabIndex = 2;
            this.btnSolidSphere.Text = "Solid sphere";
            this.btnSolidSphere.UseVisualStyleBackColor = false;
            this.btnSolidSphere.Click += new System.EventHandler(this.solidSphere_Click);
            // 
            // btnSolidSquareBasedPyramid
            // 
            this.btnSolidSquareBasedPyramid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSolidSquareBasedPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidSquareBasedPyramid.Location = new System.Drawing.Point(62, 385);
            this.btnSolidSquareBasedPyramid.Margin = new System.Windows.Forms.Padding(6);
            this.btnSolidSquareBasedPyramid.Name = "btnSolidSquareBasedPyramid";
            this.btnSolidSquareBasedPyramid.Size = new System.Drawing.Size(316, 57);
            this.btnSolidSquareBasedPyramid.TabIndex = 3;
            this.btnSolidSquareBasedPyramid.Text = "Solid square-based pyramid";
            this.btnSolidSquareBasedPyramid.UseVisualStyleBackColor = false;
            this.btnSolidSquareBasedPyramid.Click += new System.EventHandler(this.solidSquareBasedPyramid_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(80, 49);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(289, 24);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Please select a shape to proceed";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(445, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnSolidSquareBasedPyramid);
            this.Controls.Add(this.btnSolidSphere);
            this.Controls.Add(this.btnSolidCylinder);
            this.Controls.Add(this.btnSolidCone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolidCone;
        private System.Windows.Forms.Button btnSolidCylinder;
        private System.Windows.Forms.Button btnSolidSphere;
        private System.Windows.Forms.Button btnSolidSquareBasedPyramid;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button button1;
    }
}

