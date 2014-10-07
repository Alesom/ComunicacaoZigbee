using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class GerenciaDiretorio
    {
        private string Path;
        private string Nome;

        public GerenciaDiretorio() //construtor;
        {
            Path = string.Empty;
            Nome = string.Empty;
        }
        
        public string getNome(){ //get nome da pasta
            return this.Nome;
        }

        public void setPath(string caminho) //set path da pasta
        {
            this.Path = caminho;
        }

        public void setNome(string caminho) //set nome da pasta
        {
            this.Nome = caminho;
        }

        public string getPath() //get path da pasta
        {
            return this.Path;
        }

        public void Cria() //cria o diretório
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Path, Nome));
        }

        public Boolean DirJaExist() //verifica se o diretório já existe
        {
            if (System.IO.File.Exists(System.IO.Path.Combine(Path, Nome)))
                return true;

            return false;
        }
    }
}
