using UnityEngine;

public class MouseScreeRayProviderC : MonoBehaviour, IRayProviderC
{
    public Ray CreateRayC()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}