


using System;
using System.Collections.Generic;
using System.Text;


    public class Persona
    {

        private String nombres;
        private String apellido_p;
        private String apellido_m;
        private Char genero;
        private int dia;
        private int mes;
        private int year;
        private String lugar_nacimiento;
       

   

         public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Year { get => year; set => year = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public char Genero { get => genero; set => genero = value; }
        public string Lugar_nacimiento { get => lugar_nacimiento; set => lugar_nacimiento = value; }
        public int Mes { get => mes; set => mes = value; }
    }

