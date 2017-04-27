using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Controls.Speech;
using VRGIN.Core;
using VRGIN.Visuals;

namespace FirewatchVR
{
    class FirewatchContext : IVRManagerContext
    {
        DefaultMaterialPalette _Materials;
        VRSettings _Settings;

        public FirewatchContext()
        {
            // We'll keep those always the same
            _Materials = new DefaultMaterialPalette();
            _Settings = VRSettings.Load<VRSettings>("VRSettings.xml");
        }


        public IMaterialPalette Materials { get { return _Materials; } }

        public VRSettings Settings { get { return _Settings; } }

        public Type VoiceCommandType { get { return typeof(VoiceCommand); } }


        public bool ConfineMouse
        {
            get
            {
                return true;
            }
        }

        public bool EnforceDefaultGUIMaterials
        {
            get
            {
                return false;
            }
        }

        public bool GUIAlternativeSortingMode
        {
            get
            {
                return false;
            }
        }

        public float GuiFarClipPlane
        {
            get
            {
                return 100;
            }
        }

        public string GuiLayer
        {
            get
            {
                return "Default";
            }
        }

        public float GuiNearClipPlane
        {
            get
            {
                return 0;
            }
        }

        public int IgnoreMask
        {
            get
            {
                return 0;
            }
        }

        public string InvisibleLayer
        {
            get
            {
                return "Ignore Raycast";
            }
        }
        

        public float NearClipPlane
        {
            get
            {
                return 0.05f;
            }
        }

        public Color PrimaryColor
        {
            get
            {
                return Color.cyan;
            }
        }
        
        public bool SimulateCursor
        {
            get
            {
                return true;
            }
        }

        public string UILayer
        {
            get
            {
                return "UI";
            }
        }

        public int UILayerMask
        {
            get
            {
                return LayerMask.GetMask(UILayer);
            }
        }

        public float UnitToMeter
        {
            get
            {
                return 1f;
            }
        }
    }
}
