using ProductCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Models
{
	public class StaffModel
	{
		public int staffId { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string gender { get; set; }
		public long phone { get; set; }

		//public int roleId { get; set; }
		//public int addressId { get; set; }


		public AddressModel Address { get; set; }
		public RoleModel Role { get; set; }

		//public int roleId { get; set; }
		//public int addressId { get; set; }
		//public Role Role { get; set; }
		//public Address Address { get; set; }
		//public string role { get; set; }		
		//public string Description { get; set; }
		//public string addressLine1 { get; set; }
		//public string addressLine2 { get; set; }
		//public string city { get; set; }
		//public string state { get; set; }
		//public long pincode { get; set; }
	}
}
