namespace AdventureGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputButton1 = new System.Windows.Forms.Button();
            this.inputButton2 = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.ButtonTimerLeft = new System.Windows.Forms.Timer(this.components);
            this.ButtonTimerRight = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AdventureGame.Properties.Resources.crtfilter1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 799);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Rubber Biscuit", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(40, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(847, 78);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "START GAME";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // inputButton1
            // 
            this.inputButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputButton1.BackColor = System.Drawing.Color.Black;
            this.inputButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton1.Font = new System.Drawing.Font("Rubber Biscuit", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton1.ForeColor = System.Drawing.Color.White;
            this.inputButton1.Location = new System.Drawing.Point(144, 682);
            this.inputButton1.Name = "inputButton1";
            this.inputButton1.Size = new System.Drawing.Size(253, 86);
            this.inputButton1.TabIndex = 2;
            this.inputButton1.Text = "YES";
            this.inputButton1.UseVisualStyleBackColor = false;
            this.inputButton1.Click += new System.EventHandler(this.inputButton1_Click);
            this.inputButton1.MouseLeave += new System.EventHandler(this.inputButton1_MouseLeave);
            this.inputButton1.MouseHover += new System.EventHandler(this.inputButton1_MouseHover);
            // 
            // inputButton2
            // 
            this.inputButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton2.BackColor = System.Drawing.Color.Black;
            this.inputButton2.Font = new System.Drawing.Font("Rubber Biscuit", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton2.ForeColor = System.Drawing.Color.White;
            this.inputButton2.Location = new System.Drawing.Point(537, 682);
            this.inputButton2.Name = "inputButton2";
            this.inputButton2.Size = new System.Drawing.Size(253, 86);
            this.inputButton2.TabIndex = 3;
            this.inputButton2.Text = "NO";
            this.inputButton2.UseVisualStyleBackColor = false;
            this.inputButton2.Click += new System.EventHandler(this.inputButton2_Click);
            this.inputButton2.MouseLeave += new System.EventHandler(this.inputButton2_MouseLeave);
            this.inputButton2.MouseHover += new System.EventHandler(this.inputButton2_MouseHover);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Transparent;
            this.outputText.Font = new System.Drawing.Font("Rubber Biscuit", 12F, System.Drawing.FontStyle.Bold);
            this.outputText.ForeColor = System.Drawing.Color.White;
            this.outputText.Location = new System.Drawing.Point(70, 48);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(766, 87);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "output text";
            this.outputText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonTimerLeft
            // 
            this.ButtonTimerLeft.Interval = 10;
            this.ButtonTimerLeft.Tick += new System.EventHandler(this.ButtonTimerLeft_Tick);
            // 
            // ButtonTimerRight
            // 
            this.ButtonTimerRight.Interval = 10;
            this.ButtonTimerRight.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.BackgroundImage = global::AdventureGame.Properties.Resources.town2edit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 799);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputButton2);
            this.Controls.Add(this.inputButton1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A Nighttime Walk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox crtFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button inputButton1;
        private System.Windows.Forms.Button inputButton2;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Timer ButtonTimerLeft;
        private System.Windows.Forms.Timer ButtonTimerRight;
    }
}

