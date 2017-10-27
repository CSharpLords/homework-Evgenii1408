using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace molesInHoles {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			// норы!
			graphics.FillEllipse(Brushes.Black, 150, 185, 100, 30);
			graphics.FillEllipse(Brushes.Black, 20, 104, 100, 30);
			graphics.FillEllipse(Brushes.Black, 250, 45, 100, 30);
			graphics.FillEllipse(Brushes.Black, 247, 335, 100, 30);
			
			// рисуйте кротов здесь
		}

		private void DrawMole() {
			// координаты крота
			int moleX = 200;
			int moleY = 200;

			// морда
			graphics.FillEllipse(Brushes.Sienna, moleX, moleY, 60, 60);
			graphics.FillEllipse(Brushes.BurlyWood, moleX + 14, moleY + 27, 33, 28);
			// глаза
			graphics.FillEllipse(Brushes.Black, moleX + 15, moleY + 10, 10, 10);
			graphics.FillEllipse(Brushes.Black, moleX + 35, moleY + 10, 10, 10);
			// нос
			graphics.FillEllipse(Brushes.Black, moleX + 25, moleY + 20, 10, 10);
			// рот
			graphics.FillEllipse(Brushes.Black, moleX + 20, moleY + 38, 20, 5);
		}
	}
}
