using UnityEngine;
using System.Collections;

public class WeaponAiming : MonoBehaviour {

    public GameObject gunPrefab;
    public GameObject avatarPrefab;
    public float speed;

    void Start()
    {
        avatarPrefab = Resources.Load("avatar") as GameObject;
        gunPrefab = Resources.Load("gun") as GameObject;
        gunPrefab.transform.parent = avatarPrefab.transform;
    }
	void FixedUpdate()
    {
         var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

         transform.rotation = rot;
         transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        
         Rigidbody2D rb = GetComponent<Rigidbody2D>();
         rb.AddForce(gameObject.transform.up * speed);
    }
}
