﻿using Helpers;
using Newtonsoft.Json;
using System;
using UnityEngine;

namespace CountlyModels
{
    [Serializable]
    class CountlyMetricModel
    {
        [JsonProperty("_os")]
        public string OS { get; set; }
        [JsonProperty("_os_version")]
        public string OSVersion { get; set; }
        [JsonProperty("_device")]
        public string Device { get; set; }
        [JsonProperty("_resolution")]
        public string Resolution { get; set; }
        [JsonProperty("_carrier")]
        public string Carrier { get; set; }
        [JsonProperty("_app_version")]
        public string AppVersion { get; set; }
        [JsonProperty("_density")]
        public string Density { get; set; }
        [JsonProperty("_store")]
        public string Store { get; set; }
        [JsonProperty("_browser")]
        public string Browser { get; set; }
        [JsonProperty("_browser_version")]
        public string BrowserVersion { get; set; }

        static CountlyMetricModel() { }
        private CountlyMetricModel() { }

        public static readonly CountlyMetricModel Metrics =
            new CountlyMetricModel
            {
                OS = CountlyHelper.OperationSystem,
                OSVersion = CountlyHelper.OperationSystem,
                Device = SystemInfo.deviceModel,
                Resolution = Screen.currentResolution.ToString(),
                //??
                Carrier = null,
                //??
                AppVersion = Application.version,
                Density = Screen.dpi.ToString(),
                //??
                Store = null,
                //??
                Browser = null,
                //??
                BrowserVersion = null,
            };
    }
}
