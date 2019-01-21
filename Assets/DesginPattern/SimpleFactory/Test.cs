using UnityEngine;

namespace SimpleFactory {
    public class Test : MonoBehaviour {
        public GameObject prb;
        private Factory factory = new Factory ();
        private GameObject card;
        private void Start () {
            Transform trans = Instantiate (prb).transform;
            CardItem item = factory.CreateCardItem (3);
            card = trans.gameObject;
            item.SetData (3);
            item.SayHello ();
            trans.gameObject.AddComponent (item.GetType ());
        }
       
    }
}