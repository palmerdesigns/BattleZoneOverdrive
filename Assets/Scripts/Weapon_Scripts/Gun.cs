using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPos;
    [SerializeField]
    public float bulletSpeed = 60f; 


    private void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {
        if (_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab,bulletPos.transform.position,transform.rotation);
       bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
       Destroy(bullet,1);
    }
}
