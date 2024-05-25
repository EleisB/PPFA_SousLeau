using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventaire_manager : MonoBehaviour {

    public Image sphere, piece, pique;

    void Start() {
        
    }

    void Update() {
        
    }

    public void Recupere(float num) {

        //Debug.Log("recup�r�");

        if (num == 1) {
            //Debug.Log("hop");
            sphere.enabled = true;
        }
        if (num == 2) {
            //Debug.Log("hop");
            piece.enabled = true;
        }
        if (num == 3) {
            //Debug.Log("hop");
            pique.enabled = true;
        }
        
    }
}
