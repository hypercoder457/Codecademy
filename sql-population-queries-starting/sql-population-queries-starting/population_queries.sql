-- This is the first query:

SELECT DISTINCT year from population_years;

-- Add your additional queries below:
SELECT population
FROM population_years
ORDER BY country = 'Gabon' DESC;

SELECT country
FROM population_years
WHERE year = 2005
ORDER by country ASC
LIMIT 10;

SELECT DISTINCT country
FROM population_years
WHERE population > 100000000 
AND year = 2010;

SELECT country
FROM population_years
WHERE country LIKE '%Islands%';

SELECT population 
FROM population_years
WHERE year = 2010 - 2000;
