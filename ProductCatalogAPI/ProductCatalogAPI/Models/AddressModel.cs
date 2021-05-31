using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Models
{
	public class AddressModel
	{
		//public int addressId { get; set; }
		public string addressLine1 { get; set; }
		public string addressLine2 { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public long pincode { get; set; }
		//public ICollection<StaffModel> Staff { get; set; }
	}
}
