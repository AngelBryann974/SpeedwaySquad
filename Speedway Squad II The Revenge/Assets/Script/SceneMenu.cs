using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
  public void cambiarescena(string nombreescena)
  {
      SceneManager.LoadScene(1);
  }
}
