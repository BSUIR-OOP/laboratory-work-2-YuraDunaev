namespace GraphicsEditor
{
    partial class FormPaint
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
            this.panelDraw = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.lbPoints = new System.Windows.Forms.ListBox();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDraw.Location = new System.Drawing.Point(0, 123);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1818, 1047);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.lbPoints);
            this.pnMenu.Controls.Add(this.Clear);
            this.pnMenu.Controls.Add(this.Square);
            this.pnMenu.Controls.Add(this.Triangle);
            this.pnMenu.Controls.Add(this.Circle);
            this.pnMenu.Controls.Add(this.Ellipse);
            this.pnMenu.Controls.Add(this.Rectangle);
            this.pnMenu.Controls.Add(this.Line);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1818, 114);
            this.pnMenu.TabIndex = 9;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.White;
            this.Line.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line.Location = new System.Drawing.Point(10, 14);
            this.Line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(210, 70);
            this.Line.TabIndex = 3;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.White;
            this.Rectangle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rectangle.ForeColor = System.Drawing.Color.Black;
            this.Rectangle.Location = new System.Drawing.Point(228, 14);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(222, 70);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.BackColor = System.Drawing.Color.White;
            this.Ellipse.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ellipse.ForeColor = System.Drawing.Color.Black;
            this.Ellipse.Location = new System.Drawing.Point(458, 14);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(210, 70);
            this.Ellipse.TabIndex = 6;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = false;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click_1);
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.Color.White;
            this.Circle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Circle.ForeColor = System.Drawing.Color.Black;
            this.Circle.Location = new System.Drawing.Point(676, 14);
            this.Circle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(210, 70);
            this.Circle.TabIndex = 7;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.White;
            this.Triangle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Triangle.ForeColor = System.Drawing.Color.Black;
            this.Triangle.Location = new System.Drawing.Point(894, 14);
            this.Triangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(210, 70);
            this.Triangle.TabIndex = 8;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.White;
            this.Square.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Square.ForeColor = System.Drawing.Color.Black;
            this.Square.Location = new System.Drawing.Point(1112, 14);
            this.Square.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(210, 70);
            this.Square.TabIndex = 9;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(1330, 14);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(210, 70);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lbPoints
            // 
            this.lbPoints.FormattingEnabled = true;
            this.lbPoints.ItemHeight = 25;
            this.lbPoints.Location = new System.Drawing.Point(1547, 14);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(261, 79);
            this.lbPoints.TabIndex = 11;
            // 
            // FormGraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1170);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panelDraw);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormGraphicsEditor";
            this.Text = "Shape graphic editor";
            this.Load += new System.EventHandler(this.FormGraphicsEditor_Load);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.ListBox lbPoints;
    }
}

