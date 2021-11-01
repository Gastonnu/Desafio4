using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float liveBullet = 2f;
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, liveBullet);
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DuplicateScale();
        }
    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }

    void DuplicateScale()
    {
        transform.localScale = transform.localScale * 2;
    }

}
