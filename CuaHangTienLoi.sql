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
ADD Sale money DEFAULT 0
	GO