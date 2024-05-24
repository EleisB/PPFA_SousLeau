using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSombre_manager : MonoBehaviour {


    // Réf à l'animator
    public Animator anim;

    // Hop thechnique de bourin
    private bool is1 = false, is2 = false, is3 = false, is4 = false, is5 = false;
    private bool isFin;

    // Ref à l'UI
    public Canvas UI;

    // Ref au third person
    public ThirdPersonMovment thirdPersonMovment;

    // void Start () {
    //     UI.enabled = true;

    // }


    // Quand tu sort c'est game over
    void OnTriggerExit () {

        // Debug.Log("bonjour");

        // Active l'UI et lance l'animation  
        UI.enabled = true;
        // stop le mouvment du joueur si game over
        thirdPersonMovment.SwitchInventaire(true);
        // Stop l'anim de la zone sombre
        anim.enabled = false;
    }

    void FixedUpdate() {

        // Dit le une seule fois
        if (isFin == false) {

            // Quand toutes les zones ont été activé = lancer l'animation
            if (is1 && is2 && is3 && is4 && is5) {
                Debug.Log("yep ! ");
                
                
                anim.enabled = true;
                isFin = true;
            }
        } 
    }

    public void ZoneEntree (float numZone) {

        // Passe les zone en true quand elles sont appelée
        if (numZone == 1) {
            is1 = true;
            Debug.Log("1" + is1);

        }

        if (numZone == 2) {
            is2 = true;
            Debug.Log("2" + is2);
        }
        if (numZone == 3) {
            is3 = true;
            Debug.Log("3" + is3);
        }
        if (numZone == 4) {
            is4 = true;
            Debug.Log("4" + is4);
        }
        if (numZone == 5) {
            is5 = true;
            Debug.Log("5" + is5);
        }
    }

}
