using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp_LR_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<PointF> pointsList;
        public List<PointF> pointsListCopy;
        public List<TextBox> tbList;

        public Graphics graphics;
        public Pen pen;

        public float x = -1;
        public float y = -1;
        public bool flag = false;

        public float[,] matrix;

        public Form()
        {
            InitializeComponent();

            pen = new Pen(Color.Black, 7);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            graphics = panelDrawing.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pointsList = new List<PointF>();
            pointsListCopy = new List<PointF>();

            button_reset.Enabled = false;
        }


        private void PanelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag && e.X != -1 && e.Y != -1 && e.X <= panelDrawing.Width && e.Y <= panelDrawing.Height)
            {
                graphics.DrawLine(pen, new PointF(x, y), e.Location);
                x = e.X;
                y = e.Y;
                pointsList.Add(new PointF(x, y));
            }
            label_coordX.Text = "X: " + e.X.ToString();
            label_coordY.Text = "Y: " + e.Y.ToString();
        }

        private void PanelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            pointsList.Clear();
            graphics.Clear(panelDrawing.BackColor);
            if (!flag)
            {
                flag = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void PanelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag) flag = false;

            pointsList = DouglasPeuckerReduction(pointsList, (int)numericUpDownEpsilonValue.Value); // Вычисление вершин упрощённой ломаной.

            Draw(pointsList); // Отрисовка упрощённой ломаной.

            RefreshTable(pointsList); // Обновление данных в таблице вершин.

            matrix = new float[,] { { 1.0f, 0.0f, 0.0f }, { 0.0f, 1.0f, 0.0f }, { 0.0f, 0.0f, 1.0f } }; // Для отрисовки единичной матрицы.
            RefreshMatrix(); // Отобразить актуальные данные в матрице.

            pointsListCopy = new List<PointF>(pointsList); // Копия набора изначальных точек для реализации сброса кривой.
        }


        private void RefreshTable(List<PointF> points)
        {
            dataGridView_coords.Rows.Clear(); // Очистить таблицу.
            for (var i = 0; i < points.Count(); i++)
            {
                dataGridView_coords.Rows.Add();
                dataGridView_coords.Rows[i].Cells[0].Value = points[i].X;
                dataGridView_coords.Rows[i].Cells[1].Value = points[i].Y;
            }
        }

        private void RefreshMatrix()
        {
            for (var i = 0; i < 3; i++)
                for (var j = 0; j < 3; j++)
                    tbList[3 * i + j].Text = matrix[i, j].ToString();
        }


        // Перевод вершин ломаной из экранных координат в декартовы координаты.
        private List<PointF> CoordsImageToCalc(List<PointF> points)
        {
            for (var i = 0; i < points.Count(); i++)
                points[i] = new PointF(points[i].X - (panelDrawing.Width / 2), (panelDrawing.Height / 2) - points[i].Y);
            return points;
        }

        // Перевод вершин ломаной из декартовых координат в экранные координаты.
        private List<PointF> CoordsCalcToImage(List<PointF> points)
        {
            for (var i = 0; i < points.Count(); i++)
                points[i] = new PointF(points[i].X + (panelDrawing.Width / 2), (panelDrawing.Height / 2) - points[i].Y);
            return points;
        }


        private void Draw(List<PointF> points)
        {
            graphics.Clear(panelDrawing.BackColor);
            for (var i = 0; i < points.Count() - 1; i++)
                graphics.DrawLine(pen, (float)points[i].X, (float)points[i].Y, (float)points[i + 1].X, (float)points[i + 1].Y);
        }


        // -----------------Заполнение матриц--------------------
        private void FillMoveMatrix(float x, float y)
        {
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[0, 2] = x;

            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = y;

            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
        }

        private void FillRotateMatrix(float rotation)
        {
            matrix[0, 0] = (float)Math.Cos(rotation);
            matrix[0, 1] = (float)-Math.Sin(rotation);
            matrix[0, 2] = 0;

            matrix[1, 0] = (float)Math.Sin(rotation);
            matrix[1, 1] = (float)Math.Cos(rotation);
            matrix[1, 2] = 0;

            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
        }

        private void FillScaleMatrix(float x, float y)
        {
            matrix[0, 0] = x;
            matrix[0, 1] = 0;
            matrix[0, 2] = 0;

            matrix[1, 0] = 0;
            matrix[1, 1] = y;
            matrix[1, 2] = 0;

            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
        }
        // ------------------------------------------------------


        // -----------------Афинные преобразования---------------
        private List<PointF> Move_(float x, float y, List<PointF> points)
        {
            FillMoveMatrix(x, y);

            float[] vector;
            for (var i = 0; i < points.Count(); i++)
            {
                vector = new float[3];
                vector[0] = points[i].X + matrix[0, 2];
                vector[1] = points[i].Y + matrix[1, 2];
                vector[2] = 1;

                points[i] = new PointF(vector[0], vector[1]);
            }

            return points;
        }

        private List<PointF> Rotate(float angle, List<PointF> points)
        {
            FillRotateMatrix((float)(-Math.PI * angle / 180.0f));

            float[] vector;
            for (var i = 0; i < points.Count(); i++)
            {
                vector = new float[3];
                vector[0] = points[i].X * matrix[0, 0] + points[i].Y * matrix[0, 1];
                vector[1] = points[i].X * matrix[1, 0] + points[i].Y * matrix[1, 1];
                vector[2] = 1;

                points[i] = new PointF(vector[0], vector[1]);
            }
            return points;
        }

        private List<PointF> Scale(float x, float y, List<PointF> points)
        {
            FillScaleMatrix(x, y);

            float[] vector;
            for (var i = 0; i < points.Count(); i++)
            {
                vector = new float[3];
                vector[0] = points[i].X * matrix[0, 0];
                vector[1] = points[i].Y * matrix[1, 1];
                vector[2] = 1;

                points[i] = new PointF(vector[0], vector[1]);
            }

            return points;
        }
        // --------------------------------------------------------------


        // -----------------Кнопки---------------------------------------
        private void Button_apply_Click(object sender, EventArgs e)
        {
            button_reset.Enabled = true;

            pointsList = CoordsImageToCalc(pointsList);

            if (radioButton_transfer.Checked) // Перенос.
            {
                if (int.Parse(numericUpDown_X.Text) < -500 && int.Parse(numericUpDown_X.Text) > 500)
                {
                    MessageBox.Show("Значение X должно быть в диапазоне [-500, 500]", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown_X.Focus();
                    return;
                }
                if (int.Parse(numericUpDown_Y.Text) < -500 && int.Parse(numericUpDown_Y.Text) > 500)
                {
                    MessageBox.Show("Значение Y должно быть в диапазоне [-500, 500]", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown_Y.Focus();
                    return;
                }

                pointsList = Move_((float)numericUpDown_X.Value, (float)numericUpDown_Y.Value, pointsList);
            }

            else if (radioButton_rotation.Checked) // Поворот.
            {
                pointsList = Rotate((float)numericUpDown_angle.Value, pointsList);
            }

            else if (radioButton_scaling.Checked) // Масштабирование.
            {
                if (int.Parse(textBox_alfa.Text) <= 0 && int.Parse(textBox_alfa.Text) > 10)
                {
                    MessageBox.Show("Значение альфа должно быть в диапазоне [1, 10]", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_alfa.Focus();
                }
                if (int.Parse(textBox_beta.Text) <= 0 && int.Parse(textBox_beta.Text) > 10)
                {
                    MessageBox.Show("Значение бета должно быть в диапазоне [1, 10]", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_beta.Focus();
                }

                pointsList = Scale(float.Parse(textBox_alfa.Text), float.Parse(textBox_beta.Text), pointsList);
            }
            else
            {
                MessageBox.Show("Не выбрано преобразование!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button_apply.Enabled = false;
                return;
            }

            pointsList = CoordsCalcToImage(pointsList);
            Draw(pointsList); // Отрисовать кривую после преобразования.
            RefreshTable(pointsList); // Обновить данные в таблице.
            RefreshMatrix(); // Обновить данные в матрице.
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            button_reset.Enabled = false;

            Draw(pointsListCopy); // Отрисовать изначальную кривую.
            RefreshTable(pointsListCopy); // Отобразить изначаьные вершины ломаной.

            matrix = new float[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } }; // Задать единичную матрицу.
            RefreshMatrix(); // Обновить данные в матрице.

            pointsList = new List<PointF>(pointsListCopy); // Сделать вершины изначальной ломаной вершинами для дальнейшей работы. 
        }
        // --------------------------------------------------------------


        // -----------------Алгоритм упрощения ломаной--------------------
        public static List<PointF> DouglasPeuckerReduction (List<PointF> points, double epsilon)
        {
            if (points == null || points.Count < 3) return points;

            int firstPoint = 0;
            int lastPoint = points.Count - 1;
            List<int> pointIndexsToKeep = new List<int>
            {
                //Add the first and last index to the keepers
                firstPoint,
                lastPoint
            };

            //The first and the last point cannot be the same
            while (points[firstPoint].Equals(points[lastPoint]))
            {
                lastPoint--;
            }

            DouglasPeuckerReduction(points, firstPoint, lastPoint, epsilon, ref pointIndexsToKeep);
            List<PointF> returnPoints = new List<PointF>();
            pointIndexsToKeep.Sort();
            foreach (int index in pointIndexsToKeep)
            {
                returnPoints.Add(new PointF(points[index].X, points[index].Y));
            }

            return returnPoints;
        }

        private static void DouglasPeuckerReduction(List<PointF> points, int firstPoint, int lastPoint, double tolerance, ref List<int> pointIndexsToKeep)
        {
            double maxDistance = 0;
            int indexFarthest = 0;

            for (int index = firstPoint; index < lastPoint; index++)
            {
                double distance = PerpendicularDistance(points[firstPoint].X, points[firstPoint].Y, points[lastPoint].X, points[lastPoint].Y, points[index].X, points[index].Y);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    indexFarthest = index;
                }
            }

            if (maxDistance > tolerance && indexFarthest != 0)
            {
                //Add the largest point that exceeds the tolerance
                pointIndexsToKeep.Add(indexFarthest);

                DouglasPeuckerReduction(points, firstPoint,
                indexFarthest, tolerance, ref pointIndexsToKeep);
                DouglasPeuckerReduction(points, indexFarthest,
                lastPoint, tolerance, ref pointIndexsToKeep);
            }
        }

        public static double PerpendicularDistance (double Point1X, double Point1Y, double Point2X, double Point2Y, double PointX, double PointY)
        {
            double area = Math.Abs(.5 * (Point1X * Point2Y + Point2X * PointY + PointX * Point1Y - Point2X * Point1Y - PointX * Point2Y - Point1X * PointY));
            double bottom = Math.Sqrt(Math.Pow(Point1X - Point2X, 2) +
            Math.Pow(Point1Y - Point2Y, 2));
            double height = area / bottom * 2;

            return height;
        }
        // --------------------------------------------------------------


        // ------------------Радио-кнопки------------------------------------
        private void RadioButton_transfer_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_X.Enabled = true;
            numericUpDown_Y.Enabled = true;
            numericUpDown_angle.Enabled = false;
            textBox_alfa.Enabled = false;
            textBox_beta.Enabled = false;
            button_apply.Enabled = true;

            numericUpDown_angle.Value = 0;
            textBox_alfa.Text = "1";
            textBox_beta.Text = "1";
        }

        private void RadioButton_rotation_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_X.Enabled = false;
            numericUpDown_Y.Enabled = false;
            numericUpDown_angle.Enabled = true;
            textBox_alfa.Enabled = false;
            textBox_beta.Enabled = false;
            button_apply.Enabled = true;

            numericUpDown_X.Value = 0;
            numericUpDown_Y.Value = 0;
            textBox_alfa.Text = "1";
            textBox_beta.Text = "1";
        }

        private void RadioButton_scaling_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_X.Enabled = false;
            numericUpDown_Y.Enabled = false;
            numericUpDown_angle.Enabled = false;
            textBox_alfa.Enabled = true;
            textBox_beta.Enabled = true;
            button_apply.Enabled = true;

            numericUpDown_X.Value = 0;
            numericUpDown_Y.Value = 0;
            numericUpDown_angle.Value = 0;
        }
        // ------------------------------------------------------


        private void Form_Load(object sender, EventArgs e)
        {
            tbList = new List<TextBox>();
            int xPos = 80, yPos = 35;
            for (var i = 1; i <= 9; i++)
            {
                TextBox tb = new TextBox()
                {
                    Location = new Point(xPos, yPos),
                    Size = new Size(75, 26),
                    ReadOnly = true,
                    MaxLength = 7
                };
                if (i % 3 == 0)
                {
                    xPos = 80;
                    yPos += 40;
                }
                else xPos += 140;
                groupBox_matrix.Controls.Add(tb);
                tbList.Add(tb);
            }
        }
    }
}