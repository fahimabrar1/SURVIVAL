using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject homescreen,mapscreen;

    private void Start()
    {
        mapscreen.SetActive(false);
    }
    public void NewGame()
    {
        homescreen.SetActive(false);
        mapscreen.SetActive(true);
    }
}
