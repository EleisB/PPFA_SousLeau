using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Switch_Cam : MonoBehaviour {

    // Réf aux deux cam
    [SerializeField] private CinemachineFreeLook cineCam1;
    [SerializeField] private CinemachineVirtualCamera cineCam2;
    public ThirdPersonMovment thirdPersonMovment;

    public bool iSInventaire = false; 

    void Start() {

        // Mise à jour au démarage
        cineCam1.enabled = !iSInventaire;
        cineCam2.enabled = iSInventaire;
    }

    void Update() {
        if (Input.GetKeyDown (KeyCode.E)) {
            // On inverse is inventaire
            iSInventaire = !iSInventaire;

            cineCam1.enabled = !iSInventaire;
            cineCam2.enabled = iSInventaire;

            // indique à thirdPersonMovement si l'inventaire est activé (si oui on stop le mouvment du joueur)
            
            thirdPersonMovment.SwitchInventaire(iSInventaire);
        }
    }
}
