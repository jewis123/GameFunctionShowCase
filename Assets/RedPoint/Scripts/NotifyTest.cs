using UnityEngine;

namespace RedPoint.Scripts {
    public class NotifyTest : MonoBehaviour {

        protected NotifyMark Mark;

        public void ChangeNotify () {
            if (Mark != null) {
                Mark.ChangeNotify (!Mark.IsNotify);
            }
        }

        public bool NotifyEnabled {
            get { return Mark != null; }
            set {
                if (value) {
                    if (Mark != null) {
                        return;
                    }
                    Mark = new NotifyMark ();
                } else {
                    if (Mark == null) {
                        return;
                    }
                    Mark.Reset ();
                    Mark = null;
                }
            }
        }

        public virtual void SetParent(){}

    }
}