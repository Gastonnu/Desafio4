using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{

    public float delay = 3f;
    public float timeInBetween = 2.5f;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", delay, timeInBetween);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Disparo()
    {
        Instantiate(bullet, transform);
    }
}
