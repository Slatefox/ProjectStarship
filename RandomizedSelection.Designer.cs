namespace Starfinder_Starship_Hanger
{
    partial class RandomizedSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.balBTN = new System.Windows.Forms.Button();
            this.spdBTN = new System.Windows.Forms.Button();
            this.offBTN = new System.Windows.Forms.Button();
            this.defBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select what type of randomized ship you would like generated:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // balBTN
            // 
            this.balBTN.Location = new System.Drawing.Point(16, 53);
            this.balBTN.Name = "balBTN";
            this.balBTN.Size = new System.Drawing.Size(75, 23);
            this.balBTN.TabIndex = 1;
            this.balBTN.Text = "Balanced";
            this.balBTN.UseVisualStyleBackColor = true;
            this.balBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // spdBTN
            // 
            this.spdBTN.Location = new System.Drawing.Point(98, 52);
            this.spdBTN.Name = "spdBTN";
            this.spdBTN.Size = new System.Drawing.Size(75, 23);
            this.spdBTN.TabIndex = 2;
            this.spdBTN.Text = "Speed";
            this.spdBTN.UseVisualStyleBackColor = true;
            this.spdBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // offBTN
            // 
            this.offBTN.Location = new System.Drawing.Point(180, 52);
            this.offBTN.Name = "offBTN";
            this.offBTN.Size = new System.Drawing.Size(75, 23);
            this.offBTN.TabIndex = 3;
            this.offBTN.Text = "Offensive";
            this.offBTN.UseVisualStyleBackColor = true;
            this.offBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // defBTN
            // 
            this.defBTN.Location = new System.Drawing.Point(262, 52);
            this.defBTN.Name = "defBTN";
            this.defBTN.Size = new System.Drawing.Size(75, 23);
            this.defBTN.TabIndex = 4;
            this.defBTN.Text = "Defensive";
            this.defBTN.UseVisualStyleBackColor = true;
            this.defBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // RandomizedSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 92);
            this.Controls.Add(this.defBTN);
            this.Controls.Add(this.offBTN);
            this.Controls.Add(this.spdBTN);
            this.Controls.Add(this.balBTN);
            this.Controls.Add(this.label1);
            this.Name = "RandomizedSelection";
            this.Text = "Randomized Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button balBTN;
        private System.Windows.Forms.Button spdBTN;
        private System.Windows.Forms.Button offBTN;
        private System.Windows.Forms.Button defBTN;
    }
}