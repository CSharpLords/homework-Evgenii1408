using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
			// Упростите код с помощью цикла for
			graphics.DrawLine(pen, 20, 40, 80, 80); // первая пара чисел - координаты начала отрезка, вторая - координаты конца
			graphics.DrawLine(pen, 80, 40, 140, 80);
			graphics.DrawLine(pen, 140, 40, 200, 80);
			graphics.DrawLine(pen, 200, 40, 260, 80);
			graphics.DrawLine(pen, 260, 40, 320, 80);
			graphics.DrawLine(pen, 320, 40, 380, 80);
			graphics.DrawLine(pen, 380, 40, 440, 80);
		}
	}
}
