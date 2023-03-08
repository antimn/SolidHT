using UnityEngine;

public class RayCastBasedTagSelectorC : MonoBehaviour, ISelectorC
{
    [SerializeField] public string selectableTag = "Selectable";
    public Transform _selection;

    public void CheckC(Ray ray)
    {
        this._selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(this.selectableTag))
            {
                this._selection = selection;
            }
        }
    }

    public Transform GetSelectionC()
    {
        return this._selection;
    }
}