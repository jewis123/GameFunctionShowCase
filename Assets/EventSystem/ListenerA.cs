using System;
using FunctionRealise.EventSystem;
using UnityEngine;

namespace FunctionRealise.Assets.EventSystem {
    public class ListenerA:MonoBehaviour {
        private void Start () {
            ModEventSystem.instance.EventMgr.AddListener (EventEnum.EventB, OnEvent);
            ModEventSystem.instance.EventMgr.AddListener (EventEnum.EventA, OnEvent);
        }
        private void OnDestroy () {
            ModEventSystem.instance.EventMgr.RemoveListener (EventEnum.EventB, OnEvent);
            ModEventSystem.instance.EventMgr.RemoveListener (EventEnum.EventA, OnEvent);
        }

        private void OnEvent (EventEnum arg1, object[] arg2) {
            if (arg1 == EventEnum.EventA) {
                Debug.Log (arg2[0]);
            } else { 
            Debug.Log (string.Format ("Recevie from EventB    arg0:{0}, arg1{1}", arg2[0], arg2[1]));
            }
        }
    }
}