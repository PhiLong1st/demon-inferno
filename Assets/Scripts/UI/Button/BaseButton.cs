using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        AudioManager.Instance.PlaySFX(AudioSFXEnum.ButtonClick);
        HandleClick();
    }
    protected abstract void HandleClick();
}
