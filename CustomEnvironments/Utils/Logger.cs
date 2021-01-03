using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

using IPALogger = IPA.Logging.Logger;

namespace CustomEnvironments.Utils {
    internal static class Logger {

        internal static IPALogger IPALogger;


        /// <summary>
        /// Normal string logging
        /// </summary>
        internal static void Log(string message, IPALogger.Level level = IPALogger.Level.Info) {
            IPALogger.Log(level, message);
        }

        internal static void Log(object[] array, IPALogger.Level level = IPALogger.Level.Info) {
            foreach (var item in array) {
                Log(item.ToString(), level);
            }
        }

        internal static void Log<T>(List<T> list, IPALogger.Level level = IPALogger.Level.Info) {
            foreach (var item in list) {
                Log(item.ToString(), level);
            }
        }

        internal static void Log(GameObject gameObject, IPALogger.Level level = IPALogger.Level.Info) {
            Log(gameObject.name, level);
        }
    }
}
