using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Figure currentFigure;
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            currentFigure = new Circle(200, 300, 50);
            Invalidate();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            currentFigure = new Square(200, 300, 100);
            Invalidate();
        }

        private void RhombButton_Click(object sender, EventArgs e)
        {
            currentFigure = new Rhomb(200, 300, 120, 80);
            Invalidate();
        }

        private async void MoveButton_Click(object sender, EventArgs e)
        {
            if (currentFigure == null) return;

            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            try
            {
                for (int i = 0; i < 50; i++)
                {
                    if (token.IsCancellationRequested)
                        break;

                    currentFigure.MoveRight(5);
                    Invalidate();
                    await Task.Delay(100);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (currentFigure != null)
            {
                currentFigure.DrawBlack(e.Graphics);
            }
        }
    }
}
