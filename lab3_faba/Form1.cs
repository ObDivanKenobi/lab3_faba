using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace lab3_faba
{
    /*
     * f - шар заданного диаметра
     * a - непрозрачная фигура
     * b - многоточечное освещение с заданными положениями источника
     * a - параллельная проекция
     */
    public partial class Form1 : Form
    {
        const int max_lights = 8;
        const int pixelsInCU = 50;
        const int n = 10; //множитель числа полигонов в ярусе

        List<float[]> lightColors = new List<float[]>();
        List<float[]> lightCoords = new List<float[]>();

        Point3D camera = new Point3D(0, 0, 50);

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (lightColors.Count == 8)
            {
                MessageBox.Show("Более 8 источников света не поддерживается.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormLight f = new FormLight();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.Cancel)
                return;

            lightColors.Add(f.RGB);
            lightCoords.Add(f.XYZ);
            listBoxLights.Items.Add($"({f.XYZ[0]}, {f.XYZ[1]}, {f.XYZ[2]}) - [{f.RGB[0]}, {f.RGB[1]}, {f.RGB[2]}]");

            f.Close();
            SetLights();
        }

        public Form1()
        {
            InitializeComponent();
            lightColors.Add(new float[] { 1f, 1f, 1f });
            lightCoords.Add(new float[] { 300, 300, 300, 1 });
            listBoxLights.Items.Add($"({lightCoords[0][0]}, {lightCoords[0][1]}, {lightCoords[0][2]}) - [{lightColors[0][0]}, {lightColors[0][1]}, {lightColors[0][2]}]");
            openGlControl.InitializeContexts();
        }

        private void buttonRemoveLight_Click(object sender, EventArgs e)
        {
            if (listBoxLights.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите источник света, который нужно удалить.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = listBoxLights.SelectedIndex;
            listBoxLights.Items.RemoveAt(i);
            lightColors.RemoveAt(i);
            lightCoords.RemoveAt(i);

            SetLights();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация Glut
            Glut.glutInit();
            //инициализация режима экрана
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // отчистка окна 
            Gl.glClearColor(1, 1, 1, 1);

            // установка порта вывода 
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            // активация проекционной матрицы
            Gl.glMatrixMode(Gl.GL_PROJECTION);

            //установка экрана в центр с координатами 0,0,0
            Gl.glLoadIdentity();

            //установка проекции
            Gl.glOrtho(-50, 50, -50, 50, -50, 50);
            //Glu.gluOrtho2D(0, openGlControl.Width, 0, openGlControl.Height);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света) 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_NORMALIZE);

            //инициализация начального источника света
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, lightCoords[0]);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, lightColors[0]);
            Gl.glEnable(Gl.GL_LIGHT0);
        }

        private void SetLights()
        {
            for (int i = 0; i < max_lights; ++i)
            {
                if (i >= lightColors.Count)
                {
                    Gl.glDisable(Gl.GL_LIGHT0 + i);
                    continue;
                }

                //устанавливаем позицию источника света и его цвет
                Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_POSITION, lightCoords[i]);
                Gl.glLightfv(Gl.GL_LIGHT0 + i, Gl.GL_DIFFUSE, lightColors[i]);
                Gl.glEnable(Gl.GL_LIGHT0 + i);
            }

            DrawScene();
        }

        private void Draw(object sender, EventArgs e)
        {
            DrawScene();
        }

        private void DrawScene()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            //устанавливаем проекцию
            Gl.glOrtho(-50, 50, -50, 50, -50, 50);

            Gl.glPushMatrix();
            //вращаем камеру
            Gl.glRotated(trackBarPhi.Value * 10, 0, 1, 0);
            Gl.glRotated(trackBarPsi.Value * 10, 1, 0, 1);

            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            // рисуем сферу с помощью библиотеки FreeGLUT 
            //Glut.glutSolidSphere(trackBarRadius.Value*5, 32, 32);

            //изобретаем велосипед и рисуем сферу руками
            List<Point3D> points = new List<Point3D>();
            int radius = trackBarRadius.Value * 5;
            int smoothness = radius * n;
            double horangle = 0;                    
            double verangle = Math.PI / smoothness;
            points.Add(new Point3D(0, 0, radius));
            for (int i = 1; i < smoothness; i++)
            {
                for (int j = 0; j < smoothness; j++)
                {
                    horangle = 2 * (j + 1) * Math.PI / smoothness; // увеличение горизонтального угла
                    points.Add(new Point3D(
                        radius * Math.Sin(verangle) * Math.Cos(horangle),
                        radius * Math.Sin(verangle) * Math.Sin(horangle),
                        radius * Math.Cos(verangle)));
                }
                verangle = (i + 1) * Math.PI / smoothness; // увеличение вертикального угла
            }
            points.Add(new Point3D(0, 0, -radius));

            for(int i = 0; i < points.Count; ++i)
            {
                //последний полигон в ярусе
                if (i == smoothness - 1)
                {
                    Gl.glBegin(Gl.GL_QUADS);
                    Gl.glNormal3d(points[0].X, 0, points[0].Z);
                    Gl.glVertex3d(points[0].X, points[0].Y, points[0].Z);
                    Gl.glNormal3d(points[1].X, 0, points[1].Z);
                    Gl.glVertex3d(points[1].X, points[1].Y, points[1].Z);
                    Gl.glNormal3d(points[smoothness].X, 0, points[smoothness].Z);
                    Gl.glVertex3d(points[smoothness].X, points[smoothness].Y, points[smoothness].Z);
                    Gl.glNormal3d(points[0].X, 0, points[0].Z);
                    Gl.glVertex3d(points[0].X, points[0].Y, points[0].Z);
                    Gl.glEnd();
                }
                else if (i < smoothness)
                {
                    Gl.glBegin(Gl.GL_QUADS);
                    Gl.glNormal3d(points[0].X, 0, points[0].Z);
                    Gl.glVertex3d(points[0].X, points[0].Y, points[0].Z);
                    Gl.glNormal3d(points[i + 2].X, 0, points[i + 2].Z);
                    Gl.glVertex3d(points[i + 2].X, points[i + 2].Y, points[i + 2].Z);
                    Gl.glNormal3d(points[i + 1].X, 0, points[i + 1].Z);
                    Gl.glVertex3d(points[i + 1].X, points[i + 1].Y, points[i + 1].Z);
                    Gl.glNormal3d(points[0].X, 0, points[0].Z);
                    Gl.glVertex3d(points[0].X, points[0].Y, points[0].Z);
                    Gl.glEnd();
                }
                else if (i == smoothness * smoothness - smoothness)
                {
                    Gl.glBegin(Gl.GL_TRIANGLES);
                    Gl.glNormal3d(points[smoothness * smoothness - smoothness].X, 0, points[smoothness * smoothness - smoothness].Z);
                    Gl.glVertex3d(points[smoothness * smoothness - smoothness].X, points[smoothness * smoothness - smoothness].Y, points[smoothness * smoothness - smoothness].Z);
                    Gl.glNormal3d(points[smoothness * smoothness - 2 * smoothness + 1].X, 0, points[smoothness * smoothness - 2 * smoothness + 1].Z);
                    Gl.glVertex3d(points[smoothness * smoothness - 2 * smoothness + 1].X, points[smoothness * smoothness - 2 * smoothness + 1].Y, points[smoothness * smoothness - 2 * smoothness + 1].Z);
                    Gl.glNormal3d(points[smoothness * smoothness - smoothness + 1].X, 0, points[smoothness * smoothness - smoothness + 1].Z);
                    Gl.glVertex3d(points[smoothness * smoothness - smoothness + 1].X, points[smoothness * smoothness - smoothness + 1].Y, points[smoothness * smoothness - smoothness + 1].Z);
                    Gl.glEnd();
                }
                else if (i >= (smoothness - 1) * smoothness)
                {
                    Gl.glBegin(Gl.GL_TRIANGLES);
                    Gl.glNormal3d(points[i - smoothness].X, 0, points[i - smoothness].Z);
                    Gl.glVertex3d(points[i - smoothness].X, points[i - smoothness].Y, points[i - smoothness].Z);
                    Gl.glNormal3d(points[i - smoothness + 1].X, 0, points[i - smoothness + 1].Z);
                    Gl.glVertex3d(points[i - smoothness + 1].X, points[i - smoothness + 1].Y, points[i - smoothness + 1].Z);
                    Gl.glNormal3d(points[smoothness * smoothness - smoothness + 1].X, 0, points[smoothness * smoothness - smoothness + 1].Z);
                    Gl.glVertex3d(points[smoothness * smoothness - smoothness + 1].X, points[smoothness * smoothness - smoothness + 1].Y, points[smoothness * smoothness - smoothness + 1].Z);
                    Gl.glEnd();
                }
                else if (i % smoothness == 0)
                {
                    Gl.glBegin(Gl.GL_QUADS);
                    Gl.glNormal3d(points[i].X, 0, points[i].Z);
                    Gl.glVertex3d(points[i].X, points[i].Y, points[i].Z);
                    Gl.glNormal3d(points[i - smoothness + 1].X, 0, points[i - smoothness + 1].Z);
                    Gl.glVertex3d(points[i - smoothness + 1].X, points[i - smoothness + 1].Y, points[i - smoothness + 1].Z);
                    Gl.glNormal3d(points[i + 1].X, 0, points[i + 1].Z);
                    Gl.glVertex3d(points[i + 1].X, points[i + 1].Y, points[i + 1].Z);
                    Gl.glNormal3d(points[i + smoothness].X, 0, points[i + smoothness].Z);
                    Gl.glVertex3d(points[i + smoothness].X, points[i + smoothness].Y, points[i + smoothness].Z);
                    Gl.glEnd();
                }
                else
                {
                    Gl.glBegin(Gl.GL_QUADS);
                    Gl.glNormal3d(points[i - smoothness].X, 0, points[i - smoothness].Z);
                    Gl.glVertex3d(points[i - smoothness].X, points[i - smoothness].Y, points[i - smoothness].Z);
                    Gl.glNormal3d(points[i - smoothness + 1].X, 0, points[i - smoothness + 1].Z);
                    Gl.glVertex3d(points[i - smoothness + 1].X, points[i - smoothness + 1].Y, points[i - smoothness + 1].Z);
                    Gl.glNormal3d(points[i + 1].X, 0, points[i + 1].Z);
                    Gl.glVertex3d(points[i + 1].X, points[i + 1].Y, points[i + 1].Z);
                    Gl.glNormal3d(points[i].X, 0, points[i].Z);
                    Gl.glVertex3d(points[i].X, points[i].Y, points[i].Z);
                    Gl.glEnd();
                }
            }

            Gl.glPopMatrix();
            Gl.glFlush();

            openGlControl.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene();
        }
    }
}