using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDS : MonoBehaviour {

    public List<int> inner = new List<int> ();
    public List<int> otter = new List<int> ();
    public List<int> getttet {
        get {
            return inner;
        }
    }

    // Start is called before the first frame update
    void Start () {
        inner.Add (1);
        inner.Add (1);
        inner.Add (1);
        inner.Add (1);
        inner.Add (1);
        getttet.Add (2);
        foreach (int item in getttet) {
            Debug.LogError (item);
        }

        otter.Add (3);
        otter.Add (3);
        otter.Add (3);
        otter.Add (3);

        inner = otter;
        for (int i = 0; i < inner.Count; i++) {
            Debug.LogError (inner[i]);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}