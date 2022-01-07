using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
  public GameObject pauseMenu;

  void Update()
  {
  }

  public void LoadMenu()
  {
    Time.timeScale = 1;
    SceneManager.LoadScene("Menu");
  }

  public void OnApplicationPause()
  {
    pauseMenu.SetActive(!pauseMenu.activeSelf);
    Time.timeScale = pauseMenu.activeSelf ? 0 : 1;
  }
}
