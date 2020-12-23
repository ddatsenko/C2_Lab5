using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace task2_laba_5
{
    class Rhomb : Figure
    {
        protected Form1 form1;


        public int hD { get; }
        public int vD { get; }

        public Rhomb(int x,int y, int hD, int vD,Form1 form1) : base (x,y)
        {
            this.form1 = form1;
            this.hD = hD;
            this.vD = vD;
           
        }

        public override void DrawBlack()
        {
            Graphics gr = this.form1.CreateGraphics();
            gr.DrawPolygon(new Pen(Color.Black), new PointF[] {new PointF(x - (vD / 2), y),
                new PointF(x, y - (hD / 2)),
                new PointF(x + (vD / 2), y),
                new PointF(x, y + (hD / 2))} );
            
        }

        public override void HideDrawingBackGround()
        {
            Graphics gr = this.form1.CreateGraphics();
            gr.DrawPolygon(new Pen(form1.BackColor), points: new PointF[] {new PointF(x - (vD / 2), y),
                new PointF(x, y - (hD / 2)),
                new PointF(x + (vD / 2), y),
                new PointF(x, y + (hD / 2))});
        }
    }
}
