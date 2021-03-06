﻿using System;
using SellbriteAccess.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SellbriteAccess.Services.Products
{
	public interface ISellbriteProductsService : IDisposable
	{
		Task< SellbriteProduct > GetProductBySkuAsync( string sku, CancellationToken token );
		Task< SellbriteProductInventory > GetSkuInventory( string sku, string warehouseId, CancellationToken token );
		Task< SellbriteProductInventory[] > GetAllSkusInventory( string warehouseId, CancellationToken token );
		Task UpdateSkuQuantityAsync( string sku, int quantity, string warehouseId, CancellationToken token );
		Task UpdateSkusQuantitiesAsync( Dictionary< string, int > skusQuantities, string warehouseId, CancellationToken token );
		Task< Warehouse[] > GetWarehousesAsync( CancellationToken token );
		Task< IEnumerable< SellbriteProduct > > GetProductsByDateModifiedAsync( DateTime startDateUtc, DateTime endDateUtc, CancellationToken token );
	}
}
