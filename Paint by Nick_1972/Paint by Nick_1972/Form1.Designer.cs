namespace Paint_by_Nick_1972
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pen_width = new NumericUpDown();
            btn_save = new Button();
            btn_clear = new Button();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            pic = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pen_width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pen_width);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(btn_color);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 111);
            panel1.TabIndex = 0;
            // 
            // pen_width
            // 
            pen_width.Location = new Point(477, 7);
            pen_width.Name = "pen_width";
            pen_width.Size = new Size(50, 23);
            pen_width.TabIndex = 0;
            pen_width.ValueChanged += pen_width_ValueChanged;
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_save.Location = new Point(835, 15);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(128, 26);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(835, 79);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(128, 26);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(3, 3);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(273, 108);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 8;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_line
            // 
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.MiddleLeft;
            btn_line.Location = new Point(757, 36);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(64, 58);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rect
            // 
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(687, 36);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(64, 58);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rect";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(617, 36);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(64, 58);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eraser.Location = new Point(547, 36);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(64, 58);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pencil.Location = new Point(477, 36);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(64, 58);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fill.Location = new Point(407, 36);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(64, 58);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.color;
            btn_color.ImageAlign = ContentAlignment.MiddleLeft;
            btn_color.Location = new Point(337, 36);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(64, 58);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(282, 46);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(42, 36);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(330, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 81);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 470);
            panel2.Name = "panel2";
            panel2.Size = new Size(975, 41);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(975, 511);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(835, 47);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 10;
            button1.Text = "Load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pen_width).EndInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button btn_color;
        private Button pic_color;
        private Button btn_fill;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_ellipse;
        private Button btn_rect;
        private Button btn_line;
        private Panel panel3;
        private PictureBox color_picker;
        private Button btn_save;
        private Button btn_clear;
        private NumericUpDown pen_width;
        private Button button1;
    }
}
