using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbokyrsa4
{
    public class Render
    {
        Bitmap map = new Bitmap(1280, 960);
        Graphics graph;

        public Bitmap RenderMap()
        {
            graph = Graphics.FromImage(map);
            Image globalmap = Image.FromFile("MAP V1.jpg");
            graph.DrawImage(globalmap, 1, 1, 1279, 959);
            return map;
        }

        public void FindTowns()
        {

        }
    }
}
