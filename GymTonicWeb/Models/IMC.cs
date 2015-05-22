using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymTonicWeb.Models
{
    public class IMC
    {
        public int cat { get; set; }
        public double calculoIMC(double altura, int peso)
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        public int categoria(double imc)
        {
            if (imc < 18.5)
            {
                cat = 1;
            }
            else if(imc == 18.5 && imc < 24.9)
            {
                cat = 2;
            }
            else if (imc == 25 && imc < 29.9)
            {
                cat = 3;
            }
            else if (imc == 30 && imc < 34.5)
            {
                cat = 4;
            }
            else if (imc == 35 && imc < 39.9)
            {
                cat = 5;
            }
            else if (imc >= 40)
            {
                cat = 6;
            }
            return cat;
        }
    }
}