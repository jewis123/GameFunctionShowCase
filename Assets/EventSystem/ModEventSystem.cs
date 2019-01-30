using UnityEngine;

namespace FunctionRealise.EventSystem {
    public class ModEventSystem:MonoBehaviour {
        public static ModEventSystem instance;
        [HideInInspector]
        public  EventManager EventMgr = new EventManager ();

        private void Awake () {
            instance = this;
        }
        private void OnDestroy () {
            instance = null;
        }
    }
}