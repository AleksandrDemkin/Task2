using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{

    CharacterController _characterController;

    [SerializeField]
    private float _speed = 1;
    
    [SerializeField]
    private float _speed_rotation = 3;

    // Start is called before the first frame update
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * _speed_rotation, 0); //rotation
        Vector3 forward = transform.TransformDirection(Vector3.forward); //move direction
        float curSpeed = _speed * Input.GetAxis("Horizontal");//move speed
        _characterController.SimpleMove(forward * curSpeed);//speed and direction to CharacterController
    }
}
