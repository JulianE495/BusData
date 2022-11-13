SELECT tblConductores.nombre, tblBus.placa, tblRutas.ruta FROM tblConductores 
INNER JOIN tblBus ON (tblConductores.nombre = tblBus.chofer)
INNER JOIN tblRutas ON (tblBus.Ruta = tblRutas.ruta)
WHERE tblConductores.Asignado = 'Si'


SELECT * FROM tblConductores
SELECT * FROM tblBus
SELECT * FROM tblRutas


UPDATE	tblRutas SET Asignado = 'No' WHERE id = 7