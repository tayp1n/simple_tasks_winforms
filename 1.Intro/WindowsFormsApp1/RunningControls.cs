using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace WindowsFormsApp1
{
    public class RunningControls
    {
        private float _radiusMult = 1.5f;
        private float _friction = 0.9f;
 
        private Timer _timer;
        private int _timerInterval = 1000 / 30;
 
        private List<MovingProps> _allObjects;
        public RunningControls()
        {
            _allObjects = new List<MovingProps>();
 
            _timer = new Timer();
            _timer.Interval = _timerInterval;
            _timer.Tick += _timer_Tick;
        }
 
        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
 
        public void AddControl(Control control)
        {
            if (_allObjects.Any(i => i.ControlRef == control)) return;
 
            _allObjects.Add(new MovingProps(control, _radiusMult));
        }
 
        public void RemoveControl(Control control)
        {
            MovingProps existProps = _allObjects.FirstOrDefault(i => i.ControlRef == control);
            if (existProps == null) return;
 
            _allObjects.Remove(existProps);
        }
 
        private void _timer_Tick(object sender, EventArgs e)
        {
            foreach (MovingProps obj in _allObjects)
            {
                Control control = obj.ControlRef;
                var parent = control.Parent;
                var mouse = parent.PointToClient(Cursor.Position);
 
 
                Point center = getControlCenter(control);
 
                float dx = mouse.X - center.X;
                float dy = mouse.Y - center.Y;
                float dist = (float)Math.Sqrt(dx * dx + dy * dy);
                float ang = (float)Math.Atan2(dy, dx);
                float offset = dist - obj.Radius;
 
                if (dist < obj.Radius)
                {
                    obj.SpeedX += (float)Math.Cos(ang) * offset;
                    obj.SpeedY += (float)Math.Sin(ang) * offset;
                }
 
 
                obj.SpeedX *= _friction;
                obj.SpeedY *= _friction;
 
                obj.X += obj.SpeedX;
                obj.Y += obj.SpeedY;
 
                if (control.Left < 0)
                {
                    obj.X = 0;
                    obj.SpeedX *= -1;
                }
 
                if (control.Right > parent.ClientSize.Width)
                {
                    obj.X = parent.ClientSize.Width - control.Width;
                    obj.SpeedX *= -1;
                }
 
                if (control.Top < 0)
                {
                    obj.Y = 0;
                    obj.SpeedY *= -1;
                }
 
                if (control.Bottom > parent.ClientSize.Height)
                {
                    obj.Y = parent.ClientSize.Height - control.Height;
                    obj.SpeedY *= -1;
                }
 
 
                control.Location = new Point((int)obj.X, (int)obj.Y);
            }
 
        }
 
        private Point getControlCenter(Control control)
        {
            return new Point(control.Left + (control.Width / 2), control.Top + (control.Height / 2));
        }
 
        private class MovingProps
        {
            public Control ControlRef;
            public float Radius;
            public float SpeedX;
            public float SpeedY;
            public float X;
            public float Y;
 
            public MovingProps(Control control, float radiusMult)
            {
                ControlRef = control;
                Radius = Math.Max(ControlRef.Width / 2, ControlRef.Height / 2) * radiusMult;
                X = ControlRef.Location.X;
                Y = ControlRef.Location.Y;
            }
        }
    }
}