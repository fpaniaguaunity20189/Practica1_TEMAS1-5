using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaDeSalud : MonoBehaviour {
    [SerializeField] int speedRotation = 1;
    int rotacion = 0;

    bool subiendo = true;
    int deltaY = 0;
	
	void Update () {
        rotacion=rotacion+speedRotation;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotacion, 0));
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
}
