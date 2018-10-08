using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovil : Enemigo {
    [SerializeField] protected int speed=1;

    protected void Avanzar() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }
}
