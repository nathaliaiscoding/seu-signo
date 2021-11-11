using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopoConsole
{
   public class CalculadoraSigno
    {
        public int Dia { get; set; }
        public int Mes { get; set; }

        public string _signo;

        public CalculadoraSigno(int dia, int mes)
        {
            Dia = dia;
            Mes = mes;
        }

        public string CalcularSigno(int dia, int mes)
        {
            if (mes == 1)
            {
                if (dia >= 1 || dia <= 20)
                {
                    _signo = "Capricórnio";
                }
                else if (dia >= 21 || dia <= 31)
                {
                    _signo = "Aquário";
                }
            }

            if (mes == 2)
            {
                if (dia >= 1 || dia <= 18)
                {
                    _signo = "Aquário";
                }
                else if (dia >= 19 || dia <= 29)
                {
                    _signo = "Peixes";
                }
            }
            if (mes == 3)
            {
                if (dia >= 1 || dia <= 20)
                {
                   _signo = "Peixes";
                }
                else if (dia >= 21 || dia <= 31)
                {
                    _signo = "Áries";
                }
            }
            if (mes == 4)
            {
                if (dia >= 1 || dia <= 20)
                {
                    _signo = "Áries";
                }
                else if (dia >= 21 || dia <= 30)
                {
                    _signo = "Touro";
                }
            }
            if (mes == 5)
            {
                if (dia >= 1 || dia <= 20)
                {
                    _signo = "Touro";
                }
                else if (dia >= 21 || dia <= 31)
                {
                    _signo = "Gêmeos";
                }
            }
            if (mes == 6)
            {
                if (dia >= 1 || dia <= 22)
                {
                    _signo = "Gêmeos";
                }
                else if (dia >= 23 || dia <= 31)
                {
                    _signo = "Câncer";
                }
            }
            if (mes == 7)
            {
                if (dia >= 1 || dia <= 22)
                {
                    _signo = "Câncer";
                }
                else if (dia >= 23 || dia <= 31)
                {
                    _signo = "Leão";
                }
            }
            if (mes == 8)
            {
                if (dia >= 1 || dia <= 22)
                {
                    _signo = "Leão";
                }
                else if (dia >= 23 || dia <= 31)
                {
                    _signo = "Virgem";
                }
            }
            if (mes == 9)
            {
                if (dia >= 1 || dia <= 22)
                {
                    _signo = "Virgem";
                }
                else if (dia >= 23 || dia <= 31)
                {
                    _signo = "Libra";
                }
            }
            if (mes == 10)
            {
                if (dia >= 1 || dia <= 22)
                {
                    _signo = "Libra";
                }
                else if (dia >= 23 || dia <= 31)
                {
                    _signo = "Escorpião";
                }
            }
            if (mes == 11)
            {
                if (dia >= 1 || dia <= 21)
                {
                    _signo = "Escorpião";
                }
                else if (dia >= 22 || dia <= 31)
                {
                    _signo = "Sagitário";
                }
            }
            if (mes == 12)
            {
                if (dia >= 1 || dia <= 21)
                {
                    _signo = "Sagitário";
                }
                else if (dia >= 22 || dia <= 31)
                {
                    _signo = "Capricórnio";
                }
            }
            return _signo; 
        }
    }
}
