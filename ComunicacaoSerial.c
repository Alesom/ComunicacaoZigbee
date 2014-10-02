#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>
#include <windows.h>

#define MAX_TAM 1000
#define wait Sleep(500)


int main(){
	
	FILE *porta = fopen("COM8", "r+");

	FILE *arq = fopen("config.txt", "r");
	char MododeComando[5];
	char resp[MAX_TAM];
	char ComandosAt[MAX_TAM];
	char *ComandosAtFinal=NULL;
	int tam;

	strcpy(MododeComando, "+++");
	
	if (porta==NULL){
		printf("Erro na comunicação\n");
	}else{
		printf("Feeiito\n");
		while (!feof(arq)){
			fgets(ComandosAt, MAX_TAM-2, arq);
			tam=strlen(ComandosAt);
			if (ComandosAtFinal==NULL)
				ComandosAtFinal=malloc (tam*sizeof(char));
			else
				ComandosAtFinal=realloc (ComandosAtFinal, tam*sizeof(char));
			
			strcpy(ComandosAtFinal, ComandosAt);
			printf("%s\n", ComandosAtFinal);
			fwrite (&ComandosAtFinal, sizeof (ComandosAtFinal), 1, porta);
			wait;
			fgets(resp, MAX_TAM-2, porta);
			printf("%s\n", resp);
		}
	}
	return 0;
}
