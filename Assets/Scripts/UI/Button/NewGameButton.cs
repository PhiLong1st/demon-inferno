using UnityEngine;

public class NewGameButton : BaseButton
{
  [Header("Change Scene")]
  [SerializeField] private string sceneNameToLoad;

  protected override void HandleClick()
  {
    SceneLoader.Instance.LoadScene(sceneNameToLoad);
  }
}
