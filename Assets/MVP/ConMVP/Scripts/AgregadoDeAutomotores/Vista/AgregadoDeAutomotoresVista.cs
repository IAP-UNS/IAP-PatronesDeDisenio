using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AgregadoDeAutomotores
{
    public class AgregadoDeAutomotoresVista : MonoBehaviour
    {
        public InputField inputAgregarAutomotor;
        public Text mensajeAgregarAutomotor;

        private AgregadoDeAutosPresentador presentador;

        private void Start()
        {
            presentador = new AgregadoDeAutosPresentador(this);
            presentador.SetearModelo(new AgregadoDeAutosModelo(presentador));
        }

        public void AgregarAutomotor()
        {
            string patente = inputAgregarAutomotor.text;
            presentador.AgregarNuevoAutomotor(patente);


        }

        public void MostrarMensajeAgregarAutomotor(string mensaje)
        {
            mensajeAgregarAutomotor.text = mensaje;
        }

    }
}
