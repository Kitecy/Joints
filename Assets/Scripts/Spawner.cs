using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    public void Spawn(Vector3 position)
    {
        GameObject @object = Instantiate(_prefab, position, Quaternion.identity);
        @object.transform.position = position;
    }
}
