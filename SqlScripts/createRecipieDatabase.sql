USE master

GO

IF (DB_ID('Recipes') IS NOT NULL)
BEGIN
	USE master;
	DROP TABLE Recipes.dbo.recipeIngredients;
	DROP TABLE Recipes.dbo.recipe;
	DROP TABLE Recipes.dbo.recipeUser;
	DROP TABLE Recipes.dbo.ingredients;
	DROP TABLE Recipes.dbo.units;	
	DROP DATABASE Recipes;
END

GO

CREATE DATABASE Recipes;

GO

USE Recipes

GO

CREATE TABLE recipeUser (
	recipeUserId INT PRIMARY KEY,
	recipeUserName VARCHAR(50) NOT NULL,
	recipeUserPass VARCHAR(12) NOT NULL
);

GO

CREATE SEQUENCE recipeUserSeq
	START WITH 1
	INCREMENT BY 1;

GO

CREATE TABLE ingredients (
	ingredientId INT PRIMARY KEY,
	ingredientName VARCHAR(500) NOT NULL,
	ingredientDescription VARCHAR(2000)
);

GO

CREATE SEQUENCE ingredientsSeq
	START WITH 1
	INCREMENT BY 1;

GO

CREATE TABLE units (
	unitName VARCHAR(50) PRIMARY KEY,
	unitAbbreviation VARCHAR(5),
	unitMultiplier DECIMAL(18,4)
)

GO

CREATE TABLE recipe (
	recipeId INT PRIMARY KEY,
	recipeUserId INT,
	recipeName VARCHAR(50) NOT NULL,
	recipeDescription VARCHAR(200),
	directions VARCHAR(2000),
	CONSTRAINT fkRecipeRecipeUserId
		FOREIGN KEY (recipeUserId)
		REFERENCES recipeUser (recipeUserId) 
);

GO

CREATE SEQUENCE recipeSeq
	START WITH 1
	INCREMENT BY 1;

GO

CREATE TABLE recipeIngredients (
	recipeId INT NOT NULL,
	ingredientId INT NOT NULL,
	amount DECIMAL(18,4) NOT NULL,
	unitName VARCHAR(50) NOT NULL
	CONSTRAINT fkRecipeIngredientsRecipeId
		FOREIGN KEY (recipeId)
		REFERENCES recipe (recipeId),
	CONSTRAINT fkRecipeIngredientsIngredientId
		FOREIGN KEY (ingredientId)
		REFERENCES ingredients (ingredientId),
	CONSTRAINT fkRecipeIngredientsUnitName
		FOREIGN KEY (unitName)
		REFERENCES units (unitName)
);

GO

--Seed the tables with some base data

INSERT INTO recipeUser 
VALUES 
	(NEXT VALUE FOR recipeUserSeq, 'admin', 'admin');

GO

-- Ingredient descriptions taken from https://www.northernbrewer.com
INSERT INTO ingredients
VALUES
	(NEXT VALUE FOR ingredientsSeq, 'Belgian Biscuit Malt', 'From the land where brewing takes on a religious devotion. Belgian Biscuit® malt is a unique lightly toasted malt that contributes a slew of warm, earthy, toasted malt flavors and aromas. It promotes a light to medium garnet brown color and imparts a toasty finish to the beer with complex nutty flavors and an aroma of baking bread. It can be used in small percentages to add complexity and color to lighter beers, or in larger amounts in dark beers such as nut brown ales to deliver the characteristic nutty, toasted biscuit flavors. 24.5°L'),
	(NEXT VALUE FOR ingredientsSeq, 'Mosaic Leaf Hops', 'A dual-purpose hop, bred from Simcoe®, Mosaic hops features a wide range of aromas and flavors that transfers favorably into a variety of styles. Mosaic offers an incredible combination of floral, fruity, and earthy notes. Everything from citrus, pine, earth, blueberry, tangerine, papaya, rose, blossoms, grass and bubble gum.'),
	(NEXT VALUE FOR ingredientsSeq, 'Danstar American West Coast Ale Dry Yeast', 'BRY-97 American West Coast Yeast was selected from the Siebel Institute Culture Collection and is used by a number of commercial breweries to produce different types of ale.'),
	(NEXT VALUE FOR ingredientsSeq, 'Water', 'Water is a transparent, tasteless, odorless, and nearly colorless chemical substance that is the main constituent of Earth''s streams, lakes, and oceans, and the fluids of most living organisms. Its chemical formula is H2O, meaning that each of its molecules contains one oxygen and two hydrogen atoms that are connected by covalent bonds. Strictly speaking, water refers to the liquid state of a substance that prevails at standard ambient temperature and pressure; but it often refers also to its solid state (ice) or its gaseous state (steam or water vapor). It also occurs in nature as snow, glaciers, ice packs and icebergs, clouds, fog, dew, aquifers, and atmospheric humidity.');

GO

INSERT INTO units
VALUES
	('kilograms', 'kg', 1000),
	('grams', 'g', 1),
	('miligrams', 'mg', .001),
	('liters', 'l', 1);

GO

INSERT INTO recipe
VALUES
	(NEXT VALUE FOR recipeSeq, 1, 'Test Recipe', 'This is a test recipie created for tesing the database', 'Directions go here');

GO

INSERT INTO recipeIngredients
VALUES
	(1, 1, 5, 'kilograms'),
	(1, 2, 500, 'grams'),
	(1, 3, 200, 'miligrams'),
	(1, 4, 10, 'liters');
