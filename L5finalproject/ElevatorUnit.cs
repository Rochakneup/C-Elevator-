using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5finalproject
{
    internal class ElevatorUnit
    {

        public void elevatorUp(PictureBox elevatorIndoor, PictureBox elevatorPosition)
        {
            elevatorPosition.Top -= 1;
            elevatorIndoor.Top -= 1;

        }
        public void elevatorDown(PictureBox elevatorIndoor, PictureBox elevatorPosition)
        {
            elevatorPosition.Top += 1;
            elevatorIndoor.Top += 1;
        }
    }
}
