using System;

using UnityEngine;

namespace NoSuchStudio.Common {
    /// <summary>
    /// Base class for MonoBehaviours that want to use the extended logging capabilities of <see cref="UnityObjectLoggerExt"/>.
    /// By subclassing, you can use the methods without qualifying with 'this.', saving yourself from typing 5 characters!
    /// <code>LogWarn("My warning: {0}", warningMsg);</code>
    /// instead of
    /// <code>this.LogWarn("My warning: {0}", warningMsg);</code>
    /// </summary>
    public abstract class MonoBehaviourWithLogger : MonoBehaviour {
        
        public Logger logger {
            get {
                Type thisType = GetType();
                return UnityObjectLoggerExt.GetLoggerByType(thisType).logger;
            }
        }
        public LoggerConfig loggerConfig {
            get {
                Type thisType = GetType();
                return UnityObjectLoggerExt.GetLoggerByType(thisType).loggerConfig;
            }
        }
        
        protected void LogLog(string format, params object[] args) {
            UnityObjectLoggerExt.LogLog(this, format, args);
        }
        protected void LogWarn(string format, params object[] args) {
            UnityObjectLoggerExt.LogWarn(this, format, args);
        }
        protected void LogError(string format, params object[] args) {
            UnityObjectLoggerExt.LogError(this, format, args);
        }

        protected static void LogLog<T>(string format, params object[] args) {
            UnityObjectLoggerExt.LogLog<T>(format, args);
        }

        protected static void LogWarn<T>(string format, params object[] args) {
            UnityObjectLoggerExt.LogWarn<T>(format, args);
        }

        protected static void LogError<T>(string format, params object[] args) {
            UnityObjectLoggerExt.LogError<T>(format, args);
        }
    }
}