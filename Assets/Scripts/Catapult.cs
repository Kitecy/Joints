using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _joint;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _force;

    private bool _canThrow = true;

    private void OnEnable()
    {
        _playerInput.FireButtonClicked += Fire;
        _playerInput.ReloadingButtonClicked += Reloading;
    }

    private void OnDisable()
    {
        _playerInput.FireButtonClicked -= Fire;
        _playerInput.ReloadingButtonClicked -= Reloading;
    }

    private void Fire()
    {
        if (_canThrow == false)
            return;

        _canThrow = true;

        _joint.connectedAnchor = new Vector3(_joint.connectedAnchor.x, -_force, _joint.connectedAnchor.z);
    }

    private void Reloading()
    {
        _canThrow = true;
        _joint.connectedAnchor = new Vector3(_joint.connectedAnchor.x, 0, _joint.connectedAnchor.z);

    }
}
