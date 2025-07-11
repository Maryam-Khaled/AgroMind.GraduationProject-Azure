﻿using AgroMind.GP.Core.Entities.ProductModule;
using Shared;

using AgroMind.GP.Core.Contracts.Specifications.Contract;
namespace AgroMind.GP.Core.Specification
{
	public class ProductWithBrandAndCategorySpec : BaseSpecifications<Product, int>, ISpecification<Product, int>
	{
		//For Get All Products
		public ProductWithBrandAndCategorySpec(ProductQueryParams queryParams)
			: base(p => (!queryParams.BrandId.HasValue || p.BrandId == queryParams.BrandId)
		&& (!queryParams.CategoryId.HasValue || p.CategoryId == queryParams.CategoryId) && (!p.IsDeleted)
			&& (string.IsNullOrWhiteSpace(queryParams.SearchValue) || (p.Name.ToLower().Contains(queryParams.SearchValue.ToLower()))))

		// Filters products by BrandId and CategoryId if provided, otherwise includes all.

		{

			if (typeof(Product).GetProperty("Brand") != null)
				AddInclude(p => p.Brand);
			if (typeof(Product).GetProperty("Category") != null)
				AddInclude(p => p.Category);
			//Includes.Add(p => p.Supplier);

			switch (queryParams.sortingOptions)
			{
				case ProductSortingOptions.NameAscending:
					AddOrderBy(P => P.Name ?? string.Empty);
					break;
				case ProductSortingOptions.NameDescending:
					AddOrderByDescending(P => P.Name ?? string.Empty);
					break;
				case ProductSortingOptions.PriceAscending:
					AddOrderBy(P => P.Price);
					break;

				case ProductSortingOptions.PriceDescending:
					AddOrderByDescending(P => P.Price);
					break;
				default:
					break;
			}


		}

		//Get Product By Id
		public ProductWithBrandAndCategorySpec(int id) : base(p => p.Id == id && !p.IsDeleted)
		{
			if (typeof(Product).GetProperty("Brand") != null)
				AddInclude(p => p.Brand);
			if (typeof(Product).GetProperty("Category") != null)
				AddInclude(p => p.Category);
			//Includes.Add(p => p.Supplier);
		}
	}
}
