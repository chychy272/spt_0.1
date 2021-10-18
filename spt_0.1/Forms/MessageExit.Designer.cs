
namespace spt_0._1.Forms
{
    partial class MessageExit
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
            this.barpanel = new System.Windows.Forms.Panel();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MsgExitButton = new FontAwesome.Sharp.IconButton();
            this.barpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barpanel
            // 
            this.barpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.barpanel.Controls.Add(this.MsgExitButton);
            this.barpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barpanel.Location = new System.Drawing.Point(0, 0);
            this.barpanel.Name = "barpanel";
            this.barpanel.Size = new System.Drawing.Size(450, 21);
            this.barpanel.TabIndex = 0;
            // 
            // ButtonYes
            // 
            this.ButtonYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ButtonYes.FlatAppearance.BorderSize = 0;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.Location = new System.Drawing.Point(114, 105);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(75, 25);
            this.ButtonYes.TabIndex = 3;
            this.ButtonYes.Text = "Yes";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to close the program?";
            // 
            // ButtonNo
            // 
            this.ButtonNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonNo.FlatAppearance.BorderSize = 0;
            this.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ButtonNo.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.Location = new System.Drawing.Point(267, 105);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(75, 25);
            this.ButtonNo.TabIndex = 4;
            this.ButtonNo.Text = "No";
            this.ButtonNo.UseVisualStyleBackColor = false;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 149);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(448, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 149);
            this.panel3.TabIndex = 7;
            // 
            // MsgExitButton
            // 
            this.MsgExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MsgExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MsgExitButton.FlatAppearance.BorderSize = 0;
            this.MsgExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.MsgExitButton.IconColor = System.Drawing.Color.White;
            this.MsgExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgExitButton.IconSize = 16;
            this.MsgExitButton.Location = new System.Drawing.Point(434, 0);
            this.MsgExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.MsgExitButton.Name = "MsgExitButton";
            this.MsgExitButton.Size = new System.Drawing.Size(16, 21);
            this.MsgExitButton.TabIndex = 5;
            this.MsgExitButton.UseVisualStyleBackColor = true;
            this.MsgExitButton.Click += new System.EventHandler(this.MsgExitButton_Click);
            // 
            // MessageExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 172);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageExit";
            this.barpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barpanel;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNo;
        private FontAwesome.Sharp.IconButton MsgExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}