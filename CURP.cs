

using System;
using System.Collections.Generic;
using System.Text;


    public class CURP : Persona
    {
              
        private string yearCopy;
        private char genero;

    public CURP(string yearCopy, string Nombres, string Apellido_p, string Apellido_m, char Genero,
                int Dia, int Mes, int Year, string Lugar_nacimiento) : base(Nombres, Apellido_p, Apellido_m, Genero, Dia, Mes, Year, Lugar_nacimiento)
    {
        this.yearCopy = yearCopy;
        this.Nombres = Nombres;
    }

    public string YearCopy { get => yearCopy; set => yearCopy = Convert.ToString(Year); }  
        
    

   
    }

    public class CapturaCURP
    {
        public void Construccion_curp()
        {
            CURP c; 
            Captura c1 = new Captura();
            Persona p2 = new Persona();
            c1.registro(p2);
            c1.entidad(p2.Lugar_nacimiento);


            

        /*
             if (p2.Apellido_p[0] == 'Ñ' || p2.Apellido_p[0] == '.' || p2.Apellido_p[0] == '/' || p2.Apellido_p[0] == '-')
                  p2.Apellido_p[0] = 'X';

              if (p2.Apellido_p[1] == 'Ñ' || p2.Apellido_p[1] == '.' || p2.Apellido_p[1] == '/' || p2.Apellido_p[1] == '-')
                  Posicion[1] = 'X';

              if (p2.Apellido_m[2] == 'Ñ' || p2.Apellido_m[2] == '.' || p2.Apellido_m[2] == '/' || p2.Apellido_m[2] == '-')
                  Posicion[2] = 'X';

              if (p2.Nombres[3] == 'Ñ' || p2.Nombres[3] == '.' || p2.Nombres[3] == '/' || p2.Nombres[3] == '-')
                  Posicion[3] = 'X';
      
        */

           
                
            
        }
     public String datosCURP()
    {

        return "";
    }

         
    }

    

