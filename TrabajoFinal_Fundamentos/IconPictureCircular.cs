﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
namespace TrabajoFinal_Fundamentos
{
    public class IconPictureCircular:IconPictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
           GraphicsPath g=new GraphicsPath();
            g.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);

        }
    }
}
