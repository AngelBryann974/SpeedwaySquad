using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteScore : MonoBehaviour {

    void OnTriggerEnter()
    {
        ModeScore.CurrentScore -= 20;
        gameObject.SetActive(false);
    }
}
