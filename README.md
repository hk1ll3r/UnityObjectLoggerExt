# UnityObjectLoggerExt
This utility classes enable you to write shorter log messages with more common info in Unity.

Copy [UnityObjectLoggerExt.cs](UnityObjectLoggerExt.cs) (included in the root of the project) to your Assets folder.  

Now you can use `LogLog`, `LogWarn` and `LogError` extension methods.
```csharp
using NoSuchStudio.Common;

public class MyClassB : MonoBehaviour {
    void Start() {
        this.LogLog("Hello World!");
    }
}
```
![output](https://raw.githubusercontent.com/hk1ll3r/UnityObjectLoggerExt/master/console.png)

Optionally you can copy over [MonoBehaviourWithLogger.cs](MonoBehaviourWithLogger.cs) to your Assets folder and omit `this.`. It produces the same output as above.
```csharp
using NoSuchStudio.Common;

public class MyClassB: MonoBehaviourWithLogger
{
    void Start() {
        LogLog("Hello World!");
    }
}
```

To learn more about this project, read this blog post:
https://medium.com/@nosuchstudio/improve-unitys-logging-with-this-class-fc99c91f5564
