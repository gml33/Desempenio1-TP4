hay que crear la base de datos
el script seria:

CREATE TABLE Directores (
	id INT PRIMARY KEY IDENTITY (1,1),
	apellido VARCHAR(50) not null,
	nombre VARCHAR(50) not null
);
CREATE TABLE Peliculas (
	id INT PRIMARY KEY IDENTITY (1,1),
	nombre VARCHAR(150) not null,
	idDirector INT,
	FOREIGN KEY (idDirector) REFERENCES Directores(id)
);
