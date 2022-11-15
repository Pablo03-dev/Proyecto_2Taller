using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoverEscenas()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void CargarTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void CargarLevel1()
    {
        SceneManager.LoadScene("nivel1");
        Time.timeScale = 1;
    }

    public void Cargarlevel2()
    {
        SceneManager.LoadScene("nivel2");
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("EscenaTD");
    }

    public void BackMainMenu()
    {
        
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
}
