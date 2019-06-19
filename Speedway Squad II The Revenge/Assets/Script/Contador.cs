using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public string nombre;

    [SerializeField]Text contadorTexto;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        contadorTexto.text = currentTime.ToString("0");

        if(currentTime < 0)
        {
            SceneManager.LoadScene(nombre);
        }
    }
}
