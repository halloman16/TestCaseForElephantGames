using UnityEngine;

public class RunAnimation : MonoBehaviour
{
    [SerializeField] private Animation _animation;

    private void OnMouseDown()
    {
        _animation.Play();
    }
}
