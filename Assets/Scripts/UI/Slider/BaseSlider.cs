using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSlider : MonoBehaviour
{
  protected Slider slider;
  protected abstract void HandleValueChanged(float value);

  void Awake()
  {
    slider = GetComponent<Slider>();

    if (slider != null)
    {
      slider.onValueChanged.AddListener(HandleValueChanged);
    }
  }

  public void SetSliderValue(float value)
  {
    if (slider != null)
    {
      slider.value = value;
    }
  }
}
