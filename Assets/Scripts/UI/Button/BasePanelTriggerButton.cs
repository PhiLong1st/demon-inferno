using UnityEngine;

public class BasePanelTriggerButton : BaseButton
{
  [SerializeField] private bool triggerPanelActive = true;
  [SerializeField] private GameObject panelToTrigger;

  protected override void HandleClick()
  {
    panelToTrigger.SetActive(triggerPanelActive);
  }
}
