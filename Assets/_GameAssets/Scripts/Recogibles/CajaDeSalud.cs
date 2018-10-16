using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaDeSalud : MonoBehaviour {
    [SerializeField] int speedRotation = 1;
    [SerializeField] int vida = 1;
    //int rotacion = 0;

    private bool subiendo = true;
    private int deltaY = 0;
	
	void Update () {
        this.transform.Rotate(new Vector3(1, 1, 0)); 
        /*
        rotacion=rotacion+speedRotation;
        if (rotacion >= 360) rotacion = 0;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotacion, 0));
        */


        if (subiendo) {
            deltaY++;
            transform.Translate(Vector3.up * Time.deltaTime);
        } else {
            deltaY--;
            transform.Translate(Vector3.up * Time.deltaTime * -1);
        }
        if (deltaY > 50) {
            subiendo = false;
        } else if (deltaY <= 0) {
            subiendo = true;
        }
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Player p = other.gameObject.GetComponent<Player>();
            p.IncrementarVida(vida);
            Destroy(this.gameObject);
        }
    }
}
