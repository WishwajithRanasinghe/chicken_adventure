using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public static SpawnerScript instance;
    public GameObject groundPrefab;
    private float _groundYDistance =3.3f;
    private float _currentYPosition = 0f;

    private void Awake()
    {
        MakeIntance();
    }

    private void Start()
    {
        SpawnInitialGrounds();
    }

    private void Update()
    {
        
    }
    private void MakeIntance()
    {
        if(instance == null)
        {
            instance = this;
        }

    }//MakeIntance
    private void SpawnInitialGrounds()
    {
        for (int i = 0; i < 5; i++)
        {
            
            SpawnNewGround();
        }
    }//SpawnInitialGrounds

    public void SpawnNewGround()
    {
        _currentYPosition += _groundYDistance;

        Instantiate(groundPrefab,new Vector3(0f,_currentYPosition,0f), Quaternion.identity);

    }//SpawnNewGround
}//Class
