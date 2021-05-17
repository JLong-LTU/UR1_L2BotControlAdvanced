namespace L2BotControlAdvanced.Views
{
    partial class BinaryThresholdConfigForm
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
            this.thresholdTrackbar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // thresholdTrackbar
            // 
            this.thresholdTrackbar.Location = new System.Drawing.Point(12, 296);
            this.thresholdTrackbar.Maximum = 255;
            this.thresholdTrackbar.Name = "thresholdTrackbar";
            this.thresholdTrackbar.Size = new System.Drawing.Size(776, 56);
            this.thresholdTrackbar.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(243, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(325, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Threshold";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BinaryThresholdConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.thresholdTrackbar);
            this.Name = "BinaryThresholdConfigForm";
            this.Text = "BinaryThresholdConfigForm";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar thresholdTrackbar;
        private System.Windows.Forms.Button saveButton;
    }
}