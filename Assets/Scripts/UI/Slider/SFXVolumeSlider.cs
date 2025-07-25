using UnityEngine;

public class SFXVolumeSlider : BaseSlider
{
    [SerializeField] private float defaultVolume = 1f;

    private void Start()
    {
        slider.value = defaultVolume;
    }

    protected override void HandleValueChanged(float value) => AudioManager.Instance.SetSFXVolume(value);
}
