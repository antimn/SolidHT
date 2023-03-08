using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private IRayProviderC _rayProvider;
    private ISelectionResponse _selectionResponse;
    private ISelectorC _selector;


    private Transform _currentSelection;
    private Transform _selection;

    private void Awake()
    {
        _rayProvider = GetComponent<IRayProviderC>();
        _selector = GetComponent<ISelectorC>();
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update()
    {
        if (_currentSelection != null) _selectionResponse.OnDeselect(_currentSelection);

        _selector.CheckC(_rayProvider.CreateRayC());
        _currentSelection = _selector.GetSelectionC();

        if (_currentSelection != null) _selectionResponse.OnSelect(_currentSelection);
    }
}