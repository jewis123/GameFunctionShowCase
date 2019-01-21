using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBall : MonoBehaviour {
	public int BallIndex = 0;
	private ObjectPooler OP;
	public Transform SpawnPoint;
	private void Start()
	{
		OP = ObjectPooler.SharedInstance;
	}
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.Space))
		{
			Random.InitState((int)System.DateTime.Now.Ticks);
			GameObject Ball = OP.GetPooledObject(BallIndex);
			Ball.transform.rotation = SpawnPoint.transform.rotation;

			float xPos = Random.Range(-5f, 5f);
			float zPos = Random.Range(-5f, 5f);
			Ball.transform.position = SpawnPoint.transform.position + xPos * Vector3.right + zPos * Vector3.forward;
			Ball.SetActive(true);
		}
	}
}
