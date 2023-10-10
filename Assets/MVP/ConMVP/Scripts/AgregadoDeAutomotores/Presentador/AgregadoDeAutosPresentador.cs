using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AgregadoDeAutomotores
{
    public class AgregadoDeAutosPresentador
    {
        private AgregadoDeAutomotoresVista vista;
        private AgregadoDeAutosModelo modelo;

        public AgregadoDeAutosPresentador(AgregadoDeAutomotoresVista v)
        {
            vista = v;
        }

        public void SetearModelo(AgregadoDeAutosModelo m)
        {
            modelo = m;
        }

        //metodo de la vista hacia el modelo
        public void AgregarNuevoAutomotor(string patente)
        {
            modelo.AgregarNuevoAutomotor(patente);
        }

        //metodo del modelo hacia la vista
        public void MostrarMensaje(string mensaje)
        {
            vista.MostrarMensajeAgregarAutomotor(mensaje);
        }





    }
}