using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneDriftTrack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start () {
          StartCoroutine(CreditEnd());
  	}

      IEnumerator CreditEnd()
      {
          yield return new WaitForSeconds(5);
          SceneManager.LoadScene(3);
      }
}
