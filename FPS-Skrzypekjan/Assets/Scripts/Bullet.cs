using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Variables

    public float lifeDuration = 2f;

    private float lifeTimer;

    private Collider colision;

    #endregion


    #region MonoBehaviour Callbacks

    private void Start()
    {
        lifeTimer = lifeDuration;
        colision = this.GetComponent<Collider>();
    }
    private void Update()
    {
        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
       
    }

    #endregion

    #region Private Methods
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.Log(contact.point);
        }
    }

    #endregion
}
