using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
//HEJHJE
namespace PainterFrame
{
    public partial class PenButton : Button
    {
        public PenButton()
        {
            InitializeComponent();
        }

        public PenButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
