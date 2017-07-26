using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public enum Direction
    {
        North = 231,
        West = 232,
        South = 233,
        East = 234
    }
    class robot
    {
        
        public Direction direction;
        
        public robot() // Default constructor
        {
            location = new Point(); // Sets location.X=0 and location.Y=0          
            direction = Direction.North;
        }

        public Point location { get; set; }

        public void Move(int unitToMove)
        {
            Point P = new Point();

            switch (direction)
            {
                case Direction.North:
                    P.X = location.X;
                    P.Y = location.Y - unitToMove;
                    break;
                case Direction.West:
                    P.X = location.X - unitToMove;
                    P.Y = location.Y;
                    break;
                case Direction.South:
                    P.X = location.X;
                    P.Y = location.Y + unitToMove;
                    break;
                case Direction.East:
                    P.X = location.X + unitToMove;
                    P.Y = location.Y;
                    break;
                default:
                    break;
            }

            //My Hacky way of checking for crossing the border and checking the character back one space
            if (location.X <= -100)
            {
                MessageBox.Show("Go the other way");
                //direction = Direction.East;
                Point K = new Point(); 
                K.X = location.X + unitToMove;
                K.Y = location.Y;               
                location = K;
                


            }
            else if (location.X >= 100)
            {
                MessageBox.Show("Go the other way");
                Point K = new Point();
                K.X = location.X - unitToMove;
                K.Y = location.Y;
                location = K;
            }
            else if (location.Y <= -100)
            {
                MessageBox.Show("Go the other way");
                Point K = new Point();
                K.X = location.X;
                K.Y = location.Y + unitToMove;
                location = K;
            }
            else if (location.Y >= 100)
            {
                MessageBox.Show("Go the other way");
                Point K = new Point();
                K.X = location.X;
                K.Y = location.Y - unitToMove;
                location = K;
            }
            else
                location = P;


            /*
            public bool isRange()
            {
                bool Range = true; 

                if (location.X < -100 || location.X > 100)
                {

                    MessageBox.Show("Go the other way");
                    Range = false;


                }
                else if (location.Y < -100 || location.Y > 100)
                {
                    MessageBox.Show("Go the other way");
                   Range = false;

                }

                return Range;
            }
    */
        }

            public void Draw(Panel P)
                {       
                    Point L = new Point(location.X + P.Width / 2, location.Y + P.Height / 2);
                    P.Controls[0].Location = L;
                }
    
        public override string ToString()
        {
            return ((char)direction).ToString();
        }
    }
}
