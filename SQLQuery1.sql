SELECT * FROM tblConductores
SELECT * FROM tblBus
SELECT * FROM tblRutas

SELECT * FROM tblConductores WHERE Asignado = 'No'

UPDATE tblConductores SET Asignado = 'No' WHERE id = 2
UPDATE tblConductores SET ruta = 'NULL' WHERE id = 2

UPDATE tblBus SET Asignado = 'No' WHERE id = 2
UPDATE tblBus SET ruta = 'NULL' WHERE id = 2

UPDATE tblRutas SET Asignado = 'No' WHERE id = 6


CREATE TABLE tblRutas (
	id int IDENTITY(1,1) PRIMARY KEY,
	InicioR varchar(50),
	FinR varchar(50)
)

DELETE FROM tblRutas 
INSERT INTO tblRutas (nombre, InicioR, FinR, Asignado, Chofer, Bus)  values ('vv', 'Autopista las americas, Km 12, La llave', 'Hnas Mirabal esq Charles G La sirena, Villa Mella', 'No', 'NULL', 'NULL')