CREATE TABLE bdWeb
Use bdWeb;
create table pais(
id int PRIMARY KEY IDENTITY(1,1),
pais varchar(100)
)
INSERT INTO pais Values(('Argentina'),('Bolivia'),('Brasil'),('Chile'),
('Colombia'),('Ecuador'),('Guayana'),('Paraguay'),('Peru'),
                ('Surinam'),('Uruaguay'),('Venezuela')
				)
create table departamento(
id int PRIMARY KEY IDENTITY(1,1),
departamento varchar(50),
id_pais INT REFERENCES pais(id)
)
INSERT INTO departamento values ('Jujuy',1),('Coordoba',1),('La Plata',1),('Tucuman',1),('Santa Fe',1),('Santa Cruz',1),
('Beni',2),('Cochabamba',2),('Chuquisaca',2),('La paz ',2),('Pando',2),('Potosi',2),('Santa Cruz',2),('Tarija',2),
('Acre',3),('Sao Pablo',3),('Parana',3),('Rio de Janeiro',3),('Botogroso',3),('Goias',3),('Amazonas',3)

 