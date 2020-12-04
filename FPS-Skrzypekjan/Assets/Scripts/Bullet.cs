using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Variables

    public float speed = 1f;
    public float lifeDuration = 2f;

    private float lifeTimer;

    #endregion


    #region MonoBehaviour Callbacks

    private void Start()
    {
        lifeTimer = lifeDuration;
    }
    private void Update()
    {
        //Bullet move
        transform.position = transform.forward * speed * Time.deltaTime;

        //Bullet lfetime
        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    #endregion


    #region Private Methods


    #endregion
}
