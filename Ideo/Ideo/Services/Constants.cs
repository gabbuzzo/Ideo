﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Ideo.Services
{
   public class Constants
    {
        public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:57003/api/" : "https://localhost:57003/api/";
    }
}