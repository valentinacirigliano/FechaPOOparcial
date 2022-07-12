using System;
using System.Runtime.CompilerServices;

namespace FechaPOOparcial.entidades
{
    public class Fecha
    {
        //Debe tener 3 atributos privados de tipo entero Dia, Mes, Anio.
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Anio { get; set; }

        public int GetDia() => this.Dia;
        public int GetMes() => this.Mes;
        public int GetAnio() => this.Anio;
        public Fecha(int dia, int mes, int anio)
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Anio = anio;
        }

        public Fecha():this(DateTime.Today.Day,DateTime.Today.Month,DateTime.Today.Year)
        {

        }

        public override string ToString()
        {
            return $"{this.Dia}/{this.Mes}/{this.Anio}";
        }

        public string MostrarConPalabras()
        {
            return $"{this.Dia} de {(Mes)this.Mes} del {this.Anio}";
        }
        public bool Validador()
        {
            bool esValido = true;
            if (this.Dia > 31 || this.Dia < 1 || this.Mes > 12 || this.Mes < 1 || this.Anio > 2022)
            {
                esValido =false;

            }else if (this.Mes == 2)
            {
                if (this.Dia > 28)
                {
                    esValido=false;
                }
            }else if (this.Mes == 4 || this.Mes == 6 || this.Mes == 9 || this.Mes == 11)
            {
                if (this.Dia>28)
                {
                    esValido=false;
                }
            }else if (this.Anio > DateTime.Today.Year)
            {
                esValido = false;
            }
            else if (this.Anio == DateTime.Today.Year && this.Mes> DateTime.Today.Month)
            {
                esValido= false;
            }
            else if (this.Anio == DateTime.Today.Year && this.Mes == DateTime.Today.Month &
                      this.Dia > DateTime.Today.Day)
            {
                esValido = false;
            }
            else
            {
                esValido=true;
            }
            return esValido;
        }

        //Sobrescribir el operador de igualdad (==).

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fecha))
            {
                return false;
            }
            return this.GetDia() == ((Fecha)obj).GetDia()
            && this.GetMes() == ((Fecha)obj).GetMes()
            && this.GetAnio() == ((Fecha)obj).GetAnio();
        }

        public static bool operator ==(Fecha f1, Fecha f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fecha f1, Fecha f2)
        {
            return !(f1 == f2);
        }

        //Generar una conversión implícita que retorne una fecha de un string.

        public static implicit operator Fecha(string s)
        {
            var signo = s.Contains('/') ? '/' : '-';
            var array = s.Split(signo);

            var dia = int.Parse(array[0]);
            var mes = int.Parse(array[1]);
            var anio = int.Parse(array[2]);
            return new Fecha(dia,mes,anio);
        }


    }
}
