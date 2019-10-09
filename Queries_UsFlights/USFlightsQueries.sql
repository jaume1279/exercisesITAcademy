1)

SELECT 
    COUNT(*)
FROM
    flights;

___________________

2)

SELECT 
    origin, AVG(ArrDelay) as prom_arribades, AVG(DepDelay) as prom_sortides
FROM
    flights
GROUP BY origin;

____________________

3)

SELECT 
    origin, colYear, colMonth, AVG(ArrDelay) as prom_arribades
FROM
    flights
GROUP BY colMonth , colYear , origin
ORDER BY origin , colYear , colMonth;

____________________

4)

SELECT 
    usairports.city,
    flights.colYear,
    flights.colMonth,
    AVG(flights.ArrDelay) as prom_arribades
FROM
    flights
        INNER JOIN
    usairports ON flights.origin = usairports.iata
GROUP BY colMonth , colYear , origin
ORDER BY city , colYear , colMonth;

______________________

5)

SELECT 
    UniqueCarrier,
    colYear,
    colMonth,
    AVG(ArrDelay) AS avg_delay,
    SUM(cancelled) AS total_cancelled
FROM
    flights
WHERE
    cancelled = '1'
GROUP BY uniquecarrier , colYear , colMonth
ORDER BY SUM(cancelled) DESC;

________________________

6)

SELECT 
    tailnum, SUM(distance) AS totalDistance
FROM
    flights
GROUP BY tailnum
ORDER BY SUM(distance) DESC;

__________________________

7)


SELECT 
    uniquecarrier, AVG(ArrDelay) AS avg_delay
FROM
    flights
GROUP BY uniquecarrier
ORDER BY AVG(arrdelay) DESC
LIMIT 10;

____________________________

