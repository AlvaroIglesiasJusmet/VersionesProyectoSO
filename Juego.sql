DROP DATABASE IF EXISTS M6Juego;
CREATE DATABASE M6Juego;

USE M6Juego;

CREATE TABLE jugador(
    nick VARCHAR(30) NOT NULL,
    passwd VARCHAR(30) NOT NULL,
    PRIMARY KEY (nick)
)ENGINE= InnoDB;

CREATE TABLE partida(
    id INT NOT NULL,
    ganador VARCHAR(30) NOT NULL,
    FOREIGN KEY (ganador) REFERENCES jugador (nick)
   
)ENGINE= InnoDB;

CREATE TABLE historia(
   idpregunta INT NOT NULL,
   preguntas VARCHAR(300) NOT NULL,
   opcion1 VARCHAR(50) NOT NULL,
   opcion2 VARCHAR(50) NOT NULL,
   opcion3 VARCHAR(50) NOT NULL,
   respuesta VARCHAR(50) NOT NULL


)ENGINE= InnoDB;
   
CREATE TABLE deporte(
   idpregunta INT NOT NULL,
   preguntas VARCHAR(300) NOT NULL,
   opcion1 VARCHAR(50) NOT NULL,
   opcion2 VARCHAR(50) NOT NULL,
   opcion3 VARCHAR(50) NOT NULL,
   respuesta VARCHAR(50) NOT NULL
 

)ENGINE= InnoDB;

CREATE TABLE ciencia(
   idpregunta INT NOT NULL,
   preguntas VARCHAR(300) NOT NULL,
   opcion1 VARCHAR(50) NOT NULL,
   opcion2 VARCHAR(50) NOT NULL,
   opcion3 VARCHAR(50) NOT NULL,
   respuesta VARCHAR(50) NOT NULL
 
   
)ENGINE= InnoDB;

CREATE TABLE puntuaciones(
    player VARCHAR(30) NOT NULL,
    idpartida INT NOT NULL,
    puntos INT NOT NULL
   

)ENGINE= InnoDB;

INSERT INTO jugador VALUES('Juan','Contra1');
INSERT INTO jugador VALUES('Pedro','Contra2');
INSERT INTO jugador VALUES('Sara','Contra3');
INSERT INTO jugador VALUES('Bryan','Contra4');
INSERT INTO jugador VALUES('Michelle','Contra5');



INSERT INTO historia VALUES('1','Cual fue el primer país en aprobar el sufragio femenino?','Nueva Zelanda','Estados Unidos','Sud Africa', 'Nueva Zelanda');

INSERT INTO historia VALUES('2','En que anyo llego el hombre a la Luna?','1969','1979','2007','1969');

INSERT INTO historia VALUES('3','Que importante batalla tuvo lugar en 1815?','La batalla de Waterloo','Batalla del Somne','Batalla de los 100','La batalla de Waterloo');

INSERT INTO historia VALUES('4','Quien fue el primer presidente de la democracia española tras el franquismo?','Mariano Rajoy','Leopoldo Calvo Sotelo','Adolfo Suarez','Adolfo Suarez');

INSERT INTO historia VALUES('5','Cuantos anyos duro la Guerra de los Cien Anyos?','85','116','99','116');

INSERT INTO historia VALUES('6','Quien fue el primer presidente de Estados Unidos?','Churchill','George Washintong','Lincon','George Washintong');

INSERT INTO historia VALUES('7','En que idioma están escritos los manuscritos mas antiguos pertenecientes a la parte de la Biblia que hoy conocemos como Nuevo Testamento?','Ebreo','Arabe','Griego Antiguo','Griego Antiguo');

INSERT INTO historia VALUES('8','Que filosofo de la Antigua Grecia creia que el elemento del que estan compuestas todas las cosas es el agua?','Tales de Mileto','Anaxagoras','Platon','Tales de Mileto');

INSERT INTO historia VALUES('9','Quienes fueron, segun la leyenda, los dos hermanos fundadores de la ciudad de Roma?','Romulo y Remo','Los Hermanos Augusto','Julio y Pablo Cesar','Romulo y Remo');

