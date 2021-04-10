using UnityEngine;
public class MoveController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _force;

    private Rigidbody _rb;
    private Vector3 _move;
    private bool _ground;
    private float _mouseX;

    public void Death()
    {
        FindObjectOfType<YouLose>().Lose();
    }
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        float horizontal = Input.GetAxis(AxisManager.HORIZONTAL) * _speed;
        float vertical = Input.GetAxis(AxisManager.VERTICAL) * _speed;

        _move = new Vector3(horizontal, 0, vertical);
        transform.Translate(_move * 0.01f);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _ground)
        {
            _rb.AddForce(Vector3.up * _force);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _ground = false;
        }
    }
}
