using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedPizza.Domain
{

	public class Session
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

	}

}
