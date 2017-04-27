using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Core;

namespace FirewatchVR
{
    class FirewatchInterpreter : GameInterpreter
    {
        public override bool IsIgnoredCanvas(Canvas canvas)
        {
            return base.IsIgnoredCanvas(canvas) || ((1 << canvas.gameObject.layer) & VR.Context.UILayerMask) == 0;
        }
    }
}
