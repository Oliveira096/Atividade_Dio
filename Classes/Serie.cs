

using System;

namespace DIO.SERIES

{
    public  class  Serie : EntidadeBase
    {
        private  Genero Genero {get; set;}
        private string titulo {get; set;}
        private string descricao {get; set;}
        private int Ano {get; set;}
        private bool excluido {get; set;}
        


    public  Serie ( int id, Genero Genero, string titulo, string descricao, int Ano){

        this.Id=id;
        this.Genero=Genero;
        this.titulo=titulo;
        this.descricao=descricao;
        this.Ano=Ano;
        this.excluido=false;
    
    }
    public override string ToString(){

        string retorno= "";
        retorno +="Genero:" + this.Genero + Environment.NewLine;
        retorno +="titulo:" + this.titulo + Environment.NewLine;
        retorno +="descricao:" + this.descricao + Environment.NewLine;
        retorno +="Ano de inicio:" + this.Ano + Environment.NewLine;
        retorno +="excluido" + this.excluido + Environment.NewLine;
        return retorno;


    }
        public string retonatitulo(){

            return this.titulo;
        }

        public int retornaid(){

            return this.Id;
        }
        public bool retornaexcluido(){
            return this.excluido;
        }
        public void excluir(){
            this.excluido=true;
        }
    }
}
 