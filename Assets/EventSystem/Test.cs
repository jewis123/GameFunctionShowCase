using System;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionRealise.EventSystem
{
    
    public class Test : MonoBehaviour
    {
        public void EventTest1(){
            ModEventSystem.instance.EventMgr.SendEvent(EventEnum.EventA,"EventA Happened");
        }

        public void EventTest2(){
             ModEventSystem.instance.EventMgr.SendEvent(EventEnum.EventB,"EventB Happened",2);
        }

        public void EventTest3(){
            ModEventSystem.instance.EventMgr.SendEvent(EventEnum.EventC,"EventC Happened",2);
        }
    }
}