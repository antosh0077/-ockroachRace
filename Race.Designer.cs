
namespace СockroachRace
{
    partial class Race
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
            this.startBtn = new System.Windows.Forms.Button();
            this.winnerLbl = new System.Windows.Forms.Label();
            this.cockroach3PB = new System.Windows.Forms.PictureBox();
            this.cockroach1PB = new System.Windows.Forms.PictureBox();
            this.cockroach2PB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cockroach3PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroach1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroach2PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(21, 751);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 42);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // winnerLbl
            // 
            this.winnerLbl.AutoSize = true;
            this.winnerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnerLbl.ForeColor = System.Drawing.Color.Red;
            this.winnerLbl.Location = new System.Drawing.Point(226, 250);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(0, 92);
            this.winnerLbl.TabIndex = 10;
            // 
            // cockroach3PB
            // 
            this.cockroach3PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cockroach3PB.Image = global::СockroachRace.Properties.Resources._100x83_cockoch_;
            this.cockroach3PB.Location = new System.Drawing.Point(87, 571);
            this.cockroach3PB.Name = "cockroach3PB";
            this.cockroach3PB.Size = new System.Drawing.Size(115, 73);
            this.cockroach3PB.TabIndex = 9;
            this.cockroach3PB.TabStop = false;
            // 
            // cockroach1PB
            // 
            this.cockroach1PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cockroach1PB.Image = global::СockroachRace.Properties.Resources._100x83_cockoch_;
            this.cockroach1PB.Location = new System.Drawing.Point(87, 165);
            this.cockroach1PB.Name = "cockroach1PB";
            this.cockroach1PB.Size = new System.Drawing.Size(115, 73);
            this.cockroach1PB.TabIndex = 8;
            this.cockroach1PB.TabStop = false;
            // 
            // cockroach2PB
            // 
            this.cockroach2PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cockroach2PB.Image = global::СockroachRace.Properties.Resources._100x83_cockoch_;
            this.cockroach2PB.Location = new System.Drawing.Point(87, 369);
            this.cockroach2PB.Name = "cockroach2PB";
            this.cockroach2PB.Size = new System.Drawing.Size(115, 73);
            this.cockroach2PB.TabIndex = 7;
            this.cockroach2PB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::СockroachRace.Properties.Resources.Race___;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1601, 796);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 820);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.winnerLbl);
            this.Controls.Add(this.cockroach3PB);
            this.Controls.Add(this.cockroach1PB);
            this.Controls.Add(this.cockroach2PB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Race";
            this.Text = "Race";
            ((System.ComponentModel.ISupportInitialize)(this.cockroach3PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroach1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroach2PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cockroach2PB;
        private System.Windows.Forms.PictureBox cockroach1PB;
        private System.Windows.Forms.PictureBox cockroach3PB;
        private System.Windows.Forms.Label winnerLbl;
    }
}

