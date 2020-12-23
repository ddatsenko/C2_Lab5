using System.Drawing;


namespace task2_laba_5
{
    abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }

        public Color FigureColor { 
            get; 
            set; 
        }
        public Color BackgroundColor { 
            get; 
            set; 
        }

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                x++;
            }
        }

        public override string ToString()
        {
            return "x = " + x + " y = " + y;
        }
    }
}
