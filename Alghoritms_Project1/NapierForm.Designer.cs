namespace Alghoritms_Project1
{
    partial class NapierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NapierForm));
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondaryNumberTB = new System.Windows.Forms.TextBox();
            this.primaryNumberTB = new System.Windows.Forms.TextBox();
            this.workPanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.workPanelRight = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(298, 10);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 34);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Hesapla";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.secondaryNumberTB);
            this.panel1.Controls.Add(this.primaryNumberTB);
            this.panel1.Controls.Add(this.calculateButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 55);
            this.panel1.TabIndex = 7;
            // 
            // secondaryNumberTB
            // 
            this.secondaryNumberTB.Location = new System.Drawing.Point(165, 15);
            this.secondaryNumberTB.Name = "secondaryNumberTB";
            this.secondaryNumberTB.Size = new System.Drawing.Size(125, 22);
            this.secondaryNumberTB.TabIndex = 2;
            this.secondaryNumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondaryNumberTB_KeyPress);
            // 
            // primaryNumberTB
            // 
            this.primaryNumberTB.Location = new System.Drawing.Point(12, 15);
            this.primaryNumberTB.Name = "primaryNumberTB";
            this.primaryNumberTB.Size = new System.Drawing.Size(125, 22);
            this.primaryNumberTB.TabIndex = 1;
            this.primaryNumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primaryNumberTB_KeyPress);
            // 
            // workPanel
            // 
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.workPanel.Location = new System.Drawing.Point(0, 55);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(298, 452);
            this.workPanel.TabIndex = 11;
            this.workPanel.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 507);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(649, 25);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 20);
            this.toolStripStatusLabel1.Text = "Durum :";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // workPanelRight
            // 
            this.workPanelRight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.workPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.workPanelRight.Location = new System.Drawing.Point(304, 55);
            this.workPanelRight.Name = "workPanelRight";
            this.workPanelRight.Size = new System.Drawing.Size(345, 452);
            this.workPanelRight.TabIndex = 0;
            this.workPanelRight.Visible = false;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(515, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(94, 32);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "Bilgi";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(406, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 32);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // NapierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 532);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.workPanelRight);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NapierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napier Hesaplayıcısı";
            this.Load += new System.EventHandler(this.NapierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel workPanelRight;
        private System.Windows.Forms.TextBox primaryNumberTB;
        private System.Windows.Forms.TextBox secondaryNumberTB;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button clearButton;
    }
}