using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet_Récupérable : MonoBehaviour {

    public float num_objet;

    void Start() {
        
    }

    void Update() {
        
    }

    void OnTriggerEnter() {
        // Detruir l'objet
        Destroy(this.gameObject);
        // Appel pour mettre l'objet dans l'inventaire 
    }
}
