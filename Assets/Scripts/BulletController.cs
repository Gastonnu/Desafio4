using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float liveBullet = 10f;
    private float speed = 0f;
    private Vector3 direction = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();

        liveBullet -= Time.deltaTime;
        if(liveBullet < 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DuplicateScale();
        }
    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    void DuplicateScale()
    {
        transform.localScale = transform.localScale * 2;
    }

}
