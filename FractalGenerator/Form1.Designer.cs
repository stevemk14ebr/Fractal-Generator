namespace FractalGenerator
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
            this.DrawCanvas = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.TrackShrinkRatio = new System.Windows.Forms.TrackBar();
            this.lblShrinkRatio = new System.Windows.Forms.Label();
            this.TrackAngleDelta = new System.Windows.Forms.TrackBar();
            this.lblAngleDelta = new System.Windows.Forms.Label();
            this.TrackSplitDepth = new System.Windows.Forms.TrackBar();
            this.lblSplitDepth = new System.Windows.Forms.Label();
            this.txtAnimDelay = new System.Windows.Forms.TextBox();
            this.lblAnimDelay = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawCanvas.Location = new System.Drawing.Point(12, 12);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(776, 391);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            this.DrawCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCanvas_Paint);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(12, 445);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(103, 23);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // TrackShrinkRatio
            // 
            this.TrackShrinkRatio.Location = new System.Drawing.Point(149, 423);
            this.TrackShrinkRatio.Name = "TrackShrinkRatio";
            this.TrackShrinkRatio.Size = new System.Drawing.Size(104, 45);
            this.TrackShrinkRatio.TabIndex = 2;
            this.TrackShrinkRatio.Value = 8;
            // 
            // lblShrinkRatio
            // 
            this.lblShrinkRatio.AutoSize = true;
            this.lblShrinkRatio.Location = new System.Drawing.Point(166, 407);
            this.lblShrinkRatio.Name = "lblShrinkRatio";
            this.lblShrinkRatio.Size = new System.Drawing.Size(62, 13);
            this.lblShrinkRatio.TabIndex = 3;
            this.lblShrinkRatio.Text = "ShrinkRatio";
            // 
            // TrackAngleDelta
            // 
            this.TrackAngleDelta.Location = new System.Drawing.Point(259, 423);
            this.TrackAngleDelta.Maximum = 85;
            this.TrackAngleDelta.Minimum = 10;
            this.TrackAngleDelta.Name = "TrackAngleDelta";
            this.TrackAngleDelta.Size = new System.Drawing.Size(104, 45);
            this.TrackAngleDelta.TabIndex = 4;
            this.TrackAngleDelta.TickFrequency = 5;
            this.TrackAngleDelta.Value = 45;
            // 
            // lblAngleDelta
            // 
            this.lblAngleDelta.AutoSize = true;
            this.lblAngleDelta.Location = new System.Drawing.Point(275, 407);
            this.lblAngleDelta.Name = "lblAngleDelta";
            this.lblAngleDelta.Size = new System.Drawing.Size(62, 13);
            this.lblAngleDelta.TabIndex = 5;
            this.lblAngleDelta.Text = "Angle Delta";
            // 
            // TrackSplitDepth
            // 
            this.TrackSplitDepth.Location = new System.Drawing.Point(369, 423);
            this.TrackSplitDepth.Maximum = 20;
            this.TrackSplitDepth.Minimum = 3;
            this.TrackSplitDepth.Name = "TrackSplitDepth";
            this.TrackSplitDepth.Size = new System.Drawing.Size(104, 45);
            this.TrackSplitDepth.TabIndex = 6;
            this.TrackSplitDepth.Value = 7;
            // 
            // lblSplitDepth
            // 
            this.lblSplitDepth.AutoSize = true;
            this.lblSplitDepth.Location = new System.Drawing.Point(392, 407);
            this.lblSplitDepth.Name = "lblSplitDepth";
            this.lblSplitDepth.Size = new System.Drawing.Size(56, 13);
            this.lblSplitDepth.TabIndex = 7;
            this.lblSplitDepth.Text = "SplitDepth";
            // 
            // txtAnimDelay
            // 
            this.txtAnimDelay.Location = new System.Drawing.Point(479, 426);
            this.txtAnimDelay.Name = "txtAnimDelay";
            this.txtAnimDelay.Size = new System.Drawing.Size(84, 20);
            this.txtAnimDelay.TabIndex = 8;
            this.txtAnimDelay.Text = "50";
            // 
            // lblAnimDelay
            // 
            this.lblAnimDelay.AutoSize = true;
            this.lblAnimDelay.Location = new System.Drawing.Point(480, 407);
            this.lblAnimDelay.Name = "lblAnimDelay";
            this.lblAnimDelay.Size = new System.Drawing.Size(83, 13);
            this.lblAnimDelay.TabIndex = 9;
            this.lblAnimDelay.Text = "Animation Delay";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 416);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop Drawing";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblAnimDelay);
            this.Controls.Add(this.txtAnimDelay);
            this.Controls.Add(this.lblSplitDepth);
            this.Controls.Add(this.TrackSplitDepth);
            this.Controls.Add(this.lblAngleDelta);
            this.Controls.Add(this.TrackAngleDelta);
            this.Controls.Add(this.lblShrinkRatio);
            this.Controls.Add(this.TrackShrinkRatio);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.DrawCanvas);
            this.Name = "Form1";
            this.Text = "Fractal Generator";
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawCanvas;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.TrackBar TrackShrinkRatio;
        private System.Windows.Forms.Label lblShrinkRatio;
        private System.Windows.Forms.TrackBar TrackAngleDelta;
        private System.Windows.Forms.Label lblAngleDelta;
        private System.Windows.Forms.TrackBar TrackSplitDepth;
        private System.Windows.Forms.Label lblSplitDepth;
        private System.Windows.Forms.TextBox txtAnimDelay;
        private System.Windows.Forms.Label lblAnimDelay;
        private System.Windows.Forms.Button btnStop;
    }
}

