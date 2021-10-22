using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] Transform newMap;
    [SerializeField] GameObject pacman;
    [SerializeField] GameObject[] Ghosts;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(map);
        Instantiate(newMap, Vector3.zero, Quaternion.identity);
        pacman.SetActive(true);
        for(int i=0; i<Ghosts.Length; i++)
        {
            Ghosts[i].SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
