using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
    public class Menu
    {
        private List<alimento> Alimento;
        private int precio;
        private string nombre;

        private List<pedido> pedido;


        private alimento alimento = new  alimento(); //composision 

        public Menu(int precio,
                    string nombre)
        {
            this.precio = precio;
            this.nombre = nombre;
        }

        public void AgregarAlimnto(alimento Alimento) {

        }
        public void QuitarAlimnto(alimento Alimento) {
        }
        public int obtienePrecio() {
            return this.precio;
        }
        public int CambiarPrecio(int Precio) {
            return this.precio;
        }

    }
}
