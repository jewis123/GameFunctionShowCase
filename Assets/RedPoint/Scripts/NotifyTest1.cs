using UnityEngine;

///<summery>
///定义一系列用来测试的按钮触发函数
///说明：为了便于测试，将小红点和通知标志放在了一起，实际来说小红点应该在视图层，通知标志在数据层
///</summery>
namespace RedPoint.Scripts {
    public class NotifyTest1 : NotifyTest {
        public CommonRedPoint p1;

        private void Start () {
            NotifyEnabled = true;
            SetParent ();
            p1.SetData (Mark);
        }

        public override void SetParent () {
            Mark.SetParentNotify (ModBag.instance.Notify);
        }
    }
}