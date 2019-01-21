using UnityEngine;

namespace SimpleFactory
{
    public class BossCardItem:CardItem
    {
        public override void SayHello(){
            Debug.Log("我是子类");
        }
    }
}