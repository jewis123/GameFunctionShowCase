using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public RawImage m_barUI;

	private void Start () {
		m_barUI = GetComponent<RawImage> ();
	}
	// Update is called once per frame
	void Update () {
		var rect = m_barUI.uvRect;
		rect.x -= 0.02f;
		m_barUI.uvRect = rect;
	}
}