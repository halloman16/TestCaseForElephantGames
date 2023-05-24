using UnityEngine;

public class EnableButton : MonoBehaviour
{
    [SerializeField] private GameObject _nextLevelButton;

    private void OnMouseDown()
    {
        _nextLevelButton.SetActive(true);
    }
}
