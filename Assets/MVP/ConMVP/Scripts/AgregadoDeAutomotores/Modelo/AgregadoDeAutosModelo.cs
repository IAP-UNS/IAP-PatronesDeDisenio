using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AgregadoDeAutomotores
{
    public class AgregadoDeAutosModelo
    {
        private AgregadoDeAutosPresentador presentador;

        public AgregadoDeAutosModelo(AgregadoDeAutosPresentador p)
        {
            presentador = p;
        }

        private bool ExisteAutomotor(string patente)
        {
            //chequea si existe en una base de datos, etc etc
            return true;
        }


        public void AgregarNuevoAutomotor(string patente)
        {
            bool automotorYaExiste = ExisteAutomotor(patente);
            string mensajeSalida;
            if (automotorYaExiste)
            {
                mensajeSalida = "El automotor ya existe en la base de datos.";
            }
            else
            {
                mensajeSalida = "El automotor ha sido agregado satisfactoriamente.";
            }

            presentador.MostrarMensaje(mensajeSalida);
        }


    }
}