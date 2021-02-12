using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RightMuseClickDown => Input.GetMouseButtonDown(1);

    }
}

