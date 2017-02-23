namespace Secure_Data_Streaming_Using_Steganography
{
    partial class Reciever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reciever));
            this.playBtn = new System.Windows.Forms.Button();
            this.channelComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.terminateBtn = new System.Windows.Forms.Button();
            this.secretMsgRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.channelsLbl = new System.Windows.Forms.Label();
            this.secretMsgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.Control;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.Location = new System.Drawing.Point(48, 56);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(51, 38);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // channelComboBox
            // 
            this.channelComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.channelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelComboBox.FormattingEnabled = true;
            this.channelComboBox.Items.AddRange(new object[] {
            "Arabic",
            "English"});
            this.channelComboBox.Location = new System.Drawing.Point(151, 56);
            this.channelComboBox.Name = "channelComboBox";
            this.channelComboBox.Size = new System.Drawing.Size(121, 21);
            this.channelComboBox.TabIndex = 2;
            this.channelComboBox.SelectedIndexChanged += new System.EventHandler(this.channelComboBox_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(48, 315);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(51, 38);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // terminateBtn
            // 
            this.terminateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.terminateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminateBtn.Image = ((System.Drawing.Image)(resources.GetObject("terminateBtn.Image")));
            this.terminateBtn.Location = new System.Drawing.Point(221, 315);
            this.terminateBtn.Name = "terminateBtn";
            this.terminateBtn.Size = new System.Drawing.Size(51, 38);
            this.terminateBtn.TabIndex = 4;
            this.terminateBtn.UseVisualStyleBackColor = false;
            this.terminateBtn.Click += new System.EventHandler(this.terminateBtn_Click);
            // 
            // secretMsgRichTxtBox
            // 
            this.secretMsgRichTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.secretMsgRichTxtBox.Location = new System.Drawing.Point(48, 195);
            this.secretMsgRichTxtBox.Name = "secretMsgRichTxtBox";
            this.secretMsgRichTxtBox.ReadOnly = true;
            this.secretMsgRichTxtBox.Size = new System.Drawing.Size(224, 96);
            this.secretMsgRichTxtBox.TabIndex = 6;
            this.secretMsgRichTxtBox.Text = "";
            this.secretMsgRichTxtBox.Visible = false;
            // 
            // channelsLbl
            // 
            this.channelsLbl.AutoSize = true;
            this.channelsLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.channelsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelsLbl.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelsLbl.Location = new System.Drawing.Point(148, 39);
            this.channelsLbl.Name = "channelsLbl";
            this.channelsLbl.Size = new System.Drawing.Size(60, 14);
            this.channelsLbl.TabIndex = 7;
            this.channelsLbl.Text = "Channels:";
            // 
            // secretMsgLbl
            // 
            this.secretMsgLbl.AutoSize = true;
            this.secretMsgLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.secretMsgLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretMsgLbl.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretMsgLbl.Location = new System.Drawing.Point(45, 178);
            this.secretMsgLbl.Name = "secretMsgLbl";
            this.secretMsgLbl.Size = new System.Drawing.Size(94, 14);
            this.secretMsgLbl.TabIndex = 8;
            this.secretMsgLbl.Text = "Secret Message:";
            this.secretMsgLbl.Visible = false;
            // 
            // Reciever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 380);
            this.Controls.Add(this.secretMsgLbl);
            this.Controls.Add(this.channelsLbl);
            this.Controls.Add(this.secretMsgRichTxtBox);
            this.Controls.Add(this.terminateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.channelComboBox);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reciever";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Reciever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ComboBox channelComboBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button terminateBtn;
        private System.Windows.Forms.RichTextBox secretMsgRichTxtBox;
        private System.Windows.Forms.Label channelsLbl;
        private System.Windows.Forms.Label secretMsgLbl;
    }
}

