using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
      
        [SerializeField] private int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enimy"))
        {
            var enemy = other.GetComponent<Enimy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
