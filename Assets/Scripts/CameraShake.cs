using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]private float duration;
    [SerializeField]private float magnitude;
    void Start()
    {
        //Llamar funcion
        //Shake();
        //Llamar Corutina
        //StarCorutine(Shake());
    }
    
    public IEnumerator Shake()
    {
        //yield return new WaitForSeconds(1f);
        Vector3 originalPos = transform.position;
        float elapsed = 0f; 

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
            elapsed += Time.deltaTime; 
            yield return 0; 
            //56.326026025026
        }
    }
}
