using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int wight, int height);
        void MoveTransport(Direction direction);
        void DrawLoc(Graphics g);
    }
}
