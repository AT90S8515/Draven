﻿﻿using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.login.Session")]
    public class Session
    {
        [SerializedName("token")]
        public String Token { get; set; }

        [SerializedName("password")]
        public String Password { get; set; }

        [SerializedName("accountSummary")]
        public AccountSummary Summary { get; set; }
    }
}
