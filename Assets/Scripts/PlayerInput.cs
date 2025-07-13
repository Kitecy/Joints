using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action SpaceButtonClicked;
    public event Action FireButtonClicked;
    public event Action ReloadingButtonClicked;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpaceButtonClicked?.Invoke();

        if (Input.GetKeyDown(KeyCode.F))
            FireButtonClicked?.Invoke();

        if (Input.GetKeyDown(KeyCode.R))
            ReloadingButtonClicked?.Invoke();
    }
}
