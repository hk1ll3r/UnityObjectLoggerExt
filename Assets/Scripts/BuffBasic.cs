using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BuffBasic
{
    public class BuffBasic : MonoBehaviour
    {

        [SerializeField] Text label;

        public void AddBuffEffect()
        {
            label.text = "buffed :)";
            label.color = Color.red;
            Debug.Log("buffed :)");
        }

        public void RemoveBuffEffect()
        {
            label.text = "no buff :(";
            label.color = Color.black;
            Debug.Log("debuffed :(");
        }

        public void OnBuff()
        {
            StopAllCoroutines();
            AddBuffEffect();
            RunDelayed(2f, RemoveBuffEffect);
        }

        protected IEnumerator DelayedCoroutine(float delay, System.Action a)
        {
            yield return new WaitForSecondsRealtime(delay);
            a();
        }

        protected Coroutine RunDelayed(float delay, System.Action a)
        {
            return StartCoroutine(DelayedCoroutine(delay, a));
        }
    }
}