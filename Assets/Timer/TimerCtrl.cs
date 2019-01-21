// 添加一个计时器功能，指定时间后出发或者每隔一段时间触发

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTimeNode {
	public float lastUpdateTime = 0; //上次记录的时间
	public Action act;
	public UpdateTimeNode (Action onDone) { act = onDone; }
}

public class TimerCtrl : MonoBehaviour {
	public static TimerCtrl ins;
	private SortedList<float, Action> timeAction = new SortedList<float, Action> (); //这里使用有序连表示因为存入的数据一定是有序的
	private SortedList<float, UpdateTimeNode> updateTimerAction = new SortedList<float, UpdateTimeNode> ();

	private float timeInterval = 1, lastUpdateTime = 0; //刷新依据

	private void Awake () {
		ins = this;
	}

	private void OnDestroy () {
		ins = null;
	}

	///<summery>
	///添加一个固定时间后执行的计时器
	/// time:是结束时间点， 即添加此计时器的时间点 + X秒后的时间
	///</summery>
	public void AddTimer (float time, Action onDone) {
		if (!timeAction.ContainsKey (time)) {
			timeAction.Add (time, onDone);
		} else {
			timeAction[time] += onDone; //委托可叠加，循序执行
		}
	}

	///<summery>
	///移除一个固定时间后的计时器
	///</summery>
	public void RemoveTimer (float time, Action onDone) {
		if (!timeAction.ContainsKey (time)) {
			return;
		} else {
			timeAction[time] -= onDone;
			if (timeAction[time] == null) {
				timeAction.Remove (time);
			}
		}
	}

	///<summery>
	///添加一个间隔执行的计时器
	/// time: 单纯的时间间隔
	///</summery>
	public void AddUpdateTimer (float time, Action onDone) {
		if (!updateTimerAction.ContainsKey (time)) {
			updateTimerAction.Add (time, new UpdateTimeNode (onDone));
		} else {
			updateTimerAction[time].act += onDone;
		}
	}

	///<summery>
	///移除一个间隔执行的计时器
	///</summery>
	public void RemoveUpdateTimer (float time, Action onDone) {
		if (!updateTimerAction.ContainsKey (time)) {
			return;
		} else {
			updateTimerAction[time].act -= onDone;
			if (updateTimerAction[time].act == null) {
				timeAction.Remove (time);
			}
		}
	}

	private void Update () {
		float now = Time.time;
		if (now - lastUpdateTime > timeInterval) {
			lastUpdateTime = now;
			CheckTime (now);
			CheckUpdateTime (now);
		}
	}

	///<summery>
	///固定时间检查器
	///</summery>
	private void CheckTime (float now) {
		foreach (var time in timeAction) {
			if (now > time.Key) {
				if (time.Value != null) {
					time.Value ();
				}
				timeAction.Remove (time.Key);
			} else {
				break; //由于时有序链表，如果第一个key时间都比now大，后面的肯定都大，所以不用继续遍历
			}
		}
	}

	///<summery>
	///检查间隔执行的计时器
	///</summery>
	private void CheckUpdateTime (float now) {
		foreach (var updateTime in updateTimerAction) {
			if (updateTime.Value != null) {
				if (now - updateTime.Value.lastUpdateTime > updateTime.Key) {
					updateTime.Value.act ();
					updateTime.Value.lastUpdateTime = now;
				}
			} else {
				updateTimerAction.Remove (updateTime.Key);
			}
		}
	}

}