using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {
    public Image[] imagenes = new Image[3];
    public void ActivarArma(int posArma) {
        DesactivarArmas();
        imagenes[posArma].GetComponent<Image>().enabled = true;
    }
    private void DesactivarArmas() {
        for (int i = 0; i < imagenes.Length; i++) {
            imagenes[i].GetComponent<Image>().enabled = false;
        }
    }
}
