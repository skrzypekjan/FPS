using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    #region Variables

    [SerializeField]
    GameObject bullet;
    public Camera playerCamera;

    #endregion


    #region MonoBehaviour Callbacks

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }
    }

    #endregion


    #region Private Methods

    void SpawnBullet()
    {
        Rigidbody _bullet = (Rigidbody) Instantiate(bullet.GetComponent<Rigidbody>(), new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        _bullet.velocity = _bullet.transform.forward * 25.5f;

    }


    #endregion
}
