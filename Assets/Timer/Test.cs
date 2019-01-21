using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
		TimerCtrl.ins.AddTimer(Time.time+3,()=>{
			Debug.Log("-----这是固定时间计时器：3秒前添加，现在执行了");
		});

		TimerCtrl.ins.AddUpdateTimer(1,()=>{
			Debug.Log("+++++这是间歇时间计时器：每1秒执行一次");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
