using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LevelController : MonoBehaviour
{
    public void VoltarMenu()
    {
        SceneManager.LoadScene("SCN_Menu");
    }
}
