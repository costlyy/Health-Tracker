using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Health_Tracker;

namespace Health_Tracker
{
	public enum EventType
	{
		Seizure,
		Vision,
	}

	public sealed class EventDurationType
	{
		public static List<string> Data()
		{
			return new List<string>
			{
				"<10 Seconds",
				"10-60 Seconds",
				"1 Minute",
				"2 Minutes",
				"3+ Minutes"
			};
		}
	}

	public sealed class EventData
	{
		public DateTime Date { get; set; }
		public EventType Type { get; set; }
		public int HighLevel { get; set; }
		public EventDurationType Duration { get; set; }
		public string Triggers { get; set; }
		public string Comments { get; set; }
	}
}
