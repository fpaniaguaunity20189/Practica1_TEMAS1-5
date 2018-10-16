using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoListo : EnemigoMovil {

    protected override void Update() 
    {
        Vector3 vDistancia = GetDistancia();
        if (vDistancia.magnitude < 20) {
            this.transform.LookAt(player.transform.position);
        }
        base.Update();
    }
}
