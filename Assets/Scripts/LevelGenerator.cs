using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] Transform newMap;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(map);
        Instantiate(newMap, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
