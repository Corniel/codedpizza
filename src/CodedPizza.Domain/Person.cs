using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodedPizza.Domain
{

	[DebuggerDisplay("{DebugToString()}")]
	public class Person
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string EmailAddress { get; set; }

		public virtual ICollection<PizzaSession> Sessions { get; set; }

		private string DebugToString()
		{
			return String.Format("Topic[{0}] {1}, Email: {2}, Sessions: {3}", Id, Name, EmailAddress, Sessions == null ? 0 : Sessions.Count);
		}
	}
}
