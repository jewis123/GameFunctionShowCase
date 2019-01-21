//模拟背包模块
using UnityEngine;

namespace RedPoint.Scripts {
    public class ModBag : MonoBehaviour {
        public static ModBag instance;
        public NotifyMark Notify = new NotifyMark ();

        private void Awake () {
            instance = this;
        }
        private void OnDestroy () {
            Notify.Reset ();
            instance = null;
        }
    }
}