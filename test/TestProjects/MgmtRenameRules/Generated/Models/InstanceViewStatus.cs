// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtRenameRules.Models
{
    /// <summary>
    /// Instance view status.
    /// Serialized Name: InstanceViewStatus
    /// </summary>
    public partial class InstanceViewStatus
    {
        /// <summary> Initializes a new instance of InstanceViewStatus. </summary>
        public InstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of InstanceViewStatus. </summary>
        /// <param name="code">
        /// The status code.
        /// Serialized Name: InstanceViewStatus.code
        /// </param>
        /// <param name="level">
        /// The level code.
        /// Serialized Name: InstanceViewStatus.level
        /// </param>
        /// <param name="displayStatus">
        /// The short localizable label for the status.
        /// Serialized Name: InstanceViewStatus.displayStatus
        /// </param>
        /// <param name="message">
        /// The detailed status message, including for alerts and error messages.
        /// Serialized Name: InstanceViewStatus.message
        /// </param>
        /// <param name="time">
        /// The time of the status.
        /// Serialized Name: InstanceViewStatus.time
        /// </param>
        internal InstanceViewStatus(string code, StatusLevelType? level, string displayStatus, string message, DateTimeOffset? time)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
        }

        /// <summary>
        /// The status code.
        /// Serialized Name: InstanceViewStatus.code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// The level code.
        /// Serialized Name: InstanceViewStatus.level
        /// </summary>
        public StatusLevelType? Level { get; set; }
        /// <summary>
        /// The short localizable label for the status.
        /// Serialized Name: InstanceViewStatus.displayStatus
        /// </summary>
        public string DisplayStatus { get; set; }
        /// <summary>
        /// The detailed status message, including for alerts and error messages.
        /// Serialized Name: InstanceViewStatus.message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The time of the status.
        /// Serialized Name: InstanceViewStatus.time
        /// </summary>
        public DateTimeOffset? Time { get; set; }
    }
}
