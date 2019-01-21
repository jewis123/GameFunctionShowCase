using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedPoint.Scripts {
    public class CommonRedPoint : MonoBehaviour {
        public Image sprRedPoint;
        public NotifyMark Notify = null; //控制小红点

        private void OnEnable () {
            if (Notify != null) {
                Notify.OnChange += SetRedPoint;
            }

            if (Notify == null) {
                SetRedPoint (false);
            }
        }

        public void SetData (NotifyMark notify) {
            if (notify == null) {
                SetRedPoint (false);
                return;
            }

            Notify = notify;
            Notify.OnChange += SetRedPoint;
        }

        private void SetRedPoint (bool flag) {
            if (sprRedPoint != null) {
                sprRedPoint.gameObject.SetActive (flag);
            }
        }
    }
}