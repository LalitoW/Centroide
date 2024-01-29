namespace Centroide
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.RSTButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.textBoxRot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.SizeBox);
            this.groupBox1.Controls.Add(this.DrawButton);
            this.groupBox1.Controls.Add(this.RSTButton);
            this.groupBox1.Controls.Add(this.ResizeButton);
            this.groupBox1.Controls.Add(this.RotateButton);
            this.groupBox1.Controls.Add(this.textBoxRot);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxY3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxX3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxY2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxX2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxY4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxX4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxY1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(407, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quadrilateral data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(178, 151);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 36);
            this.DrawButton.TabIndex = 21;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click_1);
            // 
            // RSTButton
            // 
            this.RSTButton.Location = new System.Drawing.Point(203, 358);
            this.RSTButton.Name = "RSTButton";
            this.RSTButton.Size = new System.Drawing.Size(86, 36);
            this.RSTButton.TabIndex = 20;
            this.RSTButton.Text = "RESET";
            this.RSTButton.UseVisualStyleBackColor = true;
            this.RSTButton.Click += new System.EventHandler(this.RSTButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Location = new System.Drawing.Point(296, 267);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(124, 36);
            this.ResizeButton.TabIndex = 19;
            this.ResizeButton.Text = "Change size";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(296, 205);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(124, 36);
            this.RotateButton.TabIndex = 18;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // textBoxRot
            // 
            this.textBoxRot.Location = new System.Drawing.Point(178, 210);
            this.textBoxRot.Name = "textBoxRot";
            this.textBoxRot.Size = new System.Drawing.Size(100, 26);
            this.textBoxRot.TabIndex = 17;
            this.textBoxRot.Text = "0";
            this.textBoxRot.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxRot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rotation angle:";
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(295, 86);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(100, 26);
            this.textBoxY3.TabIndex = 15;
            this.textBoxY3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Y3";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(46, 86);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(100, 26);
            this.textBoxX3.TabIndex = 13;
            this.textBoxX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "X3";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(295, 54);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 26);
            this.textBoxY2.TabIndex = 11;
            this.textBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y2";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(46, 54);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 26);
            this.textBoxX2.TabIndex = 9;
            this.textBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "X2";
            // 
            // textBoxY4
            // 
            this.textBoxY4.Location = new System.Drawing.Point(295, 118);
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.Size = new System.Drawing.Size(100, 26);
            this.textBoxY4.TabIndex = 7;
            this.textBoxY4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y4";
            // 
            // textBoxX4
            // 
            this.textBoxX4.Location = new System.Drawing.Point(46, 118);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(100, 26);
            this.textBoxX4.TabIndex = 5;
            this.textBoxX4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "X4";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(296, 22);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 26);
            this.textBoxY1.TabIndex = 3;
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(47, 22);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 26);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(178, 272);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(100, 26);
            this.SizeBox.TabIndex = 22;
            this.SizeBox.Text = "1";
            this.SizeBox.TextChanged += new System.EventHandler(this.SizeBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Resize to scale:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Centroide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxY4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button RSTButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SizeBox;
    }
}

