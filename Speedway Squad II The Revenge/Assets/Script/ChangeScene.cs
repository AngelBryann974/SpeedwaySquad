using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	void Start () {
        StartCoroutine(CreditEnd());
	}

    IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(4);
    }


}
