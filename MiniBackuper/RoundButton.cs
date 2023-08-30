using System.Drawing.Drawing2D;

namespace MiniBackuper
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            int arcSize = 12;

            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(Width - arcSize, Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, Height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseFigure();

            Region = new Region(path);

            base.OnPaint(pevent);
        }
    }
}
