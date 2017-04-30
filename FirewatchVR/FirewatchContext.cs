using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Controls.Speech;
using VRGIN.Core;
using VRGIN.Helpers;
using VRGIN.Visuals;

namespace FirewatchVR
{
    class FirewatchContext : DefaultContext
    {
        public override float GuiFarClipPlane
        {
            get
            {
                return 100;
            }
        }
        
        public override float GuiNearClipPlane
        {
            get
            {
                return 0;
            }
        }
        

        public override float NearClipPlane
        {
            get
            {
                return 0.05f;
            }
        }
    }
}
