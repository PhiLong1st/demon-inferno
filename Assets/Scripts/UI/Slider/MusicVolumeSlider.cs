using UnityEngine;
public class MusicVolumeSlider : BaseSlider
{
    [SerializeField] private float defaultVolume = 1f;

    private void Start()
    {
        slider.value = defaultVolume;
    }

    protected override void HandleValueChanged(float value) => AudioManager.Instance.SetMusicVolume(value);
}
