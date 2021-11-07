DROP DATABASE IF EXISTS Juego;
CREATE DATABASE Juego;

USE Juego;

CREATE TABLE jugador(
    nick VARCHAR(30) NOT NULL,
    passwd VARCHAR(30) NOT NULL,
    PRIMARY KEY (nick)
)ENGINE= InnoDB;

CREATE TABLE partida(
    id INT NOT NULL,
    ciudad VARCHAR(30) NOT NULL,
    ganador VARCHAR(30) NOT NULL,
    fecha VARCHAR(30) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (ganador) REFERENCES jugador (nick)
)ENGINE= InnoDB;

CREATE TABLE puntuaciones(
    player VARCHAR(30) NOT NULL,
    idpartida INT NOT NULL,
    puntos INT NOT NULL,
    FOREIGN KEY (player) REFERENCES jugador (nick),
    FOREIGN KEY (idpartida) REFERENCES partida (id)
)ENGINE= InnoDB;

INSERT INTO jugador VALUES('Juan','Contra1');
INSERT INTO jugador VALUES('Pedro','Contra2');
INSERT INTO jugador VALUES('Sara','Contra3');
INSERT INTO jugador VALUES('Bryan','Contra4');
INSERT INTO jugador VALUES('Michelle','Contra5');

INSERT INTO partida VALUES(3,'Barcelona','Juan','30/03/2021');
INSERT INTO partida VALUES(1,'Barcelona','Sara','30/03/2021');
INSERT INTO partida VALUES(2,'Barcelona','Pedro','25/03/2021');
INSERT INTO partida VALUES(4,'Barcelona','Juan','25/03/2021');

INSERT INTO puntuaciones VALUES('Juan',1,5);
INSERT INTO puntuaciones VALUES('Sara',1,8);
INSERT INTO puntuaciones VALUES('Juan',2,5);
INSERT INTO puntuaciones VALUES('Pedro',2,6);