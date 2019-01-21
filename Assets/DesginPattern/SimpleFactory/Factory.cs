using System.Collections;
using System.Collections.Generic;
using SimpleFactory;
using UnityEngine;

public class Factory 
{
    CardItem card;
        public CardItem CreateCardItem (int type) {
            switch (type) {
                case 3:
                    card = new BossCardItem ();
                    break;
                default:
                    card = new CardItem ();
                    break;
            }
            return card;
        }
}
