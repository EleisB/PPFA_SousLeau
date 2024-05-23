using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour {

    public CharacterController controller;
    public Transform cam;
  
    public float speed = 6f;
    public float turnSmoothTime = 80f;
    public Animator anim;

    private bool isInventaire;

    void FixedUpdate() {
        
        // Ne faire que si inventaire pas actif 
        if (isInventaire == false) {
            
            // Debug.Log ("j'avance "+isInventaire);

            //Recup input z (W car qwerty)
            float forwardZ = Input.GetKey(KeyCode.W) ? 1 : 0;

            //Fait tourner en fonction de la camera + smooth
            transform.rotation = Quaternion.RotateTowards(transform.rotation, cam.transform.rotation, turnSmoothTime * Time.fixedDeltaTime);

            // Move et rotation si on bouge 
            if (forwardZ >= 0.1) {

                // Avancer en fonction de la cam (avec le controler character)
                Vector3 moveDir = transform.rotation * Vector3.forward;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);

                // Dire à l'anim qu'on bouge
                anim.SetBool("isMove", true);
            } else {
                // Dire à l'anim qu'on bouge pas
                anim.SetBool("isMove", false);
            }
        }

        // Dire à l'anim qu'on bouge
        if (Input.GetKeyDown (KeyCode.W)) {
            anim.SetBool("isMove", true);
            // Debug.Log ("appui");
        }
        if (Input.GetKeyUp (KeyCode.W)) {
            anim.SetBool("isMove", false);
            // Debug.Log ("relache");
        }
    }


    public void SwitchInventaire (bool inventaire) {

        isInventaire = inventaire;
        // Debug.Log ("switch ! " + isInventaire);

        // Changer l'anim si en mode inventaire
        if (isInventaire == true) {
            anim.SetBool("isInventaire", true);
        } else {
            anim.SetBool("isInventaire", false);
        }
    }
        
}
