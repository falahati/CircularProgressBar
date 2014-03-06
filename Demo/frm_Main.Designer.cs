namespace Demo
{
    partial class frm_Main
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(186, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.circularProgressBar4;
            this.propertyGrid1.Size = new System.Drawing.Size(232, 306);
            this.propertyGrid1.TabIndex = 4;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circularProgressBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(37)))));
            this.circularProgressBar4.Caption = "34";
            this.circularProgressBar4.CaptionMargin = 3;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar4.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar4.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar4.InnerCircleMargin = 4;
            this.circularProgressBar4.InnerCircleWidth = 4;
            this.circularProgressBar4.Location = new System.Drawing.Point(12, 12);
            this.circularProgressBar4.MaxValue = 100F;
            this.circularProgressBar4.MinValue = 0F;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.circularProgressBar4.OuterCircleMargin = 1;
            this.circularProgressBar4.OuterCircleWidth = 1;
            this.circularProgressBar4.ProgressCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.circularProgressBar4.ProgressCircleStartAngle = 270;
            this.circularProgressBar4.ProgressCircleWidth = 9;
            this.circularProgressBar4.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar4.SubText = ".23";
            this.circularProgressBar4.SubTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar4.SupText = "°C";
            this.circularProgressBar4.SupTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.TabIndex = 3;
            this.circularProgressBar4.Value = 50F;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(37)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.circularProgressBar4);
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

