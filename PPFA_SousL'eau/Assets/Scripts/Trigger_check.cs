using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_check : MonoBehaviour {

    // Numéro de la zone
    public float numZone;

    // Réf au manager de la zone sombre
    public ZoneSombre_manager zoneSombre;

    void OnTriggerEnter () {

        // Envoie le numéro de zone entrée
        zoneSombre.ZoneEntree(numZone);
    }
}
