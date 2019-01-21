using System;

///<summery>
///说明：
///数据
///         父节点，控制消息传递
/// 	    子节点消息数，控制消息分层
///			通知变更代理，控制通知变更行为
///行为
///         状态获取、父节点设置
///			更改小红点状态
///			更改父节点状态 
///         状态重置
///         子节点状态清除        
///</summery>
namespace RedPoint.Scripts {
	public class NotifyMark {

		private NotifyMark parentNode = null;
		private int SubNotifyCount = 0;

		/* 判断通知是否显示 */
		public bool IsNotify { get; private set; }
		public static implicit operator bool (NotifyMark notify) { //定义隐式转换
			return notify != null && notify.IsNotify;
		}

		/* 设置父节点 */
		public void SetParentNotify (NotifyMark notify) {
			parentNode = notify;
		}

		/* 设置状态变更代理 */
		private Action<bool> _OnChange = null; //定义bool类型，用来确定是否显示小红点
		public event Action<bool> OnChange {
			add {
				_OnChange += value;
				value (IsNotify);
			}
			remove {
				_OnChange -= value;
			}
		}

		/* 构造函数初始化状态 */
		public NotifyMark () {
			IsNotify = false;
		}

		/* 更新状态 */
		public void ChangeNotify (bool isNotify) {
			if (isNotify != IsNotify) {
				IsNotify = isNotify;

				//如果有父节点就向上传递
				if (parentNode != null) {
					parentNode.OnSubNotifyChange (isNotify);
				}

				// 变更小红点显示
				if (_OnChange != null) {
					_OnChange (IsNotify);
				}
			}
		}

		/* 修改父节点小红点状态 */
		private void OnSubNotifyChange (bool isNotify) {
			if (isNotify) {
				SubNotifyCount++;
			} else {
				SubNotifyCount--;
			}
			ChangeNotify (SubNotifyCount > 0);
		}

		/* 清除子节点小红点记录 */
		public void CleanSub () {
			SubNotifyCount = 0;
			ChangeNotify (false);
		}

		/* 重置信息 */
		public void Reset () {
			parentNode = null;
			SubNotifyCount = 0;
			ChangeNotify (false);
			_OnChange = null;
		}
	}
}