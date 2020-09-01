namespace FakeDoor
{
    partial class MainWindows
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.MessageBoard = new System.Windows.Forms.TextBox();
            this.ProjectionBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageBoard
            // 
            this.MessageBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBoard.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MessageBoard.Location = new System.Drawing.Point(12, 13);
            this.MessageBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessageBoard.Multiline = true;
            this.MessageBoard.Name = "MessageBoard";
            this.MessageBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBoard.Size = new System.Drawing.Size(140, 114);
            this.MessageBoard.TabIndex = 0;
            this.MessageBoard.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // ProjectionBox
            // 
            this.ProjectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectionBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProjectionBox.Location = new System.Drawing.Point(12, 151);
            this.ProjectionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProjectionBox.Name = "ProjectionBox";
            this.ProjectionBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ProjectionBox.Size = new System.Drawing.Size(140, 23);
            this.ProjectionBox.TabIndex = 1;
            this.ProjectionBox.UseWaitCursor = true;
            this.ProjectionBox.Enter += new System.EventHandler(this.ProjectionBox_Enter);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SendButton.Location = new System.Drawing.Point(54, 178);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(61, 25);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingButton.BackgroundImage")));
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SettingButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SettingButton.Location = new System.Drawing.Point(138, 131);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(14, 16);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(164, 211);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ProjectionBox);
            this.Controls.Add(this.MessageBoard);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindows";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FakeDoor";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBoard;
        private System.Windows.Forms.TextBox ProjectionBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

