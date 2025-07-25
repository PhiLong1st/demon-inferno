using UnityEngine;
public class ExitButton : BaseButton
{
  protected override void HandleClick()
  {
    Application.Quit();
  }
}