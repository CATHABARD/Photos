using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Photos
{
    public partial class WizardControl : TabControl
    {
        private bool simpleMode = true;
        [DefaultValue(true)]
        public bool SimpleMode
        {
            get { return simpleMode; }
            set
            {
                simpleMode = value;
                RecreateHandle();
            }
        }
        private bool simpleModeInDesign = false;
        [DefaultValue(false)]
        public bool SimpleModeInDesign
        {
            get { return simpleModeInDesign; }
            set
            {
                simpleModeInDesign = value;
                RecreateHandle();
            }
        }
        public override Rectangle DisplayRectangle
        {
            get
            {
                if ((simpleMode == true) && (!DesignMode || simpleModeInDesign))
                {
                    return new Rectangle(0, 0, Width, Height);
                }
                else
                    return base.DisplayRectangle;
            }
        }

        public WizardControl()
        {
            InitializeComponent();
        }
    }
}
