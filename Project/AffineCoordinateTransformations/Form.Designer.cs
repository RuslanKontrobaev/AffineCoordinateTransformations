namespace WindowsFormsApp_LR_3
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.labelEpsilonValue = new System.Windows.Forms.Label();
            this.numericUpDownEpsilonValue = new System.Windows.Forms.NumericUpDown();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.groupBox_params = new System.Windows.Forms.GroupBox();
            this.textBox_beta = new System.Windows.Forms.TextBox();
            this.textBox_alfa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_transfer = new System.Windows.Forms.RadioButton();
            this.radioButton_rotation = new System.Windows.Forms.RadioButton();
            this.radioButton_scaling = new System.Windows.Forms.RadioButton();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_beta = new System.Windows.Forms.Label();
            this.label_alfa = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_angle = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.numericUpDown_angle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_coords = new System.Windows.Forms.DataGridView();
            this.Column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_drawing = new System.Windows.Forms.GroupBox();
            this.groupBox_coords = new System.Windows.Forms.GroupBox();
            this.groupBox_matrix = new System.Windows.Forms.GroupBox();
            this.label_coordX = new System.Windows.Forms.Label();
            this.label_coordY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilonValue)).BeginInit();
            this.groupBox_params.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coords)).BeginInit();
            this.groupBox_drawing.SuspendLayout();
            this.groupBox_coords.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEpsilonValue
            // 
            this.labelEpsilonValue.AutoSize = true;
            this.labelEpsilonValue.Location = new System.Drawing.Point(7, 23);
            this.labelEpsilonValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpsilonValue.Name = "labelEpsilonValue";
            this.labelEpsilonValue.Size = new System.Drawing.Size(70, 19);
            this.labelEpsilonValue.TabIndex = 2;
            this.labelEpsilonValue.Text = "Эпсилон";
            // 
            // numericUpDownEpsilonValue
            // 
            this.numericUpDownEpsilonValue.Location = new System.Drawing.Point(84, 21);
            this.numericUpDownEpsilonValue.Name = "numericUpDownEpsilonValue";
            this.numericUpDownEpsilonValue.Size = new System.Drawing.Size(125, 26);
            this.numericUpDownEpsilonValue.TabIndex = 1;
            this.numericUpDownEpsilonValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panelDrawing
            // 
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Location = new System.Drawing.Point(6, 22);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(500, 500);
            this.panelDrawing.TabIndex = 6;
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrawing_MouseDown);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrawing_MouseMove);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDrawing_MouseUp);
            // 
            // groupBox_params
            // 
            this.groupBox_params.Controls.Add(this.textBox_beta);
            this.groupBox_params.Controls.Add(this.textBox_alfa);
            this.groupBox_params.Controls.Add(this.groupBox1);
            this.groupBox_params.Controls.Add(this.button_reset);
            this.groupBox_params.Controls.Add(this.label_beta);
            this.groupBox_params.Controls.Add(this.label_alfa);
            this.groupBox_params.Controls.Add(this.button_apply);
            this.groupBox_params.Controls.Add(this.label_angle);
            this.groupBox_params.Controls.Add(this.label_Y);
            this.groupBox_params.Controls.Add(this.label_X);
            this.groupBox_params.Controls.Add(this.numericUpDown_angle);
            this.groupBox_params.Controls.Add(this.numericUpDown_Y);
            this.groupBox_params.Controls.Add(this.numericUpDown_X);
            this.groupBox_params.Controls.Add(this.labelEpsilonValue);
            this.groupBox_params.Controls.Add(this.numericUpDownEpsilonValue);
            this.groupBox_params.Location = new System.Drawing.Point(12, 12);
            this.groupBox_params.Name = "groupBox_params";
            this.groupBox_params.Size = new System.Drawing.Size(215, 429);
            this.groupBox_params.TabIndex = 0;
            this.groupBox_params.TabStop = false;
            this.groupBox_params.Text = "Параметры преобразований";
            // 
            // textBox_beta
            // 
            this.textBox_beta.Enabled = false;
            this.textBox_beta.Location = new System.Drawing.Point(34, 300);
            this.textBox_beta.Name = "textBox_beta";
            this.textBox_beta.Size = new System.Drawing.Size(175, 26);
            this.textBox_beta.TabIndex = 21;
            this.textBox_beta.Text = "1";
            // 
            // textBox_alfa
            // 
            this.textBox_alfa.Enabled = false;
            this.textBox_alfa.Location = new System.Drawing.Point(34, 271);
            this.textBox_alfa.Name = "textBox_alfa";
            this.textBox_alfa.Size = new System.Drawing.Size(175, 26);
            this.textBox_alfa.TabIndex = 0;
            this.textBox_alfa.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_transfer);
            this.groupBox1.Controls.Add(this.radioButton_rotation);
            this.groupBox1.Controls.Add(this.radioButton_scaling);
            this.groupBox1.Location = new System.Drawing.Point(6, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор преобразования";
            // 
            // radioButton_transfer
            // 
            this.radioButton_transfer.AutoSize = true;
            this.radioButton_transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_transfer.Location = new System.Drawing.Point(15, 25);
            this.radioButton_transfer.Name = "radioButton_transfer";
            this.radioButton_transfer.Size = new System.Drawing.Size(84, 23);
            this.radioButton_transfer.TabIndex = 2;
            this.radioButton_transfer.TabStop = true;
            this.radioButton_transfer.Text = "Перенос";
            this.radioButton_transfer.UseVisualStyleBackColor = true;
            this.radioButton_transfer.CheckedChanged += new System.EventHandler(this.RadioButton_transfer_CheckedChanged);
            // 
            // radioButton_rotation
            // 
            this.radioButton_rotation.AutoSize = true;
            this.radioButton_rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_rotation.Location = new System.Drawing.Point(14, 54);
            this.radioButton_rotation.Name = "radioButton_rotation";
            this.radioButton_rotation.Size = new System.Drawing.Size(85, 23);
            this.radioButton_rotation.TabIndex = 3;
            this.radioButton_rotation.TabStop = true;
            this.radioButton_rotation.Text = "Поворот";
            this.radioButton_rotation.UseVisualStyleBackColor = true;
            this.radioButton_rotation.CheckedChanged += new System.EventHandler(this.RadioButton_rotation_CheckedChanged);
            // 
            // radioButton_scaling
            // 
            this.radioButton_scaling.AutoSize = true;
            this.radioButton_scaling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_scaling.Location = new System.Drawing.Point(14, 83);
            this.radioButton_scaling.Name = "radioButton_scaling";
            this.radioButton_scaling.Size = new System.Drawing.Size(153, 23);
            this.radioButton_scaling.TabIndex = 4;
            this.radioButton_scaling.TabStop = true;
            this.radioButton_scaling.Text = "Масштабирование";
            this.radioButton_scaling.UseVisualStyleBackColor = true;
            this.radioButton_scaling.CheckedChanged += new System.EventHandler(this.RadioButton_scaling_CheckedChanged);
            // 
            // button_reset
            // 
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Enabled = false;
            this.button_reset.Location = new System.Drawing.Point(6, 379);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(203, 44);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "Сбросить преобразования";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // label_beta
            // 
            this.label_beta.AutoSize = true;
            this.label_beta.Location = new System.Drawing.Point(7, 300);
            this.label_beta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_beta.Name = "label_beta";
            this.label_beta.Size = new System.Drawing.Size(17, 19);
            this.label_beta.TabIndex = 20;
            this.label_beta.Text = "β";
            // 
            // label_alfa
            // 
            this.label_alfa.AutoSize = true;
            this.label_alfa.Location = new System.Drawing.Point(7, 271);
            this.label_alfa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_alfa.Name = "label_alfa";
            this.label_alfa.Size = new System.Drawing.Size(17, 19);
            this.label_alfa.TabIndex = 19;
            this.label_alfa.Text = "α";
            // 
            // button_apply
            // 
            this.button_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(6, 330);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(203, 44);
            this.button_apply.TabIndex = 10;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.Button_apply_Click);
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(7, 239);
            this.label_angle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(88, 19);
            this.label_angle.TabIndex = 18;
            this.label_angle.Text = "Угол (град.)";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(7, 208);
            this.label_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(20, 19);
            this.label_Y.TabIndex = 17;
            this.label_Y.Text = "Y";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(7, 176);
            this.label_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(20, 19);
            this.label_X.TabIndex = 16;
            this.label_X.Text = "X";
            // 
            // numericUpDown_angle
            // 
            this.numericUpDown_angle.Enabled = false;
            this.numericUpDown_angle.Location = new System.Drawing.Point(102, 237);
            this.numericUpDown_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_angle.Name = "numericUpDown_angle";
            this.numericUpDown_angle.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown_angle.TabIndex = 7;
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Enabled = false;
            this.numericUpDown_Y.Location = new System.Drawing.Point(34, 206);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(175, 26);
            this.numericUpDown_Y.TabIndex = 6;
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Enabled = false;
            this.numericUpDown_X.Location = new System.Drawing.Point(34, 174);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_X.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(175, 26);
            this.numericUpDown_X.TabIndex = 5;
            // 
            // dataGridView_coords
            // 
            this.dataGridView_coords.AllowUserToAddRows = false;
            this.dataGridView_coords.AllowUserToDeleteRows = false;
            this.dataGridView_coords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_coords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X,
            this.Column_Y});
            this.dataGridView_coords.Location = new System.Drawing.Point(6, 23);
            this.dataGridView_coords.Name = "dataGridView_coords";
            this.dataGridView_coords.ReadOnly = true;
            this.dataGridView_coords.Size = new System.Drawing.Size(256, 400);
            this.dataGridView_coords.TabIndex = 7;
            // 
            // Column_X
            // 
            this.Column_X.Frozen = true;
            this.Column_X.HeaderText = "X";
            this.Column_X.Name = "Column_X";
            this.Column_X.ReadOnly = true;
            this.Column_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Y
            // 
            this.Column_Y.Frozen = true;
            this.Column_Y.HeaderText = "Y";
            this.Column_Y.Name = "Column_Y";
            this.Column_Y.ReadOnly = true;
            this.Column_Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox_drawing
            // 
            this.groupBox_drawing.Controls.Add(this.panelDrawing);
            this.groupBox_drawing.Location = new System.Drawing.Point(507, 12);
            this.groupBox_drawing.Name = "groupBox_drawing";
            this.groupBox_drawing.Size = new System.Drawing.Size(512, 535);
            this.groupBox_drawing.TabIndex = 10;
            this.groupBox_drawing.TabStop = false;
            this.groupBox_drawing.Text = "Область рисования";
            // 
            // groupBox_coords
            // 
            this.groupBox_coords.Controls.Add(this.dataGridView_coords);
            this.groupBox_coords.Location = new System.Drawing.Point(233, 12);
            this.groupBox_coords.Name = "groupBox_coords";
            this.groupBox_coords.Size = new System.Drawing.Size(268, 429);
            this.groupBox_coords.TabIndex = 11;
            this.groupBox_coords.TabStop = false;
            this.groupBox_coords.Text = "Координаты вершин";
            // 
            // groupBox_matrix
            // 
            this.groupBox_matrix.Location = new System.Drawing.Point(12, 447);
            this.groupBox_matrix.Name = "groupBox_matrix";
            this.groupBox_matrix.Size = new System.Drawing.Size(489, 156);
            this.groupBox_matrix.TabIndex = 12;
            this.groupBox_matrix.TabStop = false;
            this.groupBox_matrix.Text = "Матрица преобразований";
            // 
            // label_coordX
            // 
            this.label_coordX.AutoSize = true;
            this.label_coordX.Location = new System.Drawing.Point(508, 554);
            this.label_coordX.Name = "label_coordX";
            this.label_coordX.Size = new System.Drawing.Size(23, 19);
            this.label_coordX.TabIndex = 13;
            this.label_coordX.Text = "X:";
            // 
            // label_coordY
            // 
            this.label_coordY.AutoSize = true;
            this.label_coordY.Location = new System.Drawing.Point(509, 581);
            this.label_coordY.Name = "label_coordY";
            this.label_coordY.Size = new System.Drawing.Size(22, 19);
            this.label_coordY.TabIndex = 14;
            this.label_coordY.Text = "Y:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.label_coordY);
            this.Controls.Add(this.label_coordX);
            this.Controls.Add(this.groupBox_matrix);
            this.Controls.Add(this.groupBox_coords);
            this.Controls.Add(this.groupBox_drawing);
            this.Controls.Add(this.groupBox_params);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3 - Афинные геометрические преобразования";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilonValue)).EndInit();
            this.groupBox_params.ResumeLayout(false);
            this.groupBox_params.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coords)).EndInit();
            this.groupBox_drawing.ResumeLayout(false);
            this.groupBox_coords.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEpsilonValue;
        private System.Windows.Forms.NumericUpDown numericUpDownEpsilonValue;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.GroupBox groupBox_params;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.DataGridView dataGridView_coords;
        private System.Windows.Forms.GroupBox groupBox_drawing;
        private System.Windows.Forms.GroupBox groupBox_coords;
        private System.Windows.Forms.RadioButton radioButton_scaling;
        private System.Windows.Forms.RadioButton radioButton_rotation;
        private System.Windows.Forms.RadioButton radioButton_transfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Y;
        private System.Windows.Forms.Label label_beta;
        private System.Windows.Forms.Label label_alfa;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_angle;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_matrix;
        private System.Windows.Forms.TextBox textBox_beta;
        private System.Windows.Forms.TextBox textBox_alfa;
        private System.Windows.Forms.Label label_coordX;
        private System.Windows.Forms.Label label_coordY;
    }
}