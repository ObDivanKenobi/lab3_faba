using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_faba
{
    public partial class FormLight : Form
    {
        private float[] rgb = new float[3];
        private float[] xyzw = new float[4];

        public FormLight()
        {
            InitializeComponent();
            TextBoxR.Text = rgb[0].ToString();
            TextBoxG.Text = rgb[1].ToString();
            TextBoxB.Text = rgb[2].ToString();
            TextBoxX.Text = xyzw[0].ToString();
            TextBoxY.Text = xyzw[1].ToString();
            TextBoxZ.Text = xyzw[2].ToString();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                rgb[0] = TextBoxR.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxR.Text);
                rgb[1] = TextBoxG.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxG.Text);
                rgb[2] = TextBoxB.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxB.Text);
                xyzw[0] = TextBoxX.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxX.Text);
                xyzw[1] = TextBoxY.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxY.Text);
                xyzw[2] = TextBoxZ.Text.Trim() == "" ? 0 : float.Parse(this.TextBoxZ.Text);
                xyzw[3] = 1;

                bool correct = true;
                foreach (float f in rgb)
                    correct = correct && CorrectColor(f);
                if (correct)
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Значения введены некорректно ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверте ввод чисел ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Возвращает цвет
        public float[] RGB
        {
            get { return rgb; }
        }

        // Возвращает направление
        public float[] XYZ
        {
            get { return xyzw; }
        }

        private static bool CorrectColor(float value)
        {
            return value >= 0 && value <= 1;
        }

        private static bool CorrectDir(float value)
        {
            return value >= -1 && value <= 1;
        }
    }
}
