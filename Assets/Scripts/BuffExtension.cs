using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BuffExtension
{
    public class BuffExtension : MonoBehaviour
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
            this.RunDelayed(2f, RemoveBuffEffect);
        }

    }

    public static class MonoBehaviourExt
    {
        public static IEnumerator DelayedCoroutine(this MonoBehaviour mb, float delay, System.Action a)
        {
            yield return new WaitForSecondsRealtime(delay);
            a();
        }

        public static Coroutine RunDelayed(this MonoBehaviour mb, float delay, System.Action a)
        {
            return mb.StartCoroutine(mb.DelayedCoroutine(delay, a));
        }
    }
}