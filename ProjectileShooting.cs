using UnityEngine;
using System.Collections;

public class ProjectileShooting : MonoBehaviour {

    public GameObject prefab;
    public Transform spawner;
    public float bulletSpeed = 5000;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float yValue = 1f;
    public float xValue = 0.2f;

    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    void Update()
    {
        if(Time.time >= coolDown)
        {
            if(Input.GetMouseButton(0))
            {
                Fire();

            }
        }
    }

    void Fire()
    {
        
        prefab = Instantiate(prefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as GameObject;
        Rigidbody2D rb = prefab.GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(transform.right * bulletSpeed);

        coolDown = Time.time + attackSpeed;
    }
}
