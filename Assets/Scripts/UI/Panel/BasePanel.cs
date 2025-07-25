using UnityEngine;
public class BasePanel : MonoBehaviour
{
  [SerializeField] private bool isPauseWhenOpen = false;

  private void OnEnable()
  {
    if (isPauseWhenOpen)
    {
      Time.timeScale = 0;
    }
  }

  private void OnDisable()
  {
    if (isPauseWhenOpen)
    {
      Time.timeScale = 1;
    }
  }
}