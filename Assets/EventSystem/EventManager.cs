using System;
using System.Collections.Generic;
using FunctionRealise.EventSystem;
using UnityEngine;

public class EventManager  {
	///<summery>
	///存放事件监听者
	///</summery>
	protected Dictionary<EventEnum, Action<EventEnum, object[]>> eventListeners = new Dictionary<EventEnum, Action<EventEnum, object[]>> ();

	/// <summary>
	/// 添加事件监听者
	/// </summary>
	/// <param name="type">监听的事件类型</param>
	/// <param name="listenerEvent">监听回调，EventEnum接收事件供判，object[] 参数集合</param>
	public void AddListener (EventEnum type, Action<EventEnum, object[]> listenerEvent) {
		if (eventListeners.ContainsKey (type)) {
			eventListeners[type] += listenerEvent;
		} else {
			eventListeners.Add (type, listenerEvent);
		}
	}

	/// <summary>
	/// 移除事件监听者
	/// </summary>
	/// <param name="type">监听类型</param>
	/// <param name="listenerEvent">监听回调</param>
	public void RemoveListener (EventEnum type, Action<EventEnum, object[]> listenerEvent) {
		if (eventListeners.ContainsKey (type)) {
			eventListeners[type] -= listenerEvent;
		}
	}

	/// <summary>
	/// 发送产生的事件
	/// </summary>
	/// <param name="type"></param>
	/// <param name="args"></param>
	public void SendEvent (EventEnum type, params object[] args) {
		if (eventListeners.Count == 0) {
			return;
		}

		InvokeListener (type, args);
	}

	///<summery>
	///唤醒监听者事件回调
	///</summery>
	public void InvokeListener (EventEnum type, object[] args) {
		if (!eventListeners.ContainsKey (type)) {
			return;
		}

		eventListeners[type] (type, args);
	}

	public void Reset () {
		eventListeners.Clear ();
	}
}