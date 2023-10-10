using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public InputField inputAgregarAutomotor, inputConsultarDeudas, inputPagarDeudas;
    public Text mensajeAgregarAutomotor, mensajeConsultarDeudas, mensajePagarDeudas;

    
    //**************************************************************************************

    public void ConsultarDeudas()
    {
        string patente = inputConsultarDeudas.text;
        bool tieneDeudas = false;
        //busco en la base de datos las deudas correspondientes a la patente
        MostrarMensajeConsultarDeudas(tieneDeudas);
    }

    public void MostrarMensajeConsultarDeudas(bool tieneDeudas)
    {
        if (tieneDeudas)
        {
            mensajeConsultarDeudas.text = "El automotor posee las siguientes deudas...";
        }
        else
        {
            mensajeConsultarDeudas.text = "El automotor no posee deudas.";
        }
    }

    //**************************************************************************************

    public void PagarDeudas()
    {
        string patente = inputPagarDeudas.text;
        //se realiza el pago de las deudas de alguna forma
        MostrarMensajePagarDeudas();
    }

    public void MostrarMensajePagarDeudas()
    {
        mensajePagarDeudas.text = "Las deudas han sido pagadas.";
    }

    //**************************************************************************************
}
