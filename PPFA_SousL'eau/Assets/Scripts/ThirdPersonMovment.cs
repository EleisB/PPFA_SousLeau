using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour {

    public CharacterController controller;
    public Transform cam;
  
    public float speed = 6f;
    public float turnSmoothTime = 80f;

    private bool isInventaire = false;

    void FixedUpdate() {

        // Ne faire que si inventaire pas actif 
        if (isInventaire == false) {
            
            //Recup input z (W car qwerty)
            float forwardZ = Input.GetKey(KeyCode.W) ? 1 : 0;

            //Fait tourner en fonction de la camera + smooth
            transform.rotation = Quaternion.RotateTowards(transform.rotation, cam.transform.rotation, turnSmoothTime * Time.fixedDeltaTime);

            // Move et rotation si on bouge 
            if (forwardZ >= 0.1) {

                // Avancer en fonction de la cam (avec le controler character)
                Vector3 moveDir = transform.rotation * Vector3.forward;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);

            }
        }
    }

    public void SwitchInventaire (bool inventaire) {
        isInventaire = inventaire;
        Debug.Log ("switch !");

    }

    /* Vielle version 
     * 
        private float turnSmoothVelocity;

        // Déplacement input zqsd
        float horizontal = Input.GetAxisRaw("Horizontal"); //x
        float vertical = Input.GetAxisRaw("Vertical"); //z
        // Recup input a et e (A c'est Q parce que qwerty)
        float upDown = (Input.GetKey(KeyCode.Q) ? -1 : 0) + (Input.GetKey(KeyCode.E) ? 1 : 0); //y

        // Récup de la direction x, y, z
        Vector3 direction = new Vector3(horizontal, upDown, vertical).normalized;

        if (direction.magnitude >= 0.1f) {

            // Avancer en fonction de la cam 
            Vector3 moveDir = transform.rotation * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }


        // calcul de l'angle de rotation
        float targetAngleY = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float targetAngleX = Mathf.Atan2(direction.y, direction.z) * Mathf.Rad2Deg;

        // Ajoute smooth à la rotation
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngleY, ref turnSmoothVelocity, turnSmoothTime);
        // Fait tourner
        transform.rotation = Quaternion.Euler(0f, angle, targetAngleX); 


  */
}
