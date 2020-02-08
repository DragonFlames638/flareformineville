﻿using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flare_Sharp.ClientBase.UI.VObjs
{
    public abstract class VObject
    {
        public string text = "Object";
        public bool visible = false;
        public Font font
        {
            get
            {
                return OverlayHost.ui.font;
            }
        }

        public Rectangle objRect
        {
            get
            {
                return new Rectangle(x, y, width, height);
            }
            set
            {
                x = value.X;
                y = value.Y;
                width = value.Width;
                height = value.Height;
            }
        }
        public int x;
        public int y;
        public int width;
        public int height;

        public SolidBrush primary {
            get
            {
                return OverlayHost.ui.primary;
            }
        }
        public SolidBrush secondary
        {
            get
            {
                return OverlayHost.ui.secondary;
            }
        }
        public SolidBrush tertiary
        {
            get
            {
                return OverlayHost.ui.tertiary;
            }
        }
        public SolidBrush quaternary
        {
            get
            {
                return OverlayHost.ui.quaternary;
            }
        }

        public VObject()
        {
            KeybindHandler.clientKeyDownEvent += (object s, clientKeyEvent a) =>
            {
                if (visible)
                {
                    OnInteractDown(a);
                }
            };
            KeybindHandler.clientKeyHeldEvent += (object s, clientKeyEvent a) =>
            {
                if (visible)
                {
                    OnInteractHeld(a);
                }
            };
            KeybindHandler.clientKeyUpEvent += (object s, clientKeyEvent a) =>
            {
                if (visible)
                {
                    OnInteractUp(a);
                }
            };
        }

        public virtual void OnPaint(PaintEventArgs e)
        {

        }

        public virtual void OnInteractDown(clientKeyEvent a)
        {

        }
        public virtual void OnInteractHeld(clientKeyEvent a)
        {

        }
        public virtual void OnInteractUp(clientKeyEvent a)
        {

        }
    }
}
