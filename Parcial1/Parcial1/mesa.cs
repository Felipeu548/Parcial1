using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
    public class mesa
    {
        private int numero;
        private int cantidadPersonas;
        private Boolean estado;

        private cliente Cliente;

        public mesa(int numero,
                    int cantidadPersonas, 
                    Boolean estado) {
            this.numero = numero;
            this.cantidadPersonas = cantidadPersonas;
            this.estado = estado;
        }



        public void registrar(Boolean cliente) {
        }
        public bool consultaEstado() {
            return true;
        }
        public mesa disponible( mesa Mesa) {
            return this.mesa();
        }
    }
}
