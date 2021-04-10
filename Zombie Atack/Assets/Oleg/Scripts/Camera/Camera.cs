using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _head;
    [SerializeField] private float _force;
    private float _mouseX;
    private float _mouseY;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        //_mouseX = Input.mousePosition.x * _force;
        //_mouseY = Input.mousePosition.y * _force;

        _mouseX += Input.GetAxis("Mouse X") * _force;
        _mouseY += Input.GetAxis("Mouse Y") * _force;

        _mouseY = Mathf.Clamp(_mouseY, -90, 90);

        Quaternion rotateX = Quaternion.AngleAxis(_mouseX, Vector3.up);
        Quaternion rotateY = Quaternion.AngleAxis(-_mouseY, Vector3.right);

        _head.transform.rotation = rotateX * rotateY;
        _player.transform.rotation = rotateX;
    }
}
