#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <string.h>
#include <mysql.h>
#include <stdlib.h>



int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9060);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			printf ("Peticion: %s\n",peticion);
			
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			// Ya tenemos el c?digo de la petici?n
			char nombre[20];
			
			/*if (codigo !=0)
			{
				p = strtok( NULL, "/");
				
				strcpy (nombre, p);
				// Ya tenemos el nombre
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}*/
			
			if (codigo ==0) //petici?n de desconexi?n
				terminar=1;
			
			else if (codigo ==1)
				//Piden loguearse 
			{
				char respuesta[80];
				char nombre[80];
				char contrasenya[80];
				char *p=strtok(NULL,"/");
				sprintf(nombre,p);
				p= strtok(NULL,"/");	
				sprintf(contrasenya,p);
				int log=UsuarioContrasenya(nombre,contrasenya);
				if (log==-1)
				{
					sprintf(respuesta,"NO");
				}
				if (log==0)
				{
					sprintf(respuesta,"SI");
				}
			}
				
			
			/*else if (codigo ==2)
				// quieren saber si el nombre es bonito
			{
				if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
				else
				{
					strcpy (respuesta,"NO");
				}
				else //quiere saber si es alto
				{
					p = strtok( NULL, "/");
					float altura =  atof (p);
					if (altura > 1.70)
						sprintf (respuesta, "%s: eres alto",nombre);
					else
						sprintf (respuesta, "%s: eresbajo",nombre);
				}
			} */
				
				if (codigo !=0)
				{
					
					printf ("Respuesta: %s\n", respuesta);
					// Enviamos respuesta
					write (sock_conn,respuesta, strlen(respuesta));
				}
		}
		// Se acabo el servicio para este cliente
		close(sock_conn); 
	}
}
int UsuarioContrasenya (char nombre[80], char contrasenya[80])
{
	MYSQL *conn;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int err;
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi??n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		return -2;
		exit (1);
	}
	
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Juego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexi??n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		return -2;
		exit (1);
		
	}
	int co;
	char consulta[150];
	sprintf(consulta,"SELECT (JUGADOR.NICK,JUGADOR.PASWORD) FROM (JUGADOR) WHERE (JUGADOR.NICK='%s') AND (JUGADOR.PASWORD='%s')",nombre,contrasenya);
	err=mysql_query(conn,consulta);
	
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		return -2;
		exit (1);
		
	}
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row==NULL)
	{
		return -1;
	}
	else 
	{
		return 0;
	}
	mysql_close (conn);
	exit(0);
	
	
	
}

