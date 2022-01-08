using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class buttons : MonoBehaviour
{
    [SerializeField] Sprite spr;
    string sc;
    public void To_Scene(string scene)
    {
        GetComponent<Image>().sprite = spr;
        sc = scene;
        Invoke("the_scene", .5f);
    }

    void the_scene()
    {
        SceneManager.LoadScene(sc);
    }

    public void To_Exit()
    {
        GetComponent<Image>().sprite = spr;
        Application.Quit();
    }
}
