using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedPizza.Domain
{

	public class Person
	{

		public int Id { get; set; }

		public string Name { get; set; }

		public string EmailAddress { get; set; }

		public virtual ICollection<Session> Sessions { get; set; }

	}

}
