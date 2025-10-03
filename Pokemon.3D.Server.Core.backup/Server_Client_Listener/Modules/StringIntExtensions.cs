using System;

namespace Pokemon_3D_Server_Core.Server_Client_Listener.Modules
{
    public static class StringIntExtensions
    {
        public static int ToInt(this string s, int defaultValue = 0)
        {
            if (int.TryParse(s, out var v)) return v;
            return defaultValue;
        }
    }
}