INSERT INTO historia VALUES('10','En que anyo se hundio el transatlantico Titanic?','1920','1912','1917','1912');

INSERT INTO historia VALUES('11','Que famoso filosofo fue maestro de Alejandro Magno durante cinco anyos?','Socrates','Aristoteles','Platon','Aristoteles');

INSERT INTO historia VALUES('12','Que inicio la Segunda Guerra Mundial?','Invasion nazi a Polonia','Asesinato del archiduque Francisco Fernando','Hitler invadio Austria','Invasion nazi a Polonia');

INSERT INTO historia VALUES('13','Donde se han encontrado principalmente pinturas del periodo Paleolitico?','No hay pinturas del Peleolitico','En cuevas','En vasijas decoradas','En cuevas');

INSERT INTO historia VALUES('14','De que nacionalidad era Adolf Hitler?','Nacio en Alemania','Nacio en Polonia','Nacio en Austria','Nacio en Austria');

INSERT INTO historia VALUES('15','Quien dijo primero que la tierra giraba alrededor del sol?','Aristarco de Samos','Galileo Galilei','Nicolas Copernico','Aristarco de Samos');

INSERT INTO historia VALUES('16','En que anyo cayo el Imperio Romano de Occidente?','572','476','27a.C.','476');

INSERT INTO historia VALUES('18','Quien fue el primer hombre que piso la luna?','Valentina Tereshckova','Neil Amstrong','Buzz Aldrin','Neil Amstrong');

INSERT INTO historia VALUES('19','Quien inicio la Revolucion cultural China?','Deng Xiaoping','Mao Zedong','Jiang Zemin','Mao Zedong');




INSERT INTO ciencia VALUES('1','Como se llama el componente minimo que forma a los seres vivos?','Tejido','Particula','Celula','Celula');

INSERT INTO ciencia VALUES('2','El proceso por el que una celula se divide para formar dos celulas hijas se llama:','Segregacion','Mitosis','Meiosis','Mitosis');

INSERT INTO ciencia VALUES('3','Alrededor de que porcentaje de La Tierra esta cubierta por agua?','50 por cien','70 por cien','60 por cien','70 por cien');

INSERT INTO ciencia VALUES('4','Cuantos dias tarda La Tierra en viajar alrededor del Sol?','365','364','366','365');

INSERT INTO ciencia VALUES('5','Que mineral se encuentra en una solucion salina?','Potasio','Sodio','Calcio','Sodio');

INSERT INTO ciencia VALUES('6','Que termino describe un grupo de organismos y su entorno fisico?','Nicho','Mutualismo','Ecosistema','Ecosistema');

INSERT INTO ciencia VALUES('7','Que contiene el nucleo de una celula?','ADN','Lisosomas','Organulos','ADN');

INSERT INTO ciencia VALUES('8','De que estan hechos todos los objetos del mundo?','Solidos','Masa','Materia','Materia');

INSERT INTO ciencia VALUES('9','Cual es el nombre tecnico del miedo o fobia a las alturas?','Acrofobia','Vertigofobia','Alturafobia','Acrofobia');

INSERT INTO ciencia VALUES('10','La formula E=mc2, ¿en que teoria científica aparece?','T. Relatividad','T. Cuantica','T. del universo','T. Relatividad');

INSERT INTO ciencia VALUES('11','Cual es el ave de mayor envergadura que sigue viva actualmente?','Aguila Real','Buitre','Albatros','Albatros');

INSERT INTO ciencia VALUES('12','Que descubrio Marie Curie?','Un isotopo','Un cometa','La Radioactividad','La Radioactividad');

INSERT INTO ciencia VALUES('13','Como se llama el ave rapaz que se alimenta fundamentalmente de huesos?','Quebrantahuesos','Aguila Real','Avestruz','Quebrantahuesos');

