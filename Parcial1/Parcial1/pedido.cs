using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
    public class pedido
    {
        private cliente Cliente;
        private garzon garzon;
        private List<Menu> menu;
        private List<alimento> alimento;
        private List<mesa> mesa;
        private DateTime fecha;
        private DateTime hora;
        private Boolean estado;


        public bool registrarse( String [] param) {
            return true;
        }
    }
}
