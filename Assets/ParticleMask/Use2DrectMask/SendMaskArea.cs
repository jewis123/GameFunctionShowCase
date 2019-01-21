using UnityEngine;

public class SendMaskArea : MonoBehaviour {
	public RectTransform rect;
	void Start () {
		Vector3[] corners = new Vector3[4];
		rect.GetWorldCorners (corners);
		for (int i = 0; i < 4; i++) {
			Debug.LogError (corners[i]);
		}
		for (int i = 0; i < transform.childCount; i++) {
			Material mat = transform.GetChild (i).GetComponent<ParticleSystemRenderer> ().material;
			mat.SetColor ("_TintColor", Color.yellow);
			mat.SetFloat ("_MinX", corners[0].x);
			mat.SetFloat ("_MinY", corners[0].y);
			mat.SetFloat ("_MaxX", corners[2].x);
			mat.SetFloat ("_MaxY", corners[2].y);
		}
	}
}