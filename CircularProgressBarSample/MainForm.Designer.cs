using System.Drawing;
using WinFormAnimation;

namespace CircularProgressBarSample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar6 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar4.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(215)))), ((int)(((byte)(158)))));
            this.circularProgressBar4.InnerMargin = -1;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(402, 533);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(215)))), ((int)(((byte)(158)))));
            this.circularProgressBar4.OuterMargin = -15;
            this.circularProgressBar4.OuterWidth = 8;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.circularProgressBar4.ProgressWidth = 14;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar4.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.SubscriptText = "";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.SuperscriptText = "";
            this.circularProgressBar4.TabIndex = 10;
            this.circularProgressBar4.Text = "90";
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.circularProgressBar4.Value = 90;
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar5.AnimationSpeed = 500;
            this.circularProgressBar5.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar5.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar5.InnerMargin = 0;
            this.circularProgressBar5.InnerWidth = 0;
            this.circularProgressBar5.Location = new System.Drawing.Point(207, 533);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.circularProgressBar5.OuterMargin = -11;
            this.circularProgressBar5.OuterWidth = 8;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(251)))), ((int)(((byte)(50)))));
            this.circularProgressBar5.ProgressWidth = 14;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar5.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.SubscriptText = "";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.SuperscriptText = "";
            this.circularProgressBar5.TabIndex = 9;
            this.circularProgressBar5.Text = "Please Wait";
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar5.Value = 67;
            // 
            // circularProgressBar6
            // 
            this.circularProgressBar6.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar6.AnimationSpeed = 500;
            this.circularProgressBar6.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar6.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.circularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar6.InnerMargin = 0;
            this.circularProgressBar6.InnerWidth = -1;
            this.circularProgressBar6.Location = new System.Drawing.Point(12, 533);
            this.circularProgressBar6.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar6.Name = "circularProgressBar6";
            this.circularProgressBar6.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.circularProgressBar6.OuterMargin = -25;
            this.circularProgressBar6.OuterWidth = 26;
            this.circularProgressBar6.ProgressColor = System.Drawing.Color.White;
            this.circularProgressBar6.ProgressWidth = 25;
            this.circularProgressBar6.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar6.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar6.StartAngle = 270;
            this.circularProgressBar6.SubscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar6.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.SubscriptText = "";
            this.circularProgressBar6.SuperscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar6.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.SuperscriptText = "";
            this.circularProgressBar6.TabIndex = 8;
            this.circularProgressBar6.Text = "60%";
            this.circularProgressBar6.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar6.Value = 40;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(57)))), ((int)(((byte)(3)))));
            this.circularProgressBar3.InnerMargin = 0;
            this.circularProgressBar3.InnerWidth = 0;
            this.circularProgressBar3.Location = new System.Drawing.Point(402, 338);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.OuterMargin = 0;
            this.circularProgressBar3.OuterWidth = 2;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.circularProgressBar3.ProgressWidth = -1;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar3.StartAngle = 180;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(18, -31, 0, 0);
            this.circularProgressBar3.SubscriptText = "m/s";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 7;
            this.circularProgressBar3.Text = "20";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar3.Value = 85;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerMargin = 0;
            this.circularProgressBar2.InnerWidth = 0;
            this.circularProgressBar2.Location = new System.Drawing.Point(207, 338);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.circularProgressBar2.OuterMargin = -17;
            this.circularProgressBar2.OuterWidth = 17;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(64)))), ((int)(((byte)(169)))));
            this.circularProgressBar2.ProgressWidth = 17;
            this.circularProgressBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.circularProgressBar2.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circularProgressBar2.SubscriptText = ".35";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(8, 20, 0, 0);
            this.circularProgressBar2.SuperscriptText = "%";
            this.circularProgressBar2.TabIndex = 6;
            this.circularProgressBar2.Text = "75";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar2.Value = 75;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(12, 338);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = 0;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(151)))), ((int)(((byte)(218)))));
            this.circularProgressBar1.ProgressWidth = 17;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.Text = "30";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar1.Value = 60;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.propertyGrid1.Location = new System.Drawing.Point(350, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.circularProgressBar;
            this.propertyGrid1.Size = new System.Drawing.Size(232, 320);
            this.propertyGrid1.TabIndex = 4;
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = KnownAnimationFunctions.Liner;
            this.circularProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.circularProgressBar.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(12, 12);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = ".23";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "°C";
            this.circularProgressBar.TabIndex = 3;
            this.circularProgressBar.Text = "32";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(-8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 725);
            this.Controls.Add(this.circularProgressBar4);
            this.Controls.Add(this.circularProgressBar5);
            this.Controls.Add(this.circularProgressBar6);
            this.Controls.Add(this.circularProgressBar3);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.circularProgressBar);
            this.Name = "MainForm";
            this.Text = "Circular ProgressBar Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private CircularProgressBar.CircularProgressBar circularProgressBar6;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
    }
}

