using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimy : MonoBehaviour
{
    public GameObject enemy;

    [SerializeField] private int _health;

    public void Hurt(int damage)
    {
        print("Ouch: " +damage);

        _health -= damage; ;

        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

//    // Start is called before the first frame update
//    void Start()
//        {
//    for (int i = 0; i < 5; i++)
//    {
//        Instantiate(enemy);
//    }
//}

//void OnCollisionEnter(Collision otherObj)
//{
//    if (otherObj.gameObject.tag == "Enimy")
//    {
//        Destroy(gameObject, .5f);
//    }
//}

//// Update is called once per frame
//void Update()
//    {
        
//    }
}
