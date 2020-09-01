namespace FakeDoor
{
    partial class SettingWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OkButton = new System.Windows.Forms.Button();
            this.IpLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TakeButton = new System.Windows.Forms.Button();
            this.SettingFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingLayout = new System.Windows.Forms.Panel();
            this.ListLayout = new System.Windows.Forms.Panel();
            this.IpPortListBox = new System.Windows.Forms.ListBox();
            this.SettingFlowLayout.SuspendLayout();
            this.SettingLayout.SuspendLayout();
            this.ListLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(69, 174);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(36, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // IpLabel
            // 
            this.IpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IpLabel.AutoSize = true;
            this.IpLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IpLabel.Location = new System.Drawing.Point(9, 29);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(18, 16);
            this.IpLabel.TabIndex = 0;
            this.IpLabel.Text = "IP";
            // 
            // PortLabel
            // 
            this.PortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortLabel.AutoSize = true;
            this.PortLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PortLabel.Location = new System.Drawing.Point(9, 68);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(31, 16);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port";
            // 
            // IpTextBox
            // 
            this.IpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IpTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IpTextBox.Location = new System.Drawing.Point(49, 26);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(100, 23);
            this.IpTextBox.TabIndex = 0;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PortTextBox.Location = new System.Drawing.Point(49, 65);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 23);
            this.PortTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddButton.Location = new System.Drawing.Point(138, 123);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 20);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = ">>";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TakeButton
            // 
            this.TakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TakeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TakeButton.Location = new System.Drawing.Point(3, 123);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(36, 20);
            this.TakeButton.TabIndex = 1;
            this.TakeButton.Text = "<<";
            this.TakeButton.UseVisualStyleBackColor = true;
            this.TakeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // SettingFlowLayout
            // 
            this.SettingFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingFlowLayout.AutoSize = true;
            this.SettingFlowLayout.Controls.Add(this.SettingLayout);
            this.SettingFlowLayout.Controls.Add(this.ListLayout);
            this.SettingFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.SettingFlowLayout.Name = "SettingFlowLayout";
            this.SettingFlowLayout.Size = new System.Drawing.Size(416, 244);
            this.SettingFlowLayout.TabIndex = 3;
            // 
            // SettingLayout
            // 
            this.SettingLayout.Controls.Add(this.PortTextBox);
            this.SettingLayout.Controls.Add(this.IpLabel);
            this.SettingLayout.Controls.Add(this.IpTextBox);
            this.SettingLayout.Controls.Add(this.OkButton);
            this.SettingLayout.Controls.Add(this.PortLabel);
            this.SettingLayout.Controls.Add(this.AddButton);
            this.SettingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingLayout.Location = new System.Drawing.Point(3, 3);
            this.SettingLayout.Name = "SettingLayout";
            this.SettingLayout.Size = new System.Drawing.Size(177, 236);
            this.SettingLayout.TabIndex = 0;
            // 
            // ListLayout
            // 
            this.ListLayout.AutoSize = true;
            this.ListLayout.Controls.Add(this.IpPortListBox);
            this.ListLayout.Controls.Add(this.TakeButton);
            this.ListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLayout.Location = new System.Drawing.Point(186, 3);
            this.ListLayout.Name = "ListLayout";
            this.ListLayout.Size = new System.Drawing.Size(227, 236);
            this.ListLayout.TabIndex = 1;
            // 
            // IpPortListBox
            // 
            this.IpPortListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IpPortListBox.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.IpPortListBox.FormattingEnabled = true;
            this.IpPortListBox.ItemHeight = 16;
            this.IpPortListBox.Items.AddRange(new object[] {
            "127.100.100.101:192505"});
            this.IpPortListBox.Location = new System.Drawing.Point(57, 5);
            this.IpPortListBox.Name = "IpPortListBox";
            this.IpPortListBox.ScrollAlwaysVisible = true;
            this.IpPortListBox.Size = new System.Drawing.Size(167, 228);
            this.IpPortListBox.TabIndex = 0;
            // 
            // SettingWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(416, 244);
            this.Controls.Add(this.SettingFlowLayout);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingWindows";
            this.Text = "SettingWindows";
            this.SettingFlowLayout.ResumeLayout(false);
            this.SettingFlowLayout.PerformLayout();
            this.SettingLayout.ResumeLayout(false);
            this.SettingLayout.PerformLayout();
            this.ListLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button TakeButton;
        private System.Windows.Forms.FlowLayoutPanel SettingFlowLayout;
        private System.Windows.Forms.Panel SettingLayout;
        private System.Windows.Forms.Panel ListLayout;
        private System.Windows.Forms.ListBox IpPortListBox;
    }
}