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

			// шар
			graphics.FillEllipse(Brushes.Violet, 30, 50, 46, 66); // первая пара чисел - координаты, вторая - ширина и высота
			// нитка
			graphics.DrawLine(Pens.BlueViolet, 53, 116, 210, 300); // первая пара чисел - координаты начала отрезка, вторая - координаты конца

			// бобр
			DrawHopper(208, 240);
		}

		private void DrawHopper(int x, int y) {
			Image img = Image.FromFile("../../Hopper-Jumping.png");
			graphics.DrawImage(img, x, y);
		}
	}
}
