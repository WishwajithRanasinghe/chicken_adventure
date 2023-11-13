using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScripts : MonoBehaviour
{
    
    private void Update()
    {
        DeactivateGrounds();
        
    }
    private void DeactivateGrounds()
    {
        if(Camera.main.transform.position.y > transform.position.y + 9.0f)
        {
            SpawnerScript.instance.SpawnNewGround();

            this.gameObject.SetActive(false);
        }

    }//DeactivateGrounds
}//Class
