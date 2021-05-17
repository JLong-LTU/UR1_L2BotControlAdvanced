namespace L2BotControlAdvanced
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.frameRateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.originalImagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laneDectectionConfigBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.laneDetectionSelector = new System.Windows.Forms.ComboBox();
            this.laneOutputPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.redLineConfigBtn = new System.Windows.Forms.Button();
            this.redLineOutputPictureBox = new System.Windows.Forms.PictureBox();
            this.autonomousModeBtn = new System.Windows.Forms.Button();
            this.suspendStopCmdCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laneOutputPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redLineOutputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupConfigurationToolStripMenuItem,
            this.restoreConfigurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backupConfigurationToolStripMenuItem
            // 
            this.backupConfigurationToolStripMenuItem.Name = "backupConfigurationToolStripMenuItem";
            this.backupConfigurationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.backupConfigurationToolStripMenuItem.Text = "Backup Configuration";
            // 
            // restoreConfigurationToolStripMenuItem
            // 
            this.restoreConfigurationToolStripMenuItem.Name = "restoreConfigurationToolStripMenuItem";
            this.restoreConfigurationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.restoreConfigurationToolStripMenuItem.Text = "Restore Configuration";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frameRateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frameRateLabel
            // 
            this.frameRateLabel.Name = "frameRateLabel";
            this.frameRateLabel.Size = new System.Drawing.Size(114, 20);
            this.frameRateLabel.Text = "frameRateLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.originalImagePictureBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Image";
            // 
            // originalImagePictureBox
            // 
            this.originalImagePictureBox.Location = new System.Drawing.Point(6, 21);
            this.originalImagePictureBox.Name = "originalImagePictureBox";
            this.originalImagePictureBox.Size = new System.Drawing.Size(305, 195);
            this.originalImagePictureBox.TabIndex = 0;
            this.originalImagePictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laneDectectionConfigBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.laneDetectionSelector);
            this.groupBox2.Controls.Add(this.laneOutputPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(337, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 441);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lane Detection";
            // 
            // laneDectectionConfigBtn
            // 
            this.laneDectectionConfigBtn.Location = new System.Drawing.Point(7, 298);
            this.laneDectectionConfigBtn.Name = "laneDectectionConfigBtn";
            this.laneDectectionConfigBtn.Size = new System.Drawing.Size(304, 29);
            this.laneDectectionConfigBtn.TabIndex = 7;
            this.laneDectectionConfigBtn.Text = "Settings";
            this.laneDectectionConfigBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lane Detection Method:";
            // 
            // laneDetectionSelector
            // 
            this.laneDetectionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laneDetectionSelector.FormattingEnabled = true;
            this.laneDetectionSelector.Location = new System.Drawing.Point(6, 251);
            this.laneDetectionSelector.Name = "laneDetectionSelector";
            this.laneDetectionSelector.Size = new System.Drawing.Size(305, 24);
            this.laneDetectionSelector.TabIndex = 5;
            this.laneDetectionSelector.SelectedIndexChanged += new System.EventHandler(this.laneDetectionSelector_SelectedIndexChanged);
            // 
            // laneOutputPictureBox
            // 
            this.laneOutputPictureBox.Location = new System.Drawing.Point(6, 21);
            this.laneOutputPictureBox.Name = "laneOutputPictureBox";
            this.laneOutputPictureBox.Size = new System.Drawing.Size(305, 195);
            this.laneOutputPictureBox.TabIndex = 4;
            this.laneOutputPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.suspendStopCmdCheckbox);
            this.groupBox3.Controls.Add(this.redLineConfigBtn);
            this.groupBox3.Controls.Add(this.redLineOutputPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(660, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 441);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Red Line Detection";
            // 
            // redLineConfigBtn
            // 
            this.redLineConfigBtn.Location = new System.Drawing.Point(6, 248);
            this.redLineConfigBtn.Name = "redLineConfigBtn";
            this.redLineConfigBtn.Size = new System.Drawing.Size(304, 29);
            this.redLineConfigBtn.TabIndex = 8;
            this.redLineConfigBtn.Text = "Settings";
            this.redLineConfigBtn.UseVisualStyleBackColor = true;
            this.redLineConfigBtn.Click += new System.EventHandler(this.redLineConfigBtn_Click);
            // 
            // redLineOutputPictureBox
            // 
            this.redLineOutputPictureBox.Location = new System.Drawing.Point(6, 21);
            this.redLineOutputPictureBox.Name = "redLineOutputPictureBox";
            this.redLineOutputPictureBox.Size = new System.Drawing.Size(305, 195);
            this.redLineOutputPictureBox.TabIndex = 4;
            this.redLineOutputPictureBox.TabStop = false;
            // 
            // autonomousModeBtn
            // 
            this.autonomousModeBtn.Location = new System.Drawing.Point(19, 280);
            this.autonomousModeBtn.Name = "autonomousModeBtn";
            this.autonomousModeBtn.Size = new System.Drawing.Size(304, 79);
            this.autonomousModeBtn.TabIndex = 8;
            this.autonomousModeBtn.Text = "Enable Autonomous Mode";
            this.autonomousModeBtn.UseVisualStyleBackColor = true;
            // 
            // suspendStopCmdCheckbox
            // 
            this.suspendStopCmdCheckbox.AutoSize = true;
            this.suspendStopCmdCheckbox.Location = new System.Drawing.Point(7, 302);
            this.suspendStopCmdCheckbox.Name = "suspendStopCmdCheckbox";
            this.suspendStopCmdCheckbox.Size = new System.Drawing.Size(186, 21);
            this.suspendStopCmdCheckbox.TabIndex = 9;
            this.suspendStopCmdCheckbox.Text = "Suspend Stop Command";
            this.suspendStopCmdCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 501);
            this.Controls.Add(this.autonomousModeBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "L2Bot Advanced Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laneOutputPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redLineOutputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel frameRateLabel;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox originalImagePictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox laneOutputPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox redLineOutputPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox laneDetectionSelector;
        private System.Windows.Forms.Button laneDectectionConfigBtn;
        private System.Windows.Forms.Button redLineConfigBtn;
        private System.Windows.Forms.Button autonomousModeBtn;
        private System.Windows.Forms.CheckBox suspendStopCmdCheckbox;
    }
}

