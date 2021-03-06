﻿using System;

namespace StatelessTest
{

    /// <summary>
    /// An enum containing the possible events that trigger a potential change in occupancy state
    /// </summary>
    [Serializable]
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum Trigger
    {
        DoorOpens,
        DoorCloses,
        SensorActivity,
        AlarmFullSet,
        AlarmPartSet,
        AlarmUnset,
        OccupancyTimerExpires,
        ChildOccupied
    }
}
