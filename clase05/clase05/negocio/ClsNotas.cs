using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05.negocio
{
    class ClsNotas
    {

        private int parcial1;
        private int parcial2;
        private int parcial3;
        private int laboratorio1;
        private int laboratorio2;
        private int laboratorio3;
        private int resultado1;
        private int resultado2;
        private int resultado3;
        private int resultadofinal;

        public ClsNotas(int parcial1, int parcial2, int parcial3, int laboratorio1, int laboratorio2, int laboratorio3)
        {
            this.Parcial1 = parcial1;
            this.Parcial2 = parcial2;
            this.Parcial3 = parcial3;
            this.Laboratorio1 = laboratorio1;
            this.Laboratorio2 = laboratorio2;
            this.Laboratorio3 = laboratorio3;


            resultado1 = (int)((parcial1 * 0.60) + (laboratorio1 * 0.40));
            resultado2 = (int)((parcial2 * 0.60) + (laboratorio2 * 0.40));
            resultado3 = (int)((parcial3 * 0.60) + (laboratorio3 * 0.40));


            resultadofinal = (resultado3 + resultado2 + resultado1) / 3;



        }
        public override string ToString()
        {
            return "su nota del primer peridod es " + resultado1 + "\nsu nota del segundo peridod es " + resultado2 + "\nsu nota del primer peridod es " + resultado3 + 
                    "\nsu nota final del ciclo es " + resultadofinal;
        }



        public int Parcial1 { get => parcial1; set => parcial1 = value; }
        public int Parcial2 { get => parcial2; set => parcial2 = value; }
        public int Parcial3 { get => parcial3; set => parcial3 = value; }
        public int Laboratorio1 { get => laboratorio1; set => laboratorio1 = value; }
        public int Laboratorio2 { get => laboratorio2; set => laboratorio2 = value; }
        public int Laboratorio3 { get => laboratorio3; set => laboratorio3 = value; }
        public int Resultado1 { get => resultado1; set => resultado1 = value; }
        public int Resultado2 { get => resultado2; set => resultado2 = value; }
        public int Resultado3 { get => resultado3; set => resultado3 = value; }
        public int Resultadofinal { get => resultadofinal; set => resultadofinal = value; }
    } 





}
