using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Cita
    {
        //atributos
        string Nombre_est;
        DateTime Fecha_deseada;
        TimeSpan Hora;
        string Tema;
        int Docente;
        string Nom_docente;
        public Cita()
        {

        }
        public Cita(int id,string Nombre_est,
            DateTime Fecha_deseada, TimeSpan Hora, string Tema, int Docente, string nom_docente)
        {
            this.Nombre_est = Nombre_est;
            this.Fecha_deseada = Fecha_deseada;
            this.Hora = Hora;
            this.Tema = Tema;
            this.Docente = Docente;
            this.Nom_docente = nom_docente;  
        }

        public string nombre_est { get => Nombre_est; set => Nombre_est = value; }
        public DateTime fecha_deseada { get => Fecha_deseada; set => Fecha_deseada = value; }
        public TimeSpan hora { get => Hora; set => Hora = value; }
        public string tema { get => Tema; set => Tema = value; }
        public int docente { get => Docente; set => Docente = value; }

        public string nom_docente { get => Nom_docente; set => Nom_docente = value; }

    }
}
