GO
CREATE TABLE PRODUCTS (
  product_id int PRIMARY KEY IDENTITY NOT NULL,
  name_product varchar(100)
);
GO

GO
CREATE TABLE CATEGORIES (
  category_id int PRIMARY KEY IDENTITY NOT NULL,
  name_category varchar(100),
);
GO

GO
CREATE TABLE LISTS (
  list_id int PRIMARY KEY IDENTITY NOT NULL,
  products_id int REFERENCES PRODUCTS (product_id),
  categories_id int REFERENCES CATEGORIES (category_id)
);
GO

GO
INSERT INTO PRODUCTS(name_product) VALUES ('Basil');
INSERT INTO PRODUCTS(name_product) VALUES ('Ham');
INSERT INTO PRODUCTS(name_product) VALUES ('Chicken');
INSERT INTO PRODUCTS(name_product) VALUES ('Pepper');

INSERT INTO CATEGORIES(name_category) VALUES ('grass');
INSERT INTO CATEGORIES(name_category) VALUES ('spice');
INSERT INTO CATEGORIES(name_category) VALUES ('herb');
INSERT INTO CATEGORIES(name_category) VALUES ('meat');
INSERT INTO CATEGORIES(name_category) VALUES ('fruits');

INSERT INTO LISTS(products_id, categories_id) VALUES(1, 1);
INSERT INTO LISTS(products_id, categories_id) VALUES(1, 2);
INSERT INTO LISTS(products_id, categories_id) VALUES(1, 3);
INSERT INTO LISTS(products_id, categories_id) VALUES(2, 4);
INSERT INTO LISTS(products_id, categories_id) VALUES(3, 4);
INSERT INTO LISTS(products_id, categories_id) VALUES(4, NULL);
GO

GO
SELECT  name_product, name_category from PRODUCTS
right Join LISTS
on (PRODUCTS.product_id =LISTS.products_id)
left join CATEGORIES
on ( LISTS.categories_id=CATEGORIES.category_id)
group by
   PRODUCTS.name_product,
   CATEGORIES.name_category
GO
