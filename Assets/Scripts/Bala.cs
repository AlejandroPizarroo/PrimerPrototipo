using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    // Start is called before the first frame update
    void Start(){
        // destruir bala despues de 3 segundos
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update(){
        transform.Translate(0, 5 * Time.deltaTime, 0, Space.World); 
    }

    void OnTriggerEnter(Collider c){
        Destroy(c.gameObject); // destruir enemigo 
        Destroy(gameObject);  // destruir bala
    }
}