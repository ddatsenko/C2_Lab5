using System.Drawing;
using task2_laba_5;

namespace Lab2_Task5
{
    class Square : Figure
    {
        public int size { 
            get; 
        }
        protected Form1 form;

        public Square(int x, int y, int s, Form1 form) :base(x,y)
        {
            this.size = s;
            this.form = form;
        }

        public override void DrawBlack()
        {
            Graphics graphics2 = form.CreateGraphics();
            graphics2.DrawRectangle(Pens.Black, this.x, this.y, size, size);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics2 = form.CreateGraphics();
            graphics2.DrawRectangle(new Pen(form.BackColor), this.x, this.y, size, size);
        }
    }
}
