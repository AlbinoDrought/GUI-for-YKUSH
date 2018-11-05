namespace GhettoYkushGui
{
    partial class ControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.chkPortOne = new System.Windows.Forms.CheckBox();
            this.chkPortTwo = new System.Windows.Forms.CheckBox();
            this.chkPortThree = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPortOne = new System.Windows.Forms.TextBox();
            this.txtPortTwo = new System.Windows.Forms.TextBox();
            this.txtPortThree = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPortOne
            // 
            this.chkPortOne.AutoSize = true;
            this.chkPortOne.Location = new System.Drawing.Point(12, 12);
            this.chkPortOne.Name = "chkPortOne";
            this.chkPortOne.Size = new System.Drawing.Size(54, 17);
            this.chkPortOne.TabIndex = 0;
            this.chkPortOne.Text = "Port 1";
            this.chkPortOne.UseVisualStyleBackColor = true;
            this.chkPortOne.CheckedChanged += new System.EventHandler(this.chkPortOne_CheckedChanged);
            // 
            // chkPortTwo
            // 
            this.chkPortTwo.AutoSize = true;
            this.chkPortTwo.Location = new System.Drawing.Point(12, 35);
            this.chkPortTwo.Name = "chkPortTwo";
            this.chkPortTwo.Size = new System.Drawing.Size(54, 17);
            this.chkPortTwo.TabIndex = 1;
            this.chkPortTwo.Text = "Port 2";
            this.chkPortTwo.UseVisualStyleBackColor = true;
            this.chkPortTwo.CheckedChanged += new System.EventHandler(this.chkPortTwo_CheckedChanged);
            // 
            // chkPortThree
            // 
            this.chkPortThree.AutoSize = true;
            this.chkPortThree.Location = new System.Drawing.Point(12, 58);
            this.chkPortThree.Name = "chkPortThree";
            this.chkPortThree.Size = new System.Drawing.Size(54, 17);
            this.chkPortThree.TabIndex = 2;
            this.chkPortThree.Text = "Port 3";
            this.chkPortThree.UseVisualStyleBackColor = true;
            this.chkPortThree.CheckedChanged += new System.EventHandler(this.chkPortThree_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::GhettoYkushGui.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPortOne
            // 
            this.txtPortOne.Location = new System.Drawing.Point(12, 12);
            this.txtPortOne.Name = "txtPortOne";
            this.txtPortOne.Size = new System.Drawing.Size(84, 20);
            this.txtPortOne.TabIndex = 4;
            this.txtPortOne.Visible = false;
            // 
            // txtPortTwo
            // 
            this.txtPortTwo.Location = new System.Drawing.Point(12, 33);
            this.txtPortTwo.Name = "txtPortTwo";
            this.txtPortTwo.Size = new System.Drawing.Size(84, 20);
            this.txtPortTwo.TabIndex = 5;
            this.txtPortTwo.Visible = false;
            // 
            // txtPortThree
            // 
            this.txtPortThree.Location = new System.Drawing.Point(12, 54);
            this.txtPortThree.Name = "txtPortThree";
            this.txtPortThree.Size = new System.Drawing.Size(84, 20);
            this.txtPortThree.TabIndex = 6;
            this.txtPortThree.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(102, 52);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "YKUSH";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 81);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPortThree);
            this.Controls.Add(this.txtPortTwo);
            this.Controls.Add(this.txtPortOne);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkPortThree);
            this.Controls.Add(this.chkPortTwo);
            this.Controls.Add(this.chkPortOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 120);
            this.Name = "ControlForm";
            this.Text = "YKUSH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.ControlForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPortOne;
        private System.Windows.Forms.CheckBox chkPortTwo;
        private System.Windows.Forms.CheckBox chkPortThree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPortOne;
        private System.Windows.Forms.TextBox txtPortTwo;
        private System.Windows.Forms.TextBox txtPortThree;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

