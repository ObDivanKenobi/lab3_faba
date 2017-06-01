namespace lab3_faba
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarPhi = new System.Windows.Forms.TrackBar();
            this.trackBarPsi = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveLight = new System.Windows.Forms.Button();
            this.buttonAddLight = new System.Windows.Forms.Button();
            this.listBoxLights = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPsi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGlControl
            // 
            this.openGlControl.AccumBits = ((byte)(0));
            this.openGlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGlControl.AutoCheckErrors = false;
            this.openGlControl.AutoFinish = false;
            this.openGlControl.AutoMakeCurrent = true;
            this.openGlControl.AutoSwapBuffers = true;
            this.openGlControl.BackColor = System.Drawing.Color.Black;
            this.openGlControl.ColorBits = ((byte)(32));
            this.openGlControl.DepthBits = ((byte)(16));
            this.openGlControl.Location = new System.Drawing.Point(12, 12);
            this.openGlControl.Name = "openGlControl";
            this.openGlControl.Size = new System.Drawing.Size(464, 429);
            this.openGlControl.StencilBits = ((byte)(0));
            this.openGlControl.TabIndex = 0;
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRadius.Location = new System.Drawing.Point(6, 32);
            this.trackBarRadius.Maximum = 9;
            this.trackBarRadius.Minimum = 1;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(239, 45);
            this.trackBarRadius.TabIndex = 7;
            this.trackBarRadius.Value = 5;
            this.trackBarRadius.ValueChanged += new System.EventHandler(this.Draw);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Радиус сферы";
            // 
            // trackBarPhi
            // 
            this.trackBarPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPhi.Location = new System.Drawing.Point(12, 447);
            this.trackBarPhi.Maximum = 18;
            this.trackBarPhi.Minimum = -18;
            this.trackBarPhi.Name = "trackBarPhi";
            this.trackBarPhi.Size = new System.Drawing.Size(464, 45);
            this.trackBarPhi.TabIndex = 8;
            this.trackBarPhi.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPhi.ValueChanged += new System.EventHandler(this.Draw);
            // 
            // trackBarPsi
            // 
            this.trackBarPsi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPsi.Location = new System.Drawing.Point(482, 12);
            this.trackBarPsi.Maximum = 18;
            this.trackBarPsi.Minimum = -18;
            this.trackBarPsi.Name = "trackBarPsi";
            this.trackBarPsi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPsi.Size = new System.Drawing.Size(45, 429);
            this.trackBarPsi.TabIndex = 9;
            this.trackBarPsi.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPsi.ValueChanged += new System.EventHandler(this.Draw);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRemoveLight);
            this.groupBox1.Controls.Add(this.buttonAddLight);
            this.groupBox1.Controls.Add(this.listBoxLights);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarRadius);
            this.groupBox1.Location = new System.Drawing.Point(533, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 480);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // buttonRemoveLight
            // 
            this.buttonRemoveLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveLight.Location = new System.Drawing.Point(191, 353);
            this.buttonRemoveLight.Name = "buttonRemoveLight";
            this.buttonRemoveLight.Size = new System.Drawing.Size(50, 23);
            this.buttonRemoveLight.TabIndex = 11;
            this.buttonRemoveLight.Text = "‒";
            this.buttonRemoveLight.UseVisualStyleBackColor = true;
            this.buttonRemoveLight.Click += new System.EventHandler(this.buttonRemoveLight_Click);
            // 
            // buttonAddLight
            // 
            this.buttonAddLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddLight.Location = new System.Drawing.Point(9, 353);
            this.buttonAddLight.Name = "buttonAddLight";
            this.buttonAddLight.Size = new System.Drawing.Size(50, 23);
            this.buttonAddLight.TabIndex = 10;
            this.buttonAddLight.Text = "+";
            this.buttonAddLight.UseVisualStyleBackColor = true;
            this.buttonAddLight.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxLights
            // 
            this.listBoxLights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLights.FormattingEnabled = true;
            this.listBoxLights.Location = new System.Drawing.Point(9, 83);
            this.listBoxLights.Name = "listBoxLights";
            this.listBoxLights.Size = new System.Drawing.Size(232, 264);
            this.listBoxLights.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Освещение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarPsi);
            this.Controls.Add(this.trackBarPhi);
            this.Controls.Add(this.openGlControl);
            this.Name = "Form1";
            this.Text = "Lab3 faba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPsi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openGlControl;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarPhi;
        private System.Windows.Forms.TrackBar trackBarPsi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveLight;
        private System.Windows.Forms.Button buttonAddLight;
        private System.Windows.Forms.ListBox listBoxLights;
        private System.Windows.Forms.Label label1;
    }
}

