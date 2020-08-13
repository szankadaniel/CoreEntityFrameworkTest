create table "CatalogBrandsAndCatalogItems"
(
	"CatalogBrandId" int4 not null,
	"CatalogItemId" int4 not null,
);

alter table "CatalogBrandsAndCatalogItems" 
add constraint "FK_CatalogBrandId" 
foreign key ("CatalogBrandId") 
references "CatalogBrands" ("ID") match full;

alter table "CatalogBrandsAndCatalogItems" 
add constraint "FK_CatalogItemId" 
foreign key ("CatalogItemId") 
references "CatalogItems" ("ID") match full;

INSERT INTO public."CatalogBrandsAndCatalogItems"
	("CatalogBrandId", "CatalogItemId")
values
	(1, 2)
	,(1, 4)
	,(1, 5)
	;
	

