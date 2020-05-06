using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NoSuchStudio.Common;

public class MyClassWithLoggerC: MonoBehaviourWithLogger
{
    public void OnButtonClick() {
        LogLog("Hello World!");
    }
}
