﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace EjderhaSavasi.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButtonClick()
        {
            GameManager.Instance.ReturnMenu();
        }

    }
}

