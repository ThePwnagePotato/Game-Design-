﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour {

  
    public void NextScene()
    {

        SceneManager.LoadScene("Scene1");
    }

}
