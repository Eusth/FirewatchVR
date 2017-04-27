using IllusionPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Core;

namespace FirewatchVR
{

    class Displacement : ProtectedBehaviour
    {

        protected override void OnUpdate()
        {
            if(Input.GetKeyDown(KeyCode.Keypad7))
            {
                gameObject.AddComponent<Camera>().CopyFrom(Camera.main);
                this.transform.position = Camera.main.transform.position;
                this.transform.rotation = Camera.main.transform.rotation;
                Camera.main.enabled = false;
            }
        }

        protected override void OnLateUpdate()
        {
            base.OnLateUpdate();

            if(Input.GetKey(KeyCode.Keypad5))
            {
                transform.position -= transform.forward * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Keypad4))
            {
                transform.position -= transform.right * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.Keypad8))
            {
                transform.position += transform.forward * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Keypad6))
            {
                transform.position += transform.right * Time.deltaTime;
            }
        }

    }

    class DisplacementPlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "Displacement Plugin";
            }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }

        public void OnApplicationQuit()
        {
        }

        public void OnApplicationStart()
        {
            var displacement = new GameObject().AddComponent<Displacement>();
            GameObject.DontDestroyOnLoad(displacement.gameObject);
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLevelWasInitialized(int level)
        {
        }

        public void OnLevelWasLoaded(int level)
        {
        }

        public void OnUpdate()
        {
        }
    }
}
