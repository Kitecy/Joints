using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;

    public void Spawn(Vector3 position)
    {
        Transform bullet = Instantiate(_prefab, position, Quaternion.identity).transform;
        bullet.position = position;
    }
}
