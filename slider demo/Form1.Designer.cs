namespace slider_demo
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
            this.tbrRed = new System.Windows.Forms.TrackBar();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.tbrGreen = new System.Windows.Forms.TrackBar();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.tbrBlue = new System.Windows.Forms.TrackBar();
            this.pbxSquare = new System.Windows.Forms.PictureBox();
            this.lblSaturationValue = new System.Windows.Forms.Label();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            this.SuspendLayout();
            // 
            // tbrRed
            // 
            this.tbrRed.BackColor = System.Drawing.Color.Red;
            this.tbrRed.Location = new System.Drawing.Point(12, 12);
            this.tbrRed.Maximum = 255;
            this.tbrRed.Name = "tbrRed";
            this.tbrRed.Size = new System.Drawing.Size(226, 45);
            this.tbrRed.TabIndex = 0;
            this.tbrRed.TickFrequency = 10;
            this.tbrRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrRed.Scroll += new System.EventHandler(this.tbrRed_Scroll);
            // 
            // lblRedValue
            // 
            this.lblRedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.ForeColor = System.Drawing.Color.Red;
            this.lblRedValue.Location = new System.Drawing.Point(260, 13);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(250, 45);
            this.lblRedValue.TabIndex = 1;
            this.lblRedValue.Text = "Red Value = 0";
            this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.ForeColor = System.Drawing.Color.Green;
            this.lblGreenValue.Location = new System.Drawing.Point(260, 83);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(250, 45);
            this.lblGreenValue.TabIndex = 3;
            this.lblGreenValue.Text = "Green Value = 0";
            this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrGreen
            // 
            this.tbrGreen.BackColor = System.Drawing.Color.Green;
            this.tbrGreen.Location = new System.Drawing.Point(12, 83);
            this.tbrGreen.Maximum = 255;
            this.tbrGreen.Name = "tbrGreen";
            this.tbrGreen.Size = new System.Drawing.Size(226, 45);
            this.tbrGreen.TabIndex = 2;
            this.tbrGreen.TickFrequency = 10;
            this.tbrGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrGreen.Scroll += new System.EventHandler(this.tbrGreen_Scroll);
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueValue.Location = new System.Drawing.Point(260, 152);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(250, 45);
            this.lblBlueValue.TabIndex = 5;
            this.lblBlueValue.Text = "Blue Value = 0";
            this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrBlue
            // 
            this.tbrBlue.BackColor = System.Drawing.Color.Blue;
            this.tbrBlue.Location = new System.Drawing.Point(12, 152);
            this.tbrBlue.Maximum = 255;
            this.tbrBlue.Name = "tbrBlue";
            this.tbrBlue.Size = new System.Drawing.Size(226, 45);
            this.tbrBlue.TabIndex = 4;
            this.tbrBlue.TickFrequency = 10;
            this.tbrBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrBlue.Scroll += new System.EventHandler(this.tbrBlue_Scroll);
            // 
            // pbxSquare
            // 
            this.pbxSquare.BackColor = System.Drawing.Color.Black;
            this.pbxSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSquare.Location = new System.Drawing.Point(556, 13);
            this.pbxSquare.Name = "pbxSquare";
            this.pbxSquare.Size = new System.Drawing.Size(191, 184);
            this.pbxSquare.TabIndex = 6;
            this.pbxSquare.TabStop = false;
            // 
            // lblSaturationValue
            // 
            this.lblSaturationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaturationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturationValue.ForeColor = System.Drawing.Color.Black;
            this.lblSaturationValue.Location = new System.Drawing.Point(260, 225);
            this.lblSaturationValue.Name = "lblSaturationValue";
            this.lblSaturationValue.Size = new System.Drawing.Size(250, 45);
            this.lblSaturationValue.TabIndex = 8;
            this.lblSaturationValue.Text = "Saturation Value = 255";
            this.lblSaturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrSaturation
            // 
            this.tbrSaturation.BackColor = System.Drawing.Color.Black;
            this.tbrSaturation.Location = new System.Drawing.Point(12, 225);
            this.tbrSaturation.Maximum = 255;
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Size = new System.Drawing.Size(226, 45);
            this.tbrSaturation.TabIndex = 7;
            this.tbrSaturation.TickFrequency = 10;
            this.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrSaturation.Value = 255;
            this.tbrSaturation.Scroll += new System.EventHandler(this.tbrSaturation_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = resources.GetString("btnReset.AccessibleDescription");
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(260, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 42);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AccessibleDescription = resources.GetString("btnQuit.AccessibleDescription");
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(408, 319);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(102, 42);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 382);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSaturationValue);
            this.Controls.Add(this.tbrSaturation);
            this.Controls.Add(this.pbxSquare);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.tbrBlue);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.tbrGreen);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.tbrRed);
            this.Name = "Form1";
            this.Text = "The Mailman Color Mixer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbrRed;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.TrackBar tbrGreen;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.TrackBar tbrBlue;
        private System.Windows.Forms.PictureBox pbxSquare;
        private System.Windows.Forms.Label lblSaturationValue;
        private System.Windows.Forms.TrackBar tbrSaturation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
    }
}

