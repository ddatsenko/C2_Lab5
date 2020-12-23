using System.Drawing;
using task2_laba_5;

namespace Lab2_Task5
{
    class Rhomb : Figure
    {
        protected Form1 form;

        public int hD { 
            get;
        }
        public int vD {
            get;
        }

        public Rhomb(int x,int y, int hD, int vD, Form1 form) : base (x,y)
        {
            this.form = form;
            this.hD = hD;
            this.vD = vD;
           
        }

        public override void DrawBlack()
        {
            Graphics gr = this.form.CreateGraphics();
            gr.DrawPolygon(new Pen(Color.Black), new PointF[] {new PointF(x - (vD / 2), y),
                new PointF(x, y - (hD / 2)),
                new PointF(x + (vD / 2), y),
                new PointF(x, y + (hD / 2))} );
            
        }

        public override void HideDrawingBackGround()
        {
            Graphics gr = this.form.CreateGraphics();
            gr.DrawPolygon(new Pen(form.BackColor), new PointF[] {new PointF(x - (vD / 2), y),
                new PointF(x, y - (hD / 2)),
                new PointF(x + (vD / 2), y),
                new PointF(x, y + (hD / 2))});
        }
    }
}
