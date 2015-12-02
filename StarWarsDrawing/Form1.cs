using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsDrawing
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ExhaustPort(75, 0, 20, 200);
        }

        public void ExhaustPort(float x, float y, float width, float height)
        {
            g = this.CreateGraphics();
            Pen exPen = new Pen(Color.White, 1);

            float xScale = width / 20;
            float yScale = height / 188;

            //ball at end
            g.DrawArc(exPen, 5*xScale, 175*yScale, 20*xScale, 20*yScale , 295 , 300);
            //left long line
            g.DrawLine(exPen, 10 * xScale, 5 * yScale, 10 * xScale, 178 * yScale);
            //right long line
            g.DrawLine(exPen, 20 * xScale, 5 * yScale, 20 * xScale, 178 * yScale);
       


        }
    }
}
