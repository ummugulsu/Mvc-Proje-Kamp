﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{

	public class Heading
	{
		[Key]
		public int HeadingID { get; set; }
		[StringLength(50)]
		public string HeadingName { get; set; }
		public DateTime HeadingDate { get; set; }

		public int CategoryID { get; set; }
		public virtual Category Category{ get; set; }

		public ICollection<Content>  Content{ get; set; }
	}
}
