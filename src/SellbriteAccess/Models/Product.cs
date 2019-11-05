﻿using System;
using Newtonsoft.Json;
using SellbriteAccess.Shared;

namespace SellbriteAccess.Models
{
	public class SellbriteProduct
	{
		public int Id { get; set; }
		public string Sku { get; set; }
		public string Brand { get; set; }
		public string Manufacturer { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal Cost { get; set; }
		[ JsonProperty( "category_name" ) ]
		public string CategoryName { get; set; }
		[ JsonProperty( "upc" ) ]
		public string UPC { get; set; }
		public int? Quantity { get; set; }
		public string Provider { get; set; }
		[ JsonProperty( "image_list") ]
		public string ImageList { get; set; }
		[ JsonProperty( "package_weight") ]
		public decimal Weight { get; set; }
		[ JsonProperty( "package_unit_of_weight") ]
		public string WeightUnits { get; set; }
		[ JsonProperty( "modified_at") ]
		private string ModifiedAtRFC3339 { get; set; }
		public DateTime ModifiedAtUtc => ModifiedAtRFC3339.FromRFC3339ToUtc();
	}

	public class SellbriteProductInventory
	{
		public string Sku { get; set; }
		[ JsonProperty( "warehouse_uuid" ) ]
		public string WarehouseUuid { get; set; }
		public int OnHand { get; set; }
		public int Available { get; set; }
		public int Reserved { get; set; }
	}
}
