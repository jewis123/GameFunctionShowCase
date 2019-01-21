using UnityEngine;

namespace SimpleFactory {
    public class CardItem : MonoBehaviour {
        int type = 0;
        public void SetData (int type) {
            this.type = type;
        }

        public virtual void SayHello () {
            Debug.Log ("我是基类");
        }
    }
}