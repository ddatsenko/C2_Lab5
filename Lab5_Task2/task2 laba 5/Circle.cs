using System.Drawing;
using task2_laba_5;

namespace Lab2_Task5
{
    class Circle : Figure
    {
        public int r { 
            get; 
        }
        protected Form1 form;
        public Circle(int x, int y, int r, Form1 form) : base(x, y)
        {
            this.r = r;
            this.form = form;
        }

        public override void DrawBlack()
        {
            Graphics graphics = form.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, x, y, this.r, this.r);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics = form.CreateGraphics();
            graphics.DrawEllipse(new Pen(form.BackColor), x, y, this.r, this.r);
        }
    }
}
