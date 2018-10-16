using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {
    private void Start() {
        Invoke("Destruir", 5);
    }
    private void OnTriggerEnter(Collider other) {
        GameObject objetivoImpacto = other.gameObject;
        if (objetivoImpacto.tag=="Enemigo") {
            objetivoImpacto.GetComponent<Enemigo>().RecibirDanyo(1);
        }
        Destroy(this.gameObject);
    }
    private void Destruir() {
        Destroy(this.gameObject);
    }

}
