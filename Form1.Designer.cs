
namespace WindowsFormsApp
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSYellowAreaR = new System.Windows.Forms.Label();
            this.SRes = new System.Windows.Forms.Label();
            this.SPolygonR = new System.Windows.Forms.Label();
            this.SPolygon = new System.Windows.Forms.Label();
            this.labelStarR = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(325, 438);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 41);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "см";
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Location = new System.Drawing.Point(8, 17);
            this.labelCM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(144, 16);
            this.labelCM.TabIndex = 5;
            this.labelCM.Text = "ребро 6-тиугольника";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelSYellowAreaR);
            this.groupBox1.Controls.Add(this.SRes);
            this.groupBox1.Controls.Add(this.SPolygonR);
            this.groupBox1.Controls.Add(this.SPolygon);
            this.groupBox1.Controls.Add(this.labelStarR);
            this.groupBox1.Controls.Add(this.labelStar);
            this.groupBox1.Controls.Add(this.labelCM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(333, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(180, 438);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "изменить масштаб";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDecrease_Click);
            // 
            // labelSYellowAreaR
            // 
            this.labelSYellowAreaR.AutoSize = true;
            this.labelSYellowAreaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelSYellowAreaR.ForeColor = System.Drawing.Color.Black;
            this.labelSYellowAreaR.Location = new System.Drawing.Point(12, 269);
            this.labelSYellowAreaR.Name = "labelSYellowAreaR";
            this.labelSYellowAreaR.Size = new System.Drawing.Size(88, 16);
            this.labelSYellowAreaR.TabIndex = 11;
            this.labelSYellowAreaR.Text = "S yellow area";
            // 
            // SRes
            // 
            this.SRes.AutoSize = true;
            this.SRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SRes.Location = new System.Drawing.Point(12, 241);
            this.SRes.Name = "SRes";
            this.SRes.Size = new System.Drawing.Size(124, 16);
            this.SRes.TabIndex = 10;
            this.SRes.Text = "S желтой области";
            // 
            // SPolygonR
            // 
            this.SPolygonR.AutoSize = true;
            this.SPolygonR.ForeColor = System.Drawing.Color.Black;
            this.SPolygonR.Location = new System.Drawing.Point(12, 192);
            this.SPolygonR.Name = "SPolygonR";
            this.SPolygonR.Size = new System.Drawing.Size(68, 16);
            this.SPolygonR.TabIndex = 9;
            this.SPolygonR.Text = "S polygon";
            // 
            // SPolygon
            // 
            this.SPolygon.AutoSize = true;
            this.SPolygon.ForeColor = System.Drawing.Color.Gray;
            this.SPolygon.Location = new System.Drawing.Point(12, 160);
            this.SPolygon.Name = "SPolygon";
            this.SPolygon.Size = new System.Drawing.Size(116, 16);
            this.SPolygon.TabIndex = 8;
            this.SPolygon.Text = "S 6-тиугольника:";
            // 
            // labelStarR
            // 
            this.labelStarR.AutoSize = true;
            this.labelStarR.ForeColor = System.Drawing.Color.Black;
            this.labelStarR.Location = new System.Drawing.Point(12, 115);
            this.labelStarR.Name = "labelStarR";
            this.labelStarR.Size = new System.Drawing.Size(41, 16);
            this.labelStarR.TabIndex = 7;
            this.labelStarR.Text = "S star";
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.ForeColor = System.Drawing.Color.Red;
            this.labelStar.Location = new System.Drawing.Point(12, 87);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(129, 16);
            this.labelStar.TabIndex = 6;
            this.labelStar.Text = "S красной фигуры:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 415);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(88, 16);
            this.labelSize.TabIndex = 16;
            this.labelSize.Text = "масштаб: см.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCanvas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 485);
            this.Name = "Form1";
            this.Text = "Программа";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSYellowAreaR;
        private System.Windows.Forms.Label SRes;
        private System.Windows.Forms.Label SPolygonR;
        private System.Windows.Forms.Label SPolygon;
        private System.Windows.Forms.Label labelStarR;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSize;
    }
}

