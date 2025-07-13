using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody _swingRigidbody;
    [SerializeField] private float _force = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _swingRigidbody.AddForce(transform.right * _force, ForceMode.Force);
        }
    }
}
