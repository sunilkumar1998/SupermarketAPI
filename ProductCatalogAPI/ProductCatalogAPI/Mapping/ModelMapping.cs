using AutoMapper;
using ProductCatalogAPI.Entities;
using ProductCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Mapping
{
	public class ModelMapping: Profile
	{
		public  ModelMapping() 
		{
			this.CreateMap<Staff, StaffModel>();
			this.CreateMap<Staff, StaffPostModel>().ReverseMap();
			this.CreateMap<Address, AddressModel>();
			this.CreateMap<Role, RoleModel>();
			this.CreateMap<Product, ProductModel>().ReverseMap();
			this.CreateMap<Product, ProductPostModel>().ReverseMap();
			this.CreateMap<Category, CategoryModel>();
			//.ForMember(c => c.role, o => o.MapFrom(m => m.Role.role))
			//.ForMember(c => c.Description, o => o.MapFrom(m => m.Role.Description))
			//.ForMember(c => c.addressLine1, o => o.MapFrom(m => m.Address.addressLine1))
			//.ForMember(c => c.addressLine2, o => o.MapFrom(m => m.Address.addressLine2))
			//.ForMember(c => c.city, o => o.MapFrom(m => m.Address.city))
			//.ForMember(c => c.state, o => o.MapFrom(m => m.Address.state))
			//.ForMember(c => c.pincode, o => o.MapFrom(m => m.Address.pincode));
		}
	}
}
