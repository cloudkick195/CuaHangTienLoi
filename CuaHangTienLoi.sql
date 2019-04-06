USE ql_store

ALTER TABLE Products
ADD DateManufacture date,
	DateExpiration date
	GO

ALTER TABLE Products
ADD CONSTRAINT CN_DateManufactureExpiration CHECK (
    DateManufacture <= DateExpiration
     );

ALTER TABLE Products
ADD sale money DEFAULT 0
	GO