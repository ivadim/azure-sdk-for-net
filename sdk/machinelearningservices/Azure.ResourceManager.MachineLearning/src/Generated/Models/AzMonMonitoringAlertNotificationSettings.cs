// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The AzMonMonitoringAlertNotificationSettings. </summary>
    public partial class AzMonMonitoringAlertNotificationSettings : MonitoringAlertNotificationSettingsBase
    {
        /// <summary> Initializes a new instance of AzMonMonitoringAlertNotificationSettings. </summary>
        public AzMonMonitoringAlertNotificationSettings()
        {
            AlertNotificationType = MonitoringAlertNotificationType.AzureMonitor;
        }

        /// <summary> Initializes a new instance of AzMonMonitoringAlertNotificationSettings. </summary>
        /// <param name="alertNotificationType"> [Required] Specifies the type of signal to monitor. </param>
        internal AzMonMonitoringAlertNotificationSettings(MonitoringAlertNotificationType alertNotificationType) : base(alertNotificationType)
        {
            AlertNotificationType = alertNotificationType;
        }
    }
}
