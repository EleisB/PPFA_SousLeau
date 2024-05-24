using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventaire_manager : MonoBehaviour {

    public Image piece;

    void Start() {
        
    }

    void Update() {
        
    }

    public void Recupere(float num) {

        //Debug.Log("recupéré");

        if (num == 1) {
            //Debug.Log("hop");
            piece.enabled = true;
        }
        
    }
}
