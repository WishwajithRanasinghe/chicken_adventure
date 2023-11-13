using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScripts : MonoBehaviour
{
    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    
   
   
    private void Update()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        if(_player)
        {
            transform.position = new Vector3 (transform.position.x,_player.transform.position.y,transform.position.z);
        }


    }//FollowPlayer
}//Class
