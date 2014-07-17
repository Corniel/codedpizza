using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CodedPizza.Domain
{

	[DebuggerDisplay("{DebugToString()}")]
	public class PizzaSession
	{
		public int Id { get; set; }

		public DateTime? StartTime { get; set; }

		public DateTime? EndTime { get; set; }

		public Topic Topic { get; set; }

		public IEnumerable<Person> Everyone
		{
			get { return Presenters.Concat(Attendees); }
		}

		public ICollection<Person> Attendees { get; set; }

		public ICollection<Person> Presenters { get; set; }

		private string DebugToString()
		{
			return String.Format("PizzaSession[{0}] {1}, Time: {1:yyyy-MM-dd hh\\:mm}-{2:yyyy-MM-dd hh\\:mm}, Topic: {3}, Attendees: {4}, {5}", Id, StartTime, EndTime, Topic, Attendees == null ? 0 : Attendees.Count, Attendees == null ? 0 : Presenters.Count);
		}
	}
}
