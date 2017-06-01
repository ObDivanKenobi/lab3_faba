namespace lab3_faba
{
    partial class FormLight
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
            this.LabelAboutColor = new System.Windows.Forms.Label();
            this.TextBoxZ = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.LabelDir = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxG = new System.Windows.Forms.TextBox();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.LabelColor = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAboutColor
            // 
            this.LabelAboutColor.AutoSize = true;
            this.LabelAboutColor.Location = new System.Drawing.Point(46, 9);
            this.LabelAboutColor.Name = "LabelAboutColor";
            this.LabelAboutColor.Size = new System.Drawing.Size(282, 13);
            this.LabelAboutColor.TabIndex = 20;
            this.LabelAboutColor.Text = "Значения цветов должны принадлежать отрезку [0; 1]";
            // 
            // TextBoxZ
            // 
            this.TextBoxZ.Location = new System.Drawing.Point(211, 57);
            this.TextBoxZ.Name = "TextBoxZ";
            this.TextBoxZ.Size = new System.Drawing.Size(41, 20);
            this.TextBoxZ.TabIndex = 19;
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(164, 57);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(41, 20);
            this.TextBoxY.TabIndex = 18;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(117, 57);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(41, 20);
            this.TextBoxX.TabIndex = 17;
            // 
            // LabelDir
            // 
            this.LabelDir.AutoSize = true;
            this.LabelDir.Location = new System.Drawing.Point(12, 60);
            this.LabelDir.Name = "LabelDir";
            this.LabelDir.Size = new System.Drawing.Size(93, 13);
            this.LabelDir.TabIndex = 16;
            this.LabelDir.Text = "Координаты XYZ";
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(211, 31);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(41, 20);
            this.TextBoxB.TabIndex = 15;
            // 
            // TextBoxG
            // 
            this.TextBoxG.Location = new System.Drawing.Point(164, 31);
            this.TextBoxG.Name = "TextBoxG";
            this.TextBoxG.Size = new System.Drawing.Size(41, 20);
            this.TextBoxG.TabIndex = 14;
            // 
            // TextBoxR
            // 
            this.TextBoxR.Location = new System.Drawing.Point(117, 31);
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.Size = new System.Drawing.Size(41, 20);
            this.TextBoxR.TabIndex = 13;
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Location = new System.Drawing.Point(12, 34);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(58, 13);
            this.LabelColor.TabIndex = 12;
            this.LabelColor.Text = "Цвет RGB";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(271, 98);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 23;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(12, 98);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 22;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 129);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.LabelAboutColor);
            this.Controls.Add(this.TextBoxZ);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.LabelDir);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxG);
            this.Controls.Add(this.TextBoxR);
            this.Controls.Add(this.LabelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLight";
            this.Text = "FormLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelAboutColor;
        private System.Windows.Forms.TextBox TextBoxZ;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.Label LabelDir;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxG;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
    }
}