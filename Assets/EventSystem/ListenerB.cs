using FunctionRealise.EventSystem;
using UnityEngine;

namespace FunctionRealise.Assets.EventSystem {
    public class ListenerB:MonoBehaviour {
        private void Start () {
            ModEventSystem.instance.EventMgr.AddListener (EventEnum.EventC, OnEvent);
        }
        private void OnDestroy () {
            ModEventSystem.instance.EventMgr.RemoveListener (EventEnum.EventC, OnEvent);
        }

        private void OnEvent (EventEnum arg1, object[] arg2) {
            Debug.Log (string.Format ("Recevie from EventC    arg0:{0}, arg1{1}", arg2[0], arg2[1]));
        }
    }
}