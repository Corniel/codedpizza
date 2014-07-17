using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodedPizza.Domain
{
	[DebuggerDisplay("{DebugToString()}")]
	public class Topic
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Person> Presenters { get; set; }

		private string DebugToString()
		{
			return String.Format("Topic[{0}] {1}, Desc: {2}, Presenters: {3}", Id, Name, Description, Presenters == null ? 0 : Presenters.Count);
		}
	}
}