INSERT INTO ciencia VALUES('14','Que especie de anfibio es conocida por su increible capacidad para regenerar partes de su cuerpo que han sido dañadas o amputadas?','Estrella de mar','Ajolote','Rana azul','Ajolote');

INSERT INTO ciencia VALUES('15','Como se llama la planta a partir de la cual suele ser elaborado el tequila?','Tequilita','Agave','Mandragora','Agave');

INSERT INTO ciencia VALUES('16','Como se llama el tipo de celula nerviosa mas abundante en el cerebro humano?','neuronas','neurocitos','celulas gliales','celulas gliales');

INSERT INTO ciencia VALUES('17','Que periodo de la era paleozoica tuvo lugar entre el Devonico y el Permico?','El Jurasico','El Carbonefero','El Cretacico','El Carbonifero');

INSERT INTO ciencia VALUES('18','En que año Pluton dejo de ser considerado como un planeta?','2006','2007','2010','2006');

INSERT INTO ciencia VALUES('19','Que edad tiene la tierra?','7.5 millones de anys','6 millones de anyos','4.5 millones de anyos','4.5 millones de anyos');





INSERT INTO deporte VALUES('1','Por que deporte es conocido el Chicago Cubs y Boston Red Sox?','baloncesto','futbol','beisbol','beisbol');

INSERT INTO deporte VALUES('2','Que deporte olimpico incluye pliegues y picas?','natacion','gimnasia ritmica','bolos','natacion');

INSERT INTO deporte VALUES('3','Manny Pacquiao es un boxeador legendario de que pais?','Corea','Filipinas','Mexico','Filipinas');

INSERT INTO deporte VALUES('4','Cuantas casillas tiene el tablero de ajedrez?','64','32','56','64');

INSERT INTO deporte VALUES('5','Cuantos puntos vale un tiro libre en baloncesto?','3','2','1','1');

INSERT INTO deporte VALUES('6','Los Juegos Olimpicos se celebran cada cuantos anyos?','5','6','4','4');

INSERT INTO deporte VALUES('7','Que parte de tu cuerpo no debe tocar el balon en el futbol?','cabeza','mano','espalda','mano');

INSERT INTO deporte VALUES('8','Cual de los siguientes deportes no usa pelota?','golf','hockey','polo','hockey');

INSERT INTO deporte VALUES('9','Cuantos jugadores hay en un equipo en un juego de beisbol promedio?','10','9','11','9');

INSERT INTO deporte VALUES('10','Cuantas rondas hay en un solo juego de boxeo profesional?','12','13','14','12');

INSERT INTO deporte VALUES('11','Deporte basado en la saga de Harry Potter:','Quidditch','Greenwich','Fidditch','Quidditch');

INSERT INTO deporte VALUES('12','Que equipo NBA tiene la racha ganadora mas larga?','LA Lakers','Chicago Bulls','Goldenstate Warriors','LA Lakers');

INSERT INTO deporte VALUES('13','Que equipo de la NFL es el mas antiguo de la historia?','Green Bay Packers','Arizona Cardinals','New England Patriots','Green Bay Packers');

INSERT INTO deporte VALUES('14','Que jugador NBA tiene el record de más puntos anotados en un juego?','Michael Jordan','Wilt Chamberlain','Kobe Bryant','Wilt Chamberlain');

INSERT INTO deporte VALUES('15','Que equipo gano 3 Super Bowls en la decada de 1990?','Green Bay Packers','Dallas Cowboys','Arizona Cardinals','Dallas Cowboys');

INSERT INTO deporte VALUES('16','Cuando se realizo el lanzamiento de jabalina por primera vez en los Juegos Olimpicos?','1908','1923','1901','1908');

INSERT INTO deporte VALUES('17','Como se llama la zona de hierba sobre la cual se ubica el hoyo en golf?','Green','Grass','Garden','Green');

INSERT INTO deporte VALUES('18','Cuantos minutos dura un partido de rugby?','80','60','90','80');

INSERT INTO deporte VALUES('19','Cuantos Grand Slam tiene Roger Federer?','13','18','20','20');





