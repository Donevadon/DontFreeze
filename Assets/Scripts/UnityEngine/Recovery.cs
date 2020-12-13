using System;
using System.Collections.Generic;
using Game.Entities;
using UnityEngine;

namespace Game.UnityEngine
{
    public class Recovery : MonoBehaviour,IObservable
    {
        private static Recovery recovery;
        private static List<IObserver> observers;
        private Recovery()
        {

        }

        public static Recovery GetInstance()
        {
            return recovery;
        }

        private void Awake() 
        {
            recovery = this;
            observers = new List<IObserver>();
        }

        private void Update() 
        {
            Recover();    
        }

        private void Recover()
        {
            for(int i = 0; i< observers.Count;i++)
            {
                observers[i].Action();
            }
        }

        public void Add(IObserver observer)
        {
            foreach(var Observer in observers)
            {
                if(Observer == observer) return;
            }
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}