

using System;
using System.Collections.Generic;
using System.Text;


    public class Captura
    {


        public void registro(Persona cc)
        {

            
            Console.Write("\n Escriba su nombre(s): "); cc.Nombres = Convert.ToString(Console.ReadLine());
            Console.Write("\n Escriba su apellido paterno: "); cc.Apellido_p = Convert.ToString(Console.ReadLine());
            Console.Write("\n Escriba su apellido materno: "); cc.Apellido_m = Convert.ToString(Console.ReadLine());
            Console.Write("\n Define tu genero(H/M): "); cc.Genero = Convert.ToChar(Console.ReadLine());
            Console.Write("\n Tu estado de nacimiento( Encaso de ser de otro pais escribe >>> Extranjero <<< ): "); cc.Lugar_nacimiento = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Escribe tu dia de nacimiento (dd/mm/yy)");
            Console.Write(" dia: "); cc.Dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n mes: "); cc.Mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n year: "); cc.Year = Convert.ToInt32(Console.ReadLine());



        }

        protected internal String entidad(String lugar)
        {
        if (lugar == "Baja California") return "BC";

        else if (lugar == "Aguascalientes") return "AS";

        else if (lugar == "Baja California Sur") return "BS";

        else if (lugar == "Campeche") return "CC";

        else if (lugar == "Chiapas") return "CS";

        else if (lugar == "Chihuahua") return "CH";

        else if (lugar == "Coahuila") return "CL";

        else if (lugar == "Colima") return "CM";

        else if (lugar == "Distrito Federal") return "DF";

        else if (lugar == "Durango") return "DG";

        else if (lugar == "Guanajuato") return "GT";

        else if (lugar == "Guerrero") return "GR";

        else if (lugar == "Hidalgo") return "HG";

        else if(lugar == "Jalisco") return "JC";

        else if (lugar == "Mexico") return "MC";

        else if (lugar == "Michoacan") return "MN";

        else if (lugar == "Morelos") return "MS";

        else if (lugar == "Nayarit") return "NT";

        else if (lugar == "Nuevo Leon") return "NL";

        else if (lugar == "Oaxaca") return "OC";

        else if (lugar == "Puebla") return "PL";

        else if (lugar == "Queretaro") return "QT";

        else if (lugar == "Quintana Roo") return "QR";

        else if (lugar == "San Luis Potosi") return "SP";

        else if (lugar == "Sinaloa") return "SL";

        else if (lugar == "Sonora") return "SR";

        else if (lugar == "Tabasco") return "TC";

        else if (lugar == "Tlaxcala") return "TL";

        else if (lugar == "Tamaulipas") return "TS";

        else if (lugar == "Veracruz") return "VZ";

        else if (lugar == "Yucatan") return "YN";

        else if (lugar == "Zacatecas") return "ZS";

        return "";
        }




    }

