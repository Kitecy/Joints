using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody _swingRigidbody;
    [SerializeField] private PlayerInput _input;
    [SerializeField] private float _force = 5f;

    private void OnEnable()
    {
        _input.SpaceButtonClicked += RockIt;
    }

    private void OnDisable()
    {
        _input.SpaceButtonClicked -= RockIt;
    }

    private void RockIt()
    {
        _swingRigidbody.AddForce(transform.right * _force, ForceMode.Force);
    }
}
